using Application.Repositories;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class RequestRepository : BaseRepository<Request>, IRequestRepository
    {
        public RequestRepository(DataContext context) : base(context)
        {
        }

        public async Task<Request?> CreateRequest(Request request, CancellationToken cancellationToken)
        {
            await _context.Requests.AddAsync(request);

            return request;
        }
    }
}
