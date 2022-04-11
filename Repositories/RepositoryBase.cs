using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CadastroTeste.DAO;
using Microsoft.EntityFrameworkCore;


namespace CadastroTeste.Repositories
{
    public abstract class RepositoryBase<T, TContext> : IRepositoryBase<T> where T : class where TContext : DbContext
    {
        private readonly TContext context;

        public RepositoryBase(TContext context)
        {
            this.context = context;
        }

        public async Task<List<T>> Get()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int Id)
        {
            return await context.Set<T>().FindAsync(Id);
        }
        public async Task Add(T entity)
        { 
            await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public Task Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            return context.SaveChangesAsync();
        }

        public Task Remove(T entity)
        {
            context.Set<T>().Remove(entity);
            return context.SaveChangesAsync();
        }
    }
}