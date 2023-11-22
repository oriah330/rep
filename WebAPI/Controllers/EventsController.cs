using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {

        private static  List<Event> events= new List<Event> { new Event{Id=1, Title="default" } };

        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return events;
        }

       

        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Event eve)
        {
            events.Add(new Event{Id=2, Title=eve.Title});
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Event evev)
        {
            var eve1 = events.Find(e => e.Id == id);
            eve1.Title = evev.Title;
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var eve = events.Find(e => e.Id == id);
            events.Remove(eve);
        }
    }
}
