using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PV_Aromas.Models
{
    public class Factura
    {
        #region ============================= PROPIEDADES =============================

        public int id { get; set; }
        public Usuario? miUsuario { get; set; }
        public Cliente? miCliente { get; set; }
        public Tipofactura? miTipoFactura { get; set; }
        public decimal subtotal { get; set; }
        public decimal montoTotal { get; set; }
        public decimal ivaTotal { get; set; }
        public decimal descuento { get; set; }
        public DateTime fecha_registro { get; set; }
        public bool estado { get; set; }
        public int? tipoconsulta { get; set; }
        public Auditoria? miAuditoria { get; set; }
        public List<Factura_Detalle>? Detalles { get; set; }

        #endregion ============================= PROPIEDADES =============================
    }
}
