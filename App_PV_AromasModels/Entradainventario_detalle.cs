using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PV_Aromas.Models
{
    public class Entradainventario_detalle
    {
        public int id { get; set; }
        public Entradainventario miEntrada { get; set; }
        public Productos miProducto { get; set; }
        public decimal cantidad { get; set; }
        public decimal totalCompra { get; set; }
        public DateTime fecha_registro { get; set; }
        public bool estado { get; set; }
        public int? tipoconsulta { get; set; }
        public Auditoria? miAuditoria { get; set; }
    }
}
