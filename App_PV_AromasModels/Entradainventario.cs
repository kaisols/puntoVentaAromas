using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PV_Aromas.Models
{
    public class Entradainventario
    {
        #region ============================= PROPIEDADES =============================

        public int id { get; set; }
        public Proveedor miProveedor { get; set; }
        public Usuario miUsuario { get; set; }
        public DateTime fecha_registro { get; set; }
        public decimal totalCompra { get; set; }
        public bool estado { get; set; }
        public int? tipoconsulta { get; set; }
        public Auditoria? miAuditoria { get; set; }
        public List<Entradainventario_detalle> Detalles { get; set; }


        #endregion ============================= PROPIEDADES =============================
    }
}
