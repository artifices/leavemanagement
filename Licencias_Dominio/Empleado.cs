using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenciasDominio
{
    [Table("Empleados")]
    public class Empleado : Usuario
    {

        public Usuario Superior { get; set; }
        public int diasDeLicenciaXAnio { get; set; }

        //falta contructor
    }
}
