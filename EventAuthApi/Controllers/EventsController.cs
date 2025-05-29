using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EventAuthApi.Data;

namespace EventAuthApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EventsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetEvents()
        {
            return Ok(_context.Events.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> CreateEvent(Event ev)
        {
            _context.Events.Add(ev);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetEvents), new { id = ev.Id }, ev);
        }
    }
}
