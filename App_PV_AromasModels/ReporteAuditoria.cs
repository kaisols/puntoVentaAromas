using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PV_Aromas.Models
{
    public class ReporteAuditoria
    {
        public int id { get; set; }
        public string tipoMovimiento { get; set; }
        public DateTime fecha { get; set; }
        public string Usuario { get; set; }
        public string Accion { get; set; }
    }
}
