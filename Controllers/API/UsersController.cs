using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.RepInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BugSmasher.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork worker;

        public UsersController(IUnitOfWork worker)
        {
            this.worker = worker;
        }

        // GET: api/Users
        [HttpGet]
        public IEnumerable<string> GetUser()
        {
            //var user = worker.Users.GetUserById(1);
            //var userDTO = new List<UserDTO>();
            //foreach (var u in user)
            //{
            //    userDTO.Add(new UserDTO
            //    {
            //        Id = u.Id,
            //        Username = u.Username,
            //        FirstName = u.FirstName,
            //        LastName = u.LastName,
            //        UserType = u.UserType.Name,

            //    });
            //}
            //return (userDTO);
            return new string[] { "value1", "value2" };
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
