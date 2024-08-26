using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App_PV_Aromas.Models
{
    public class Factura_Detalle
    {
        #region ============================= PROPIEDADES =============================

        public int id { get; set; }
        public Factura miFactura { get; set; }
        public Productos miProducto { get; set; }
        public decimal cantidad { get; set; }
        public decimal subtotal { get; set; }
        public decimal montoTotal { get; set; }
        public decimal ivaTotal { get; set; }
        public decimal descuento { get; set; }
        public DateTime fecha_registro { get; set; }
        public bool estado { get; set; }
        public int? tipoconsulta { get; set; }
        public Auditoria? miAuditoria { get; set; }
        
        [JsonIgnore]
        public int Porcentaje_Descuento { get; set; }

        #endregion ============================= PROPIEDADES =============================

    }
}
