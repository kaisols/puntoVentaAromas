using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PV_Aromas.Models
{
    public class Aperturacaja
    {
        public int id { get; set; }
        public Usuario miUsuario { get; set; }
        public Cierrecaja? miCierreCaja { get; set; }
        public Caja? miCaja { get; set; }
        public decimal montoCaja { get; set; }
        public DateTime? fecha_registro { get; set; }
        public bool? estado { get; set; }
        public int? tipoconsulta { get; set; }
        public Auditoria? miAuditoria { get; set; }
    }
}
