using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTAPIVersioningHeader.Models.v1;

namespace RESTAPIVersioningHeader.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    //In the request header add api-version = 1.0

    public class UsersController : ControllerBase
    {
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