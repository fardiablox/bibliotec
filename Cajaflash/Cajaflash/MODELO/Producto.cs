using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajaflash.MODELO
{
    class Producto
    {
        public int Id_producto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public int Stock { get; set; }
        public int Precio { get; set; }
        public string Detalle { get; set; }
        public Categoria Categoria { get; set; }

        public Producto()
        {

        }
    }

}
