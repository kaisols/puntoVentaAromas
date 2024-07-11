using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PV_Aromas.Models
{
    public class Auditoria
    {
        public int id { get; set; }
        public int accion { get; set; }
        public string movimiento { get; set; }
        public DateTime fecha { get; set; }
        public int id_usuario { get; set; }
    }



   public enum Acciones_Auditoria
    {
        Inicio_Sesion = 100,
        Guardado = 200,
        Actualizacion = 300,
        Eliminacion = 400,
        Cambio_Password = 500,
        Inicio_Erroneo = 600,
        Restablecer_Password = 700,
    }
}
