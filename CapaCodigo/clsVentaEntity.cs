using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaCodigo
{
    class clsVentaEntity
    {
        public String idVenta { get; set; }
        public String cliente { get; set; }
        public String idempleado { get; set; }
        public DateTime fecha { get; set; }
        public String tipodoc { get; set; }
        public String NroDoc { get; set; }
        public String TipoPago { get; set; }
        public double subtotal { get; set; }
        public double igv { get; set; }
        public double total { get; set; }
    }
}
