using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PV_Aromas.Models
{
    public class ArqueoCaja
    {
        #region ============================= PROPIEDADES =============================

        public int id { get; set; }
        public Usuario miUsuario { get; set; }
        public Aperturacaja miApertura { get; set; }
        public decimal? total5 { get; set; }
        public decimal? total10 { get; set; }
        public decimal? total25 { get; set; }
        public decimal? total50 { get; set; }
        public decimal? total100 { get; set; }
        public decimal? total500 { get; set; }
        public decimal? total1000 { get; set; }
        public decimal? total2000 { get; set; }
        public decimal? total5000 { get; set; }
        public decimal? total10000 { get; set; }
        public decimal? total20000 { get; set; }
        public decimal? totalSinpe { get; set; }
        public decimal? totalTransferencias { get; set; }
        public decimal? totalCheque { get; set; }
        public decimal montoTotal { get; set; }
        public decimal? sobranteCaja { get; set; }
        public DateTime fecha_registro { get; set; }
        public bool estado { get; set; }
        public int? tipoconsulta { get; set; }
        public Auditoria? miAuditoria { get; set; }

        #endregion ============================= PROPIEDADES =============================
    }
}
