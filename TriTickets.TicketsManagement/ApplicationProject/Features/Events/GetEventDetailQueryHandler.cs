using ApplicationProject.Contracts.Persistence;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationProject.Features.Events
{
    public class GetEventDetailQueryHandler : IRequestHandler<GetEventDetailQuery, EventDetailVm>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<Artist> _artistRepository;
        private readonly IMapper _mapper;

        public GetEventDetailQueryHandler(
            IMapper mapper,
            IAsyncRepository<Event> eventRepository,
            IAsyncRepository<Category> categoryRepository,
            IAsyncRepository<Artist> artistRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
            _categoryRepository = categoryRepository;
            _artistRepository = artistRepository;
        }

        public async Task<EventDetailVm> Handle(GetEventDetailQuery request, CancellationToken cancellationToken)
        {
            var @event = await _eventRepository.GetByIdAsync(request.Id);
            var eventDetailDto = _mapper.Map<EventDetailVm>(@event);
            var category = await _categoryRepository.GetByIdAsync(@event.CategoryId);
            var artist = await _artistRepository.GetByIdAsync(@event.ArtistId);
            eventDetailDto.Category = _mapper.Map<CategoryDto>(category);
            eventDetailDto.Artist = _mapper.Map<ArtistDto>(artist);

            return eventDetailDto;
        }
    }
}
