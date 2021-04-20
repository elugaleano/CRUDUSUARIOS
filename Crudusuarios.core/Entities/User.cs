using System;
using System.Collections.Generic;
using System.Text;

namespace Crudusuarios.core.Entities
{
    public class User
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public int edad { get; set; }
        public string jerarquia { get; set; }

        public virtual Jerarquia jerarquianavegacion { get; set; }
    }
}
