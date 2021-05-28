using Crudusuarios.infraestructura.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crudusuarios.infraestructura.Repositories
{
    public class UserRepositories
    {
        //ESTO ES DINAMYCS
        //public IEnumerable<Usuario> getUsers()
        //{
        //    var usuarios = Enumerable.Range(1, 10).Select(x => new Usuario
        //    {
        //        nombre = "Eluhuei",
        //        apellido = "Galeano",
        //        edad = 25

        //        //LA FK QUEDA AFUERA 
        //    });
        //    return usuarios;

        //}
        public async Task <Usuario> GetUserfromdatabase()
        {
            var contexto = new CRUDContext();
            var usuario = await contexto.Usuarios.FirstOrDefaultAsync();
            return usuario;
        }


    }
}
