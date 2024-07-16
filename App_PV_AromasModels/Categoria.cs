using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PV_Aromas.Models
{
    public class Categoria 
    {
        #region ============================= PROPIEDADES =============================

        public int id { get; set; }
        public string nombre { get; set; }
        public DateTime fecha_registro { get; set; }
        public bool estado { get; set; }
        public int? tipoconsulta { get; set; }
        public Auditoria? miAuditoria { get; set; }


        #endregion ============================= PROPIEDADES =============================
    }
}
