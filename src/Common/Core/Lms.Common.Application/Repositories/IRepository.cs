using Lms.Comman.Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Lms.Common.Application.Repositories
{
    public interface ICreateRepository<TEntity> : IBaseRepository where TEntity : class, IEntity
    {
        /// <summary>
        /// To addAsync entity
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default);

        /// <summary>
        /// To addAsync entity
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> AddAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
    }

    public interface ICommandRepository<TEntity> : ICreateRepository<TEntity> where TEntity : class, IEntity
    {
        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Updated entity</returns>
        Task<TEntity> UpdateAsync(TEntity entity);

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Updated entity</returns>
        Task<TEntity> UpdateByCheckAsync(TEntity entity);

        /// <summary>
        /// Update list of entities at once
        /// </summary>
        /// <param name="entities"></param>
        /// <returns>Updated entity list</returns>
        Task<IEnumerable<TEntity>> UpdateAsync(IEnumerable<TEntity> entities);

        /// <summary>
        /// Update list of entities at once
        /// </summary>
        /// <param name="entities"></param>
        /// <returns>Updated entity list</returns>
        Task<IEnumerable<TEntity>> UpdateByCheckAsync(IEnumerable<TEntity> entities);

        /// <summary>
        /// Deletes entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>True if action succeed</returns>
        Task<TEntity> DeleteAsync(object id);

        /// <summary>
        /// Deletes entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>True if action succeed</returns>
        Task<TEntity> DeleteAsync(TEntity entity);

        /// <summary>
        /// Deletes entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>True if action succeed</returns>
        Task<TEntity> DeleteByCheckAsync(TEntity entity);

        /// <summary>
        /// Delete multiple entity
        /// </summary>
        /// <param name="entities"></param>
        /// <returns>True if action succeed</returns>
        Task<IEnumerable<TEntity>> DeleteByCheckAsync(IEnumerable<TEntity> entities);
    }

    public interface IQueryRepository<TEntity> : IBaseRepository where TEntity : class, IEntity
    {
        /// <summary>
        /// Queriable dbSet
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> Query();

        Task<bool> AnyAsync(Func<TEntity, bool> search = null, bool ignoreQueryFilter = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets single entity 
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="ignoreQueryFilter"></param>
        /// <param name="includes"></param>
        /// <returns>Filtered entity</returns>
        TEntity Get(Expression<Func<TEntity, bool>> expression, bool ignoreQueryFilter = false, params Expression<Func<TEntity, object>>[] includes);

        /// <summary>
        /// Gets single entity 
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="ignoreQueryFilter"></param>
        /// <param name="includes"></param>
        /// <returns>Filtered entity</returns>
        TEntity GetById(object id, bool ignoreQueryFilter = false, params Expression<Func<TEntity, object>>[] includes);

        /// <summary>
        /// Gets single entity 
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="ignoreQueryFilter"></param>
        /// <param name="includes"></param>
        /// <returns>Filtered entity</returns>
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression, bool ignoreQueryFilter = false, params Expression<Func<TEntity, object>>[] includes);

        /// <summary>
        /// Gets single entity 
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="ignoreQueryFilter"></param>
        /// <param name="includes"></param>
        /// <returns>Filtered entity</returns>
        Task<TEntity> GetByIdAsync(object id, bool ignoreQueryFilter = false, params Expression<Func<TEntity, object>>[] includes);

        /// <summary>
        /// Gets single entity 
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="ignoreQueryFilter"></param>
        /// <param name="includes"></param>
        /// <returns>Filtered entity</returns>
        Task<TEntity> GetByIdAsync(object id, bool ignoreQueryFilter = false, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null);

        /// <summary>
        /// Gets single entity 
        /// </summary>
        /// <param name="search"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="trackChanges"></param>
        /// <param name="ignoreQueryFilter"></param>
        /// <returns></returns>
        Task<TEntity> FirstOrDefaultAsync(Func<TEntity, bool> search = null, CancellationToken cancellationToken = default,
            bool trackChanges = false, bool ignoreQueryFilter = false);

        /// <summary>
        /// Gets single entity 
        /// </summary>
        /// <param name="search"></param>
        /// <param name="ignoreQueryFilter"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<TEntity> LastOrDefaultAsync(Func<TEntity, bool> search = null, bool ignoreQueryFilter = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// List paged response entity
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="orderBy"></param>
        /// <param name="searchQuery"></param>
        /// <param name="ignoreQueryFilter"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IReadOnlyList<TEntity>> GetPagedReponseAsync(int page, int size, string orderBy = "",
            Func<TEntity, bool> searchQuery = null, bool ignoreQueryFilter = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// List entity
        /// </summary>
        /// <param name="ignoreQueryFilter"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IReadOnlyList<TEntity>> ListAllAsync(bool ignoreQueryFilter = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// get count entity
        /// </summary>
        /// <param name="search"></param>
        /// <param name="ignoreQueryFilter"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<int> CountAsync(Func<TEntity, bool> search = null, bool ignoreQueryFilter = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get count entity
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="ignoreQueryFilter"></param>
        /// <returns></returns>
        Task<long> GetCountAsync(Expression<Func<TEntity, bool>> expression = null, bool ignoreQueryFilter = false);

        /// <summary>
        /// filters and returns list of entities
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="skip"></param>
        /// <param name="take"></param>
        /// <param name="ignoreQueryFilter"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, int skip = 0, int take = 0, bool ignoreQueryFilter = false, params Expression<Func<TEntity, object>>[] includes);

        /// <summary>
        /// filters and returns list of entities
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="skip"></param>
        /// <param name="take"></param>
        /// <param name="ignoreQueryFilter"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, int skip = 0, int take = 0, bool ignoreQueryFilter = false, params Expression<Func<TEntity, object>>[] includes);
        Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, int skip = 0, int take = 0, bool ignoreQueryFilter = false, Func<IQueryable<TEntity>,
            IIncludableQueryable<TEntity, object>> include = null);
    }

    public interface IRepository<TEntity> : ICommandRepository<TEntity>, IQueryRepository<TEntity> where TEntity : class, IEntity
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
