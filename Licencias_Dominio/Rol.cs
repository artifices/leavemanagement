﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenciasDominio
{
    [Table("Roles")]
    public class Rol {

        public int RolId { get; set; }
        public string Nombre { get; set; }

    }

}
