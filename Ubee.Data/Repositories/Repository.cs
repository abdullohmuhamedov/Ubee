using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Ubee.Data.Contexts;
using Ubee.Data.IRepositories;
using Ubee.Domain.Commons;

namespace Ubee.Data.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
{
    protected readonly AppDbContext appDbContext;
    protected readonly DbSet<TEntity> dbSet;

    public Repository(AppDbContext appDbContext, DbSet<TEntity> dbSet)
    {
        this.appDbContext = appDbContext;
        this.dbSet = dbSet;
    }
    public ValueTask<bool> DeleteAsync(Expression<Func<TEntity, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public bool DeleteMany(Expression<Func<TEntity, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public ValueTask<TEntity> InsertAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public ValueTask SaveAsync()
    {
        throw new NotImplementedException();
    }

    public IQueryable<TEntity> SelectAll(Expression<Func<TEntity, bool>> expression = null, string[] includes = null)
    {
        throw new NotImplementedException();
    }

    public ValueTask<TEntity> SelectAsync(Expression<Func<TEntity, bool>> expression, string[] includes = null)
    {
        throw new NotImplementedException();
    }

    public ValueTask<TEntity> UpdateAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
