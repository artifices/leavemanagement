using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenciasDominio
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Licencia> Licencias { get; set; }
        public DbSet<Usuario_Rol> Usuario_Roles { get; set; }
        public DbSet<Rol> Roles { get; set; }

    }
}
