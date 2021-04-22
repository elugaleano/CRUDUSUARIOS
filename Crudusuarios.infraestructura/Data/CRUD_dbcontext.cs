using Crudusuarios.core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crudusuarios.infraestructura.Data
{
    public class CRUD_dbcontext : DbContext
    {
        public virtual DbSet<Jerarquia> jerarquia{ get; set ;}
        public virtual DbSet<User> User { get; set; }

        public CRUD_dbcontext()
        {

        }

        public CRUD_dbcontext(DbContextOptions<CRUD_dbcontext> options)
        : base(options) { }

    }
} 
