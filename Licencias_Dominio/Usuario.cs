using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenciasDominio
{
    [Table("Usuarios")]
    public class Usuario
    {
        #region Datos basicos
        
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        
        #endregion

        public List<Licencia> Licencias { get; set; }

        public Usuario() { }

        public Usuario(string nombre, string apellido, string password, string username, string email, string direccion)
        {
            
        }



    }
}
