using Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Request : Entity
    {
        public Request(Guid id) : base(id)
        {
        }

        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        public string Description { get; set; }
    }
}
