using Microsoft.EntityFrameworkCore;
using RTComm.Data;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace RTComm.Services
{
    public interface IEventService
    {
        Task<List<Event>> Get();
        Task<Event> Get(int id);
        Task<Event> Add(Event events);

        Task<Event> Update(Event events);

        Task<Event> Delete(Event events);
    }
    public class EventService: IEventService
    {
        private readonly ApplicationDbContext _context;

        public EventService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Event>> Get()
        {
            return await _context.Event.ToListAsync();
        }
        public async Task<Event> Get(int id)
        {
            var events = await _context.Event.FindAsync(id);
            return events;
        }
        public async Task<Event> Add(Event events)
        {
            _context.Event.Add(events);
            await _context.SaveChangesAsync();
            return events;
        }

        public async Task<Event> Update(Event events)
        {
            _context.Event.Update(events);
            await _context.SaveChangesAsync();
            return events;
        }
        public async Task<Event> Delete(Event events)
        {
            _context.Event.Remove(events);
            await _context.SaveChangesAsync();
            return events;
        }
    }
}
