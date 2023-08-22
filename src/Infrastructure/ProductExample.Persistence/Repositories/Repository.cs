﻿using Microsoft.EntityFrameworkCore;
using Lms.Application.Interfaces.Repositories;
using Lms.Domain.Common;
using Lms.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        readonly ApplicationDbContext _applicationDbContext;
        public Repository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        private DbSet<T> Table { get => _applicationDbContext.Set<T>(); }
        //private DbSet<T> Table => _applicationDbContext.Set<T>();
        public async Task<T> AddAsync(T model)
        {
            await Table.AddAsync(model);
            await _applicationDbContext.SaveChangesAsync();
            return model;
        }
        public async Task<List<T>> GetAsync()
        {
            return await Table.ToListAsync();
        }
        public async Task<T> GetByIdAsync(Guid id)
        {
            return await Table.FindAsync(id);
        }
        public async Task<List<T>> GetWhereAsync(Expression<Func<T, bool>> expression)
        {
            return await Table.Where(expression).ToListAsync();
        }
        public async Task<T> RemoveAsync(T model)
        {
            Table.Remove(model);
            await _applicationDbContext.SaveChangesAsync();
            return model;
        }
    }
}
