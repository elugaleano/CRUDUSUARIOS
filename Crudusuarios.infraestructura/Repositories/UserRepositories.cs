using Crudusuarios.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crudusuarios.infraestructura.Repositories
{
    public class UserRepositories
    {
        //ESTO ES DINAMYCS
        public IEnumerable<User> getUsers() 
        {
            var usuarios = Enumerable.Range(1, 10).Select(x => new User
            {
                nombre = "Eluhuei",
                apellido = "Galeano",
                edad = 25

                //LA FK QUEDA AFUERA 
            });
          return usuarios;
            
        }
        
    }
}
