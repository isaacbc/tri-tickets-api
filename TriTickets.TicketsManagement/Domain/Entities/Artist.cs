
using System;
using Domain.Common;


namespace Domain.Entities
{
    public class Artist : AuditableEntity
    {
        public Guid ArtistId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public ICollection<Event> Events { get; set; } = new List<Event>();

    }
}
