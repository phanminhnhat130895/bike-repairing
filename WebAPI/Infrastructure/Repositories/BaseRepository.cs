using Application.Repositories;
using Domain.Common;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Entity
    {
        protected readonly DataContext _context;

        public BaseRepository(DataContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Add(entity);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }

        public void HardDelete(T entity)
        {
            _context.Remove(entity);
        }

        public void SoftDelete(T entity)
        {
            entity.DateDeleted = DateTime.Now;
            _context.Update(entity);
        }

        public Task<T?> Get(Guid id, CancellationToken cancellationToken)
        {
            return _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public Task<List<T>> GetAll(CancellationToken cancellationToken)
        {
            return _context.Set<T>().ToListAsync(cancellationToken);
        }
    }
}
