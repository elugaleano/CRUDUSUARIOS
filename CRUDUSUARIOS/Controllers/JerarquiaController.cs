using Crudusuarios.infraestructura.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDUSUARIOS.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class JerarquiaController : ControllerBase
    {
        [HttpGet("getjerarquia")]

        public async Task<IActionResult> Getjerarquia()
        {
            var repositorioJerarquia = new JerarquiaRepositories();
            var response = await repositorioJerarquia.GetJerarquiafromdatabase();

            return Ok(response);

        }

    }
}
