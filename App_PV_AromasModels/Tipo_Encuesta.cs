using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PV_Aromas.Models
{
    public class Tipo_Encuesta
    {
        #region ============================= PROPIEDADES =============================

        public int id { get; set; }
        public string nombre { get; set; }
        public string icono { get; set; }
        public DateTime fecha_registro { get; set; }
        public bool estado { get; set; }
        public bool permiteCambiarIcono { get; set; }
        public int tipoConsulta { get; set; }

        #endregion ============================= PROPIEDADES =============================


    }
}
