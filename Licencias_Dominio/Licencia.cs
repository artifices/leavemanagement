using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenciasDominio
{
    [Table("Licencias")]
    public class Licencia
    {

        public int LicenciaId { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public DateTime UltimaModificacion { get; set; }
        public string Estado { get; set; }
        public string Comentario { get; set; }

        //falta CO NT U C OR

    }
}
