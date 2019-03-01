using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTAPIVersioningQueryString.Models.v1;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace RESTAPIVersioningQueryString.Controllers.v1
{
    [ApiController]
    [ApiVersion( "1.0" )]
    [Route("api/[controller]")]
    
    public class UsersController : ControllerBase
    {
        // GET api/users?api-version=1.0
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
