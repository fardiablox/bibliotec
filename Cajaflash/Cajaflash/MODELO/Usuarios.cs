using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajaflash.MODELO
{
    class Usuarios
    {
        public int Id_usuario { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public Tipo tipo { get; set; }
        public Usuarios()
        {

        }
    }
}
