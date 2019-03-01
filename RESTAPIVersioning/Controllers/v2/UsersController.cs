using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTAPIVersioning.Models.v2;

namespace RESTAPIVersioning.Controllers.v2
{
    [Route("api/v2/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET api/v1/users
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return new List<User>() {
                new User() { Id = 1, FirstName = "John", LastName = "Doe" },
                new User() { Id = 2, FirstName = "Abhi", LastName = "Jain" }
            };
        }
    }
}
