
using Microsoft.EntityFrameworkCore;
using Fresh.Application.Interfaces;
using Fresh.Infrastructure.EF;

namespace Fresh.Infrastructure.Repositories;

public class Repository<T>(FreshContext db) : IRepository<T>
    where T : class
{
    private readonly DbSet<T> _dbSet = db.Set<T>();

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T?> Get(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task Create(T item)
    {
        await _dbSet.AddAsync(item);
    }

    public void Update(T item)
    {
        db.Entry(item).State = EntityState.Modified;
    }

    public async Task Delete(int id)
    {
        var item = await _dbSet.FindAsync(id);

        if (item != null)
        {
            _dbSet.Remove(item);
        }
    }
}
