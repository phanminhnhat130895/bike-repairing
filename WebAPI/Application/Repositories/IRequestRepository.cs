using Domain.Entities;

namespace Application.Repositories
{
    public interface IRequestRepository : IBaseRepository<Request>
    {
        Task<Request?> CreateRequest(Request request, CancellationToken cancellationToken);
    }
}
