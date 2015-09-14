using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenciasDominio
{
    [Table("Usuario_Roles")]
    public class Usuario_Rol
    {

        public int Usuario_RolId { get; set; }
        public int UsuarioId { get; set; }
        public int RolId { get; set; }

    }
}
