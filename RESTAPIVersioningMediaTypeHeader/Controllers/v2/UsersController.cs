using Microsoft.AspNetCore.Mvc;
using RESTAPIVersioningMediaTypeHeader.Models.v2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPIVersioningMediaTypeHeader.Controllers.v2
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/[controller]")]

    public class UsersController : ControllerBase
    {
        //In the request header add Content-Type: application/json;api-version=2.0
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
