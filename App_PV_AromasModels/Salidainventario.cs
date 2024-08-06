using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PV_Aromas.Models
{
    public class Salidainventario  
    {
        #region ============================= PROPIEDADES =============================

        public int id { get; set; }
        public Motivo_salida? miMotivo { get; set; }
        public Usuario? miUsuario { get; set; }
        public DateTime fecha_registro { get; set; }
        public bool estado { get; set; }
        public int? tipoconsulta { get; set; }
        public Auditoria? miAuditoria { get; set; }
        public List<Salidainventario_detalle>? Detalles { get; set; }

        #endregion ============================= PROPIEDADES =============================
    }
}
