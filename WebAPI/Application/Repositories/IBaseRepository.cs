using Domain.Common;

namespace Application.Repositories
{
    public interface IBaseRepository<T> where T : Entity
    {
        void Create(T entity);
        void Update(T entity);
        void SoftDelete(T entity);
        void HardDelete(T entity);
        Task<T?> Get(Guid id, CancellationToken cancellationToken);
        Task<List<T>> GetAll(CancellationToken cancellationToken);
    }
}
