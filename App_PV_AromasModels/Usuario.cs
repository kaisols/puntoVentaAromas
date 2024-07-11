using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App_PV_Aromas.Models
{
    public class Usuario
    {
        #region ============================= PROPIEDADES =============================

        public int id { get; set; }
        public Rol miRol { get; set; }
        public string nombre { get; set; }
        [JsonIgnore]
        public string Token { get; set; }
        public string apellidos { get; set; }
        public string cedula { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public DateTime? fecha_registro { get; set; }
        public bool estado { get; set; }
        public int? tipoconsulta { get; set; }
        public Auditoria? miAuditoria { get; set; }
        public Aperturacaja? miApertura { get; set; }
        #endregion ============================= PROPIEDADES =============================


        public override string ToString()
        {
            return nombre + " " + apellidos;
        }
    }
}
