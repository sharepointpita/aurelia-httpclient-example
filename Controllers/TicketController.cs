using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace skeleton.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class TicketController : Controller
    {
        // GET: api/Ticket
        [HttpGet]
        public IEnumerable<Model.Ticket> Get()
        {
            return new List<Model.Ticket>()
            {
                new Model.Ticket { Id= 1, Description="Ticket nummero uno", Owner="Sjaak Braak", Status ="In behandeling" },
                new Model.Ticket { Id= 2, Description="Ticket nummero deux", Owner="Piet Jansen", Status ="Wacht op klant" },
                new Model.Ticket { Id= 3, Description="Ticket nummero trex", Owner="Karel de grote", Status ="Wacht op klant" },
                new Model.Ticket { Id= 4, Description="Ticket nummero quatro", Owner="Truus knuus", Status ="Ingediend" },
                new Model.Ticket { Id= 5, Description="Ticket nummero cinq", Owner="Puk Flut", Status ="In behandeling" },
                new Model.Ticket { Id= 6, Description="Ticket nummero sept", Owner="Bram Pleh", Status ="In behandeling" }
            };
        }

        // GET: api/Ticket/5
        [HttpGet("{id}", Name = "GetTicket")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Ticket
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Ticket/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
