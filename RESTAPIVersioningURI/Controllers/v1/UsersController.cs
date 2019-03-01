using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTAPIVersioningURI.Models.v1;

namespace RESTAPIVersioningURI.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]

    public class UsersController : ControllerBase
    {
        // GET api/v1/users
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return new List<User>() {
                new User() { Id = 1, Name = "John Doe" },
                new User() { Id = 2, Name = "Abhi Jain"}
            };
        }


    }
}
