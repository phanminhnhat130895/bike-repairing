using Application.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.RequestFeatures
{
    public sealed class CreateUserHandler : IRequestHandler<CreateRequestRequest, CreateRequestResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRequestRepository _requestRepository;

        public CreateUserHandler(IUnitOfWork unitOfWork, IRequestRepository requestRepository)
        {
            _unitOfWork = unitOfWork;
            _requestRepository = requestRepository;
        }

        public async Task<CreateRequestResponse> Handle(CreateRequestRequest request, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();

            var data = new Request(id);
            data.Name = request.Name;
            data.Email = request.Email;
            data.Description = request.Description;
            data.DateCreated = DateTime.Now;

            _requestRepository.Create(data);
            await _unitOfWork.Save(cancellationToken);

            return new CreateRequestResponse() 
            { 
                Id = id, 
                Email = data.Email, 
                Name = data.Name, 
                Description = data.Description 
            };
        }
    }
}
