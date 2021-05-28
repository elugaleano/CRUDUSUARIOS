using Crudusuarios.infraestructura.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crudusuarios.infraestructura.Repositories
{
    public class JerarquiaRepositories
    {
        public IEnumerable<Jerarquium> getJerarquia()
        {
            var jerarquias = Enumerable.Range(1, 10).Select(x => new Jerarquium
            {
                Descripcion = "jefe"

                //LA FK QUEDA AFUERA 
            });
            return jerarquias;

        }
        public async Task <Jerarquium> GetJerarquiafromdatabase()
        {
            var contexto = new CRUDContext();
            var jerarquia = await contexto.Jerarquia.FirstOrDefaultAsync();
            return jerarquia;
        }
    }
}
