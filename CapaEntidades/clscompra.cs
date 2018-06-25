using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class clscompra
    {
        public int codcompra { get; set; }
        public int codproveedor { get; set; }
        public DateTime fecha { get; set; }
        public string tipodoc { get; set; }
        public string nrodoc { get; set; }
        public string subtotal { get; set; }
        public int igv { get; set; }
        public int total { get; set; }
        public int tipopago { get; set; }
    }
}
