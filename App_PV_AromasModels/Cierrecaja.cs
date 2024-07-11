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
        public Usuario? miUsuario { get; set; }
        public decimal? montoCaja { get; set; }
        public DateTime? fecha_registro { get; set; }
        public bool? estado { get; set; }

        #endregion ============================= PROPIEDADES =============================
    }
}
