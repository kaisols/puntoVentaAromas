using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PV_Aromas.Models
{
    public class Cierrecaja
    {
        #region ============================= PROPIEDADES =============================


        public int id { get; set; }
        public Usuario miUsuario { get; set; }
        public decimal montoCaja { get; set; }
        public decimal totalFacturas { get; set; }
        public decimal totalArqueos { get; set; }
        public decimal diferencias { get; set; }
        public DateTime fecha_registro { get; set; }
        public bool estado { get; set; }
        public int? tipoconsulta { get; set; }
        public Auditoria? miAuditoria { get; set; }
        public Aperturacaja? miApertura { get; set; }

        #endregion ============================= PROPIEDADES =============================
    }
}
