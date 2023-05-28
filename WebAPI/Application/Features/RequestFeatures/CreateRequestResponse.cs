namespace Application.Features.RequestFeatures
{
    public sealed record CreateRequestResponse
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
