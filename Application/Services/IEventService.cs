using Application.Models;

namespace Application.Services;

public interface IEventService
{
    Task<EventResult> CreateEventAsync(CreateEventRequest request);
    Task<EventResult<IEnumerable<Event>>> GetEventsAsync();
    Task<EventResult<Event?>> GetEventAsync(string eventId);
}
