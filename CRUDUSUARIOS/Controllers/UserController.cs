using Crudusuarios.infraestructura.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDUSUARIOS.Controllers
{
    [ApiController]
    [Route("[controller]")]


    public class UserController : ControllerBase
    {
        [HttpGet("getusers")]
        public async Task<IActionResult> getusers()
        {

            var repositorioUser = new UserRepositories();
            var response = repositorioUser.GetUserfromdatabase();

            return Ok(response);

        }

    }

}
