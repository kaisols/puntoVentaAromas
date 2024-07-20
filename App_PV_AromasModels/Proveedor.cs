using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PV_Aromas.Models
{
    public class Proveedor
    {

        public int id { get; set; }
        public string? nombre { get; set; }
        public string? cedula { get; set; }
        public string? telefono { get; set; }
        public string? correo { get; set; }
        public DateTime fecha_registro { get; set; }
        public bool estado { get; set; }
        public int? tipoconsulta { get; set; }
        public Auditoria? miAuditoria { get; set; }
    }
}
