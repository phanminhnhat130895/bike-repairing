using MediatR;

namespace Application.Features.RequestFeatures
{
    public sealed record CreateRequestRequest : IRequest<CreateRequestResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    }
}
