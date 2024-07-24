using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PV_Aromas.Models
{
    public class Productos  
    {
        #region ============================= PROPIEDADES =============================

        public int id { get; set; }
        public Categoria? miCategoria { get; set; }
        public Impuesto? miImpuesto { get; set; }
        public Unidadmedida? miUnidadMedida { get; set; }
        public string? nombre { get; set; }
        public string? codBarras { get; set; }
        public decimal stock { get; set; }
        public bool reduceInventario { get; set; }
        public decimal precioCompra { get; set; }
        public decimal precioVenta { get; set; }
        public decimal utilidad { get; set; }
        public DateTime fecha_registro { get; set; }
        public bool estado { get; set; }
        public int? tipoconsulta { get; set; }
        public Auditoria? miAuditoria { get; set; }
        public List<Proveedor>? Proveedores { get; set; }

        #endregion ============================= PROPIEDADES =============================
    }
}
