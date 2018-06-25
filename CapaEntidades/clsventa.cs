using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class clsventa
    {
        public int codventa { get; set; }
        public int codcliente { get; set; }
        public int codempleado { get; set; }
        public DateTime fechaventa { get; set; }
        public string tipodocventa { get; set; }
        public string nrodocventa { get; set; }
        public string tipopagoventa { get; set; }
        public double subtotal { get; set; }
        public double igv { get; set; }
        public double total { get; set; }
    }
}
