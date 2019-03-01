using Microsoft.AspNetCore.Mvc;
using RESTAPIVersioningHeader.Models.v2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPIVersioningHeader.Controllers.v2
{

    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/[controller]")]

    //In the request header add api-version = 2.0

    public class UsersController : ControllerBase
    {

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
