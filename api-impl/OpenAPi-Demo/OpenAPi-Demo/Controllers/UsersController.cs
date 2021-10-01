using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OpenAPi_Demo.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            string[] tech = new string[] { "C#", "SQL", "Azure" };
            List<User> User = new List<User> 
            {
                new User
                {
                    id = 1,
                    name = "Cleiton",
                    Surname = "MOraes",
                    Position = "Software Developer",
                    Technologies = tech,
                    Department = "I.T",
                    _links = new _Links
                    {
                        Self = $"api/user/1"
                    }
                },
                new User
                {
                    id = 2,
                    name = "Pedro",
                    Surname = "MOraes",
                    Position = "Boss",
                    Technologies = tech,
                    _links = new _Links
                    {
                        Self = $"api/user/2"
                    }
                },
                new User
                {
                    id = 3,
                    name = "Janna",
                    Surname = "MOraes",
                    Position = "Patroa",
                    Technologies = tech,
                    _links = new _Links
                    {
                        Self = $"api/user/3"
                    }
                }
            };

            return User;
        }

        // GET api/<UsersController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
