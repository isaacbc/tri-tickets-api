using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationProject.Features.Events
{
    public class EventDetailVm
    {
        public Guid EventId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int Price { get; set; }
        public ArtistDto Artist {  get; set; }
        public DateTime Date { get; set; }
        public string? ImageUrl { get; set; }
        public CategoryDto Category { get; set; } = default!;
    }
}
