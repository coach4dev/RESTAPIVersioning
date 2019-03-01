using Microsoft.AspNetCore.Mvc;
using RESTAPIVersioningURI.Models.v2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPIVersioningURI.Controllers.v2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]

    public class UsersController : ControllerBase
    {  
        // GET api/v2/users

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
