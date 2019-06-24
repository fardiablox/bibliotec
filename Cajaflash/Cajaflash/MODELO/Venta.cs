using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajaflash.MODELO
{
    class Venta
    {
        public int Id_venta { get; set; }
        public Usuarios Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public int Total { get; set; }
        public Venta()
        {

        }

    }
}
