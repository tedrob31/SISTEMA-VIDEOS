using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class clsalqiler
    {
        public int codalquiler { get; set; }
        public int codcliente { get; set; }
        public int codempleado { get; set; }
        public DateTime fechaalquiler { get; set; }
        public string tipodocalqiler { get; set; }
        public string nrodocalquiler { get; set; }
        public string tipopagoalquiler { get; set; }
        public int igvalquiler { get; set; }
        public int subtotalalquiler { get; set; }
        public int totalalquiler { get; set; }
        public DateTime fechadevolucion { get; set; }
        public DateTime plazo { get; set; }
    }
}
