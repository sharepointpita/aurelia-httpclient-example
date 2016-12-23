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
    public class TeamMemberController : Controller
    {
        // GET: api/Ticket
        [HttpGet]
        public IEnumerable<Model.TeamMember> Get()
        {
            return new List<Model.TeamMember>()
            {
                new Model.TeamMember { Name= "Peter Kraus", Title="Head Developer at Care Applications", ContactUrl="https://www.linkedin.com/in/peterkraus", ImageUrl="https://media.licdn.com/media/AAEAAQAAAAAAAAduAAAAJDUxOGM0OTQ1LThjMTYtNDc5Ny04NGI1LWMwMjg2ZWFiMTk2OA.jpg" },
                new Model.TeamMember { Name= "Joep Roberts", Title="Software Engineer at Care-Applications", ContactUrl="https://www.linkedin.com/in/joeproberts", ImageUrl="https://media.licdn.com/mpr/mpr/shrink_200_200/AAEAAQAAAAAAAAWSAAAAJDRjMTJhN2I2LWI3ZjAtNDc2Yy05MjBmLTU4NzRmZTRmMjBiZg.jpg" },
                new Model.TeamMember { Name= "Roger Beckers", Title="PHP Developer bij Care Applications", ContactUrl="https://www.linkedin.com/in/roger-beckers-4b010263", ImageUrl="https://media.licdn.com/media/AAEAAQAAAAAAAAN7AAAAJDM1YTNlODBjLTdkNDYtNDczOS05MjczLWViZDJiNmFiMWI3Mw.jpg" },
                new Model.TeamMember { Name= "Dennis Keulen", Title="Frontend Developer", ContactUrl="https://www.linkedin.com/in/dkeulen", ImageUrl="https://media.licdn.com/media/p/1/005/095/02c/183c274.jpg" },
                new Model.TeamMember { Name= "Roy Bos", Title="Developer at Care Applications", ContactUrl="https://www.linkedin.com/in/roy-bos-b54b6a16", ImageUrl="https://media.licdn.com/media/AAEAAQAAAAAAAANJAAAAJGM4NWQ4NTdiLTIzNGYtNDc1ZC05ZmQyLWE0YzM5YjZhN2FiYQ.jpg" }
            };
        }

        // GET: api/Ticket/5
        [HttpGet("{id}", Name = "GetTeamMember")]
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
