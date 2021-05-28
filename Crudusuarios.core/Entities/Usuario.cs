using System;
using System.Collections.Generic;

#nullable disable

namespace Crudusuarios.infraestructura.Data
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public int Edad { get; set; }
        public int Jerarquia { get; set; }

        public virtual Jerarquium JerarquiaNavigation { get; set; }
    }
}
