using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTAPIVersioningQueryString.Models.v2;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace RESTAPIVersioningQueryString.Controllers.v2
{
    [ApiController]
    [ApiVersion( "2.0" )]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        // GET api/users?api-version=2.0
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
