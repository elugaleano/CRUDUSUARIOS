using System;
using System.Collections.Generic;

#nullable disable

namespace Crudusuarios.infraestructura.Data
{
    public partial class Jerarquium
    {
        public Jerarquium()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
