using Lms.Common.Application.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Domain.EntityExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq.Expressions;

namespace Lms.Comman.Persistence.Repositories
{
    public abstract class AAuditableRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IAuditableEntity
        where TContext : DbContext
    {
        public readonly TContext _dbContext;
        //private readonly PaginationSettings _paginationSettings;
        private readonly ILogger<TEntity> _logger;
        private readonly string entityName;

        public AAuditableRepository(TContext dbContext
            //IOptions<PaginationSettings> options,
            , ILogger<TEntity> logger
            )
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(TContext));
            //_paginationSettings = options?.Value ?? throw new ArgumentNullException(nameof(PaginationSettings));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            entityName = typeof(TEntity).Name;
        }

        private string getJson(TEntity entity)
        {
            string json = JsonConvert.SerializeObject(entity, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore,
            });
            return json;
        }
        #region Commands

        #region Add

        public virtual async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            entity.SetCreatedValues();
            if (entity.Id.ToString() == (new Guid()).ToString())
                entity.Id = Guid.NewGuid();

            await _dbContext.Set<TEntity>().AddAsync(entity, cancellationToken);
            return entity;
        }

        public virtual async Task<IEnumerable<TEntity>> AddAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken)
        {
            foreach (var entity in entities)
                await AddAsync(entity);
            return entities;
        }

        #endregion

        #region Update

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            entity.SetUpdatedValues();

            #region Created değerleri güncellenmesin
            _dbContext.Entry(entity).Property(x => x.CreatedById).IsModified = false;
            _dbContext.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
            #endregion

            _dbContext.Set<TEntity>().Update(entity);
            return entity;
        }

        public async Task<IEnumerable<TEntity>> UpdateAsync(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                entity.SetUpdatedValues();

                #region Created değerleri güncellenmesin
                _dbContext.Entry(entity).Property(x => x.CreatedById).IsModified = false;
                _dbContext.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                #endregion
            }

            _dbContext.Set<TEntity>().UpdateRange(entities);
            return entities;
        }

        public async Task<TEntity> UpdateByCheckAsync(TEntity entity)
        {
            var model = _dbContext.Set<TEntity>().Where(x => x.Id == entity.Id).AsNoTracking().FirstOrDefault();
            if (model == null)
                throw new ArgumentNullException(typeof(TEntity).Name);
            entity.ChangeCreatedValues(model);
            entity.SetUpdatedValues();

            #region Created değerleri güncellenmesin
            _dbContext.Entry(entity).Property(x => x.CreatedById).IsModified = false;
            _dbContext.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
            #endregion

            _dbContext.Set<TEntity>().Update(entity);
            return entity;
        }

        public async Task<IEnumerable<TEntity>> UpdateByCheckAsync(IEnumerable<TEntity> entities)
        {
            var idList = entities.Select(x => x.Id).ToList();
            var models = _dbContext.Set<TEntity>().Where(x => idList.Contains(x.Id)).ToList();

            if (models.Count() != idList.Count())
                throw new ArgumentNullException(typeof(TEntity).Name);

            foreach (var entity in entities)
                await this.UpdateByCheckAsync(entity);

            return entities;
        }

        #endregion

        #region Delete

        public async Task<TEntity> DeleteAsync(object id)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            if (entity == null)
                throw new ArgumentNullException(typeof(TEntity).Name);

            return await DeleteAsync(entity);
        }

        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            entity.SetDeletedValues();

            _dbContext.Set<TEntity>().Update(entity);
            return entity;
        }

        public async Task<TEntity> DeleteByCheckAsync(TEntity entity)
        {
            entity.IsDeleted = true;
            await UpdateByCheckAsync(entity);
            return entity;
        }

        public async Task<IEnumerable<TEntity>> DeleteAsync(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
                entity.SetDeletedValues();

            _dbContext.Set<TEntity>().UpdateRange(entities);
            return entities;
        }
        public async Task<IEnumerable<TEntity>> DeleteByCheckAsync(IEnumerable<TEntity> entities)
        {
            var idList = entities.Select(x => x.Id).ToList();
            var models = _dbContext.Set<TEntity>().Where(x => idList.Contains(x.Id)).ToList();

            if (models.Count() != idList.Count())
                throw new ArgumentNullException(typeof(TEntity).Name);

            foreach (var entity in entities)
                entity.IsDeleted = true;

            await UpdateByCheckAsync(entities);
            return entities;
        }

        #endregion

        #endregion

        #region Query

        public virtual IQueryable<TEntity> Query()
        {
            return _dbContext.Set<TEntity>();
        }


        public virtual async Task<bool> AnyAsync(Func<TEntity, bool> search = null, bool ignoreQueryFilter = false, CancellationToken cancellationToken = default)
        {
            if (search == null)
                return ignoreQueryFilter ? await _dbContext.Set<TEntity>().AsNoTracking().IgnoreQueryFilters().AnyAsync(cancellationToken) : await _dbContext.Set<TEntity>().AsNoTracking().AnyAsync(cancellationToken);

            return await SafeAnyAsync(_dbContext.Set<TEntity>().AsNoTracking().Where(search).AsQueryable(), ignoreQueryFilter, cancellationToken);
        }

        public virtual TEntity Get(Expression<Func<TEntity, bool>> expression, bool ignoreQueryFilter = false, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();

            if (ignoreQueryFilter)
            {
                query = query.IgnoreQueryFilters();
            }

            foreach (Expression<Func<TEntity, object>> include in includes)
            {
                query = query.Include(include);
            }
            return query.AsNoTracking().AsQueryable().FirstOrDefault(expression);
        }

        public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression, bool ignoreQueryFilter = false, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();

            if (ignoreQueryFilter)
            {
                query = query.IgnoreQueryFilters();
            }

            foreach (Expression<Func<TEntity, object>> include in includes)
            {
                query = query.Include(include);
            }
            return await query.AsNoTracking().AsQueryable().FirstOrDefaultAsync(expression);
        }

        public virtual TEntity GetById(object id, bool ignoreQueryFilter = false, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();

            if (ignoreQueryFilter)
            {
                query = query.IgnoreQueryFilters();
            }

            foreach (Expression<Func<TEntity, object>> include in includes)
            {
                query = query.Include(include);
            }
            return query.Where(x => x.Id == id).AsNoTracking().FirstOrDefault();
        }

        public virtual async Task<TEntity> GetByIdAsync(object id, bool ignoreQueryFilter = false, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();

            if (ignoreQueryFilter)
            {
                query = query.IgnoreQueryFilters();
            }

            foreach (Expression<Func<TEntity, object>> include in includes)
            {
                query = query.Include(include);
            }
            return await query.Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<TEntity> GetByIdAsync(object id, bool ignoreQueryFilter = false, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();

            if (ignoreQueryFilter)
                query = query.IgnoreQueryFilters();

            if (include != null)
                query = include(query);

            return await query.Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
        }

        public virtual async Task<TEntity> FirstOrDefaultAsync(Func<TEntity, bool> search = null, CancellationToken cancellationToken = default, bool trackChanges = false, bool ignoreQueryFilter = false)
        {
            if (trackChanges)
            {
                if (search == null)
                    return ignoreQueryFilter ?
                        await _dbContext.Set<TEntity>().IgnoreQueryFilters().FirstOrDefaultAsync(cancellationToken) :
                        await _dbContext.Set<TEntity>().FirstOrDefaultAsync(cancellationToken);

                return await SafeFirstOrDefaultAsync(_dbContext.Set<TEntity>().Where(search).AsQueryable(), ignoreQueryFilter, cancellationToken);
            }
            else
            {
                if (search == null)
                    return ignoreQueryFilter ?
                        await _dbContext.Set<TEntity>().AsNoTracking().IgnoreQueryFilters().FirstOrDefaultAsync(cancellationToken) :
                        await _dbContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(cancellationToken);
                return await SafeFirstOrDefaultAsync(_dbContext.Set<TEntity>().AsNoTracking().Where(search).AsQueryable(), ignoreQueryFilter, cancellationToken);
            }
        }

        public virtual async Task<TEntity> LastOrDefaultAsync(Func<TEntity, bool> search = null, bool ignoreQueryFilter = false, CancellationToken cancellationToken = default)
        {
            if (search == null)
                return ignoreQueryFilter ?
                    await _dbContext.Set<TEntity>().AsNoTracking().IgnoreQueryFilters().LastOrDefaultAsync(cancellationToken) :
                    await _dbContext.Set<TEntity>().AsNoTracking().LastOrDefaultAsync(cancellationToken);

            return await SafeLastOrDefaultAsync(_dbContext.Set<TEntity>().AsNoTracking().Where(search).AsQueryable(), ignoreQueryFilter, cancellationToken);
        }

        /// <summary>
        /// Get paged entity
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="orderBy">Example: FirstName desc, LastName asc, Birthdate desc</param>
        /// <param name="searchQuery"></param>
        /// <param name="ignoreQueryFilter"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<IReadOnlyList<TEntity>> GetPagedReponseAsync(int page, int size, string orderBy = "", Func<TEntity, bool> searchQuery = null, bool ignoreQueryFilter = false, CancellationToken cancellationToken = default)
        {
            if (searchQuery == null)
                return await GetPagedReponseAsync(page, size, orderBy, ignoreQueryFilter, cancellationToken);
            else
                return await GetFilterPagedReponseAsync(page, size, orderBy, searchQuery, ignoreQueryFilter, cancellationToken);
        }

        public virtual async Task<IReadOnlyList<TEntity>> ListAllAsync(bool ignoreQueryFilter = false, CancellationToken cancellationToken = default)
        {
            return ignoreQueryFilter ?
                 await _dbContext.Set<TEntity>().AsNoTracking().IgnoreQueryFilters().ToListAsync(cancellationToken) :
                 await _dbContext.Set<TEntity>().AsNoTracking().ToListAsync(cancellationToken);
        }

        public virtual async Task<int> CountAsync(Func<TEntity, bool> search = null, bool ignoreQueryFilter = false, CancellationToken cancellationToken = default)
        {
            if (search == null)
                return ignoreQueryFilter ?
                    await _dbContext.Set<TEntity>().AsNoTracking().IgnoreQueryFilters().CountAsync(cancellationToken) :
                    await _dbContext.Set<TEntity>().AsNoTracking().CountAsync(cancellationToken);

            return await SafeCountAsync(_dbContext.Set<TEntity>().AsNoTracking().Where(search).AsQueryable(), ignoreQueryFilter, cancellationToken);
        }

        public virtual async Task<long> GetCountAsync(Expression<Func<TEntity, bool>> expression = null, bool ignoreQueryFilter = false)
        {
            var query = _dbContext.Set<TEntity>().AsNoTracking().AsQueryable();

            if (ignoreQueryFilter)
            {
                query = query.IgnoreQueryFilters();
            }

            if (expression == null)
            {
                return await _dbContext.Set<TEntity>().LongCountAsync();
            }

            return await query.LongCountAsync(expression);
        }

        public virtual List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, int skip = 0, int take = 0, bool ignoreQueryFilter = false, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>().AsQueryable();

            if (ignoreQueryFilter)
            {
                query = query.IgnoreQueryFilters();
            }

            foreach (Expression<Func<TEntity, object>> include in includes)
            {
                query = query.Include(include);
            }

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (take != 0)
            {
                query = query.Skip(skip).Take(take);
            }

            return query.AsNoTracking().ToList();
        }

        public virtual async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, int skip = 0, int take = 0, bool ignoreQueryFilter = false, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>().AsNoTracking().AsQueryable();

            if (ignoreQueryFilter)
            {
                query = query.IgnoreQueryFilters();
            }

            foreach (Expression<Func<TEntity, object>> include in includes)
            {
                query = query.Include(include);
            }

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (take != 0)
            {
                query = query.Skip(skip).Take(take);
            }

            return await query.AsNoTracking().ToListAsync();
        }

        public virtual async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, int skip = 0, int take = 0, bool ignoreQueryFilter = false, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>().AsNoTracking().AsQueryable();

            if (ignoreQueryFilter)
            {
                query = query.IgnoreQueryFilters();
            }

            if (include != null)
                query = include(query);

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (take != 0)
            {
                query = query.Skip(skip).Take(take);
            }

            return await query.AsNoTracking().ToListAsync();
        }

        public virtual async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            int result;
            try
            {
                result = await _dbContext.SaveChangesAsync(cancellationToken);
            }
            catch (DbUpdateException ex)
            {
                Guid logId = Guid.NewGuid();
                _logger.LogError(ex, $"DbUpdateException - ErrorId: {logId} Could not save changes on database for entity: {typeof(TEntity).Name}!", logId);
#if DEBUG
                throw;
#endif
                throw new Exception($"{StatusCodes.Status500InternalServerError} Refer to this Error Id: {logId} for further investigation with system administrator.");
            }
            catch (Exception ex)
            {
                Guid logId = Guid.NewGuid();
                _logger.LogError(ex, $"Exception - ErrorId: {logId} Could not save changes on database for entity: {typeof(TEntity).Name}!", logId);
#if DEBUG
                throw;
#endif
                throw new Exception($"{StatusCodes.Status500InternalServerError} Refer to this Error Id: {logId} for further investigation with system administrator.");
            }
            if (result < 1)
                _logger.LogError("Changes could not be saved on database! Expand this log message to include further details...");

            return result;
        }

        //public int EvaluatePageWithConfig(int page)
        //{
        //    return (page < 1) ? _paginationSettings.PageNumber : page;
        //}

        //public int EvaluateSizeWithConfig(int size)
        //{
        //    return (size < 1 || size > _paginationSettings.MaxPageSize) ? _paginationSettings.PageSize : size;
        //}

        #endregion

        #region Private Methods

        protected async Task<int> SafeCountAsync(IQueryable<TEntity> source, bool ignoreQueryFilter = false, CancellationToken cancellationToken = default)
        {
            if (source == null)
                throw new ArgumentNullException(typeof(TEntity).Name);
            if (ignoreQueryFilter)
                source = source.IgnoreQueryFilters();
            if (source is not IAsyncEnumerable<TEntity>)
                return await Task.FromResult(source.Count());
            return await source.CountAsync(cancellationToken);
        }

        protected async Task<List<TEntity>> SafeListAsync(IQueryable<TEntity> source, CancellationToken cancellationToken = default)
        {
            if (source == null)
                throw new ArgumentNullException(typeof(TEntity).Name);
            if (source is not IAsyncEnumerable<TEntity>)
                return await Task.FromResult(source.ToList());
            return await source.ToListAsync(cancellationToken);
        }

        protected async Task<bool> SafeAnyAsync(IQueryable<TEntity> source, bool ignoreQueryFilter = false, CancellationToken cancellationToken = default)
        {
            if (source == null)
                throw new ArgumentNullException(typeof(TEntity).Name);
            if (ignoreQueryFilter)
                source = source.IgnoreQueryFilters();
            if (source is not IAsyncEnumerable<TEntity>)
                return await Task.FromResult(source.Any());
            return await source.AnyAsync(cancellationToken);
        }

        protected async Task<TEntity> SafeFirstOrDefaultAsync(IQueryable<TEntity> source, bool ignoreQueryFilter = false, CancellationToken cancellationToken = default)
        {
            if (source == null)
                throw new ArgumentNullException(typeof(TEntity).Name);
            if (ignoreQueryFilter)
                source = source.IgnoreQueryFilters();
            if (source is not IAsyncEnumerable<TEntity>)
                return await Task.FromResult(source.FirstOrDefault());
            return await source.FirstOrDefaultAsync(cancellationToken);
        }

        protected async Task<TEntity> SafeLastOrDefaultAsync(IQueryable<TEntity> source, bool ignoreQueryFilter = false, CancellationToken cancellationToken = default)
        {
            if (source == null)
                throw new ArgumentNullException(typeof(TEntity).Name);
            if (ignoreQueryFilter)
                source = source.IgnoreQueryFilters();
            if (source is not IAsyncEnumerable<TEntity>)
                return await Task.FromResult(source.LastOrDefault());
            return await source.LastOrDefaultAsync(cancellationToken);
        }

        protected async Task<IReadOnlyList<TEntity>> GetPagedReponseAsync(int page, int size, string orderBy, bool ignoreQueryFilter = false, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(orderBy)) //&& ObjectExtensions.IsOrderByValid<TEntity>(orderBy, ",")
                return ignoreQueryFilter ?
                    await _dbContext.Set<TEntity>().AsNoTracking().IgnoreQueryFilters().OrderBy(x => orderBy).Skip((page - 1) * size).Take(size).ToListAsync(cancellationToken) :
                    await _dbContext.Set<TEntity>().AsNoTracking().OrderBy(x => orderBy).Skip((page - 1) * size).Take(size).ToListAsync(cancellationToken);
            return ignoreQueryFilter ?
                await _dbContext.Set<TEntity>().IgnoreQueryFilters().Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync(cancellationToken) :
                await _dbContext.Set<TEntity>().Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync(cancellationToken);
        }

        protected async Task<IReadOnlyList<TEntity>> GetFilterPagedReponseAsync(int page, int size, string orderBy, Func<TEntity, bool> searchQuery, bool ignoreQueryFilter = false, CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> entityQuery = _dbContext.Set<TEntity>().AsNoTracking().Where(searchQuery).AsQueryable();
            if (ignoreQueryFilter)
            {
                entityQuery = entityQuery.IgnoreQueryFilters();
            }

            if (string.IsNullOrEmpty(orderBy))//&& ObjectExtensions.IsOrderByValid<TEntity>(orderBy, ",")
                entityQuery = entityQuery.OrderBy(x => orderBy).Skip((page - 1) * size).Take(size);
            else
                entityQuery = entityQuery.Skip((page - 1) * size).Take(size);
            return await SafeListAsync(entityQuery, cancellationToken);
        }



        #endregion
    }
}
