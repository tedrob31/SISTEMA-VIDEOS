using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class clsvideos
    {
        public int codvideo { get; set; }
        public int codgenero { get; set; }
        public int coddirector { get; set; }
        public int codactor { get; set; }
        public string titulo { get; set; }
        public string estreno { get; set; }
        public string descripcion { get; set; }
        public string clasificacion { get; set; }
        public string idioma { get; set; }
        public string resolucion { get; set; }
        public decimal precio { get; set; }
        public decimal preciocompra { get; set; }
        public decimal precioventa { get; set; }
        public decimal precioalquiler { get; set; }
    }
}
