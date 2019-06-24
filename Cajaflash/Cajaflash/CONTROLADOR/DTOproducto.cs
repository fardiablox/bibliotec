using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cajaflash.CONFIGURACION;
using Cajaflash.MODELO;
using System.Data;


namespace Cajaflash.CONTROLADOR
{
    class DTOproducto
    {
        Ejecutar ejecutar = new Ejecutar();
        public List<Producto> listadoUsuario(string filtro)
        {
            List<Usuarios> listTemp = new List<Usuarios>();
            DataTable dttemp = ejecutar.Ejecutarselect("select * from Usuario join Tipos on Usuario.Tipo = Tipos.Id_tipo ");
            foreach (var fila in dttemp.AsEnumerable())
            {


                listTemp.Add(new Usuarios
                {
                    Id_usuario = Convert.ToInt32(fila[0]),
                    Nombre = fila[1].ToString(),
                    Clave = fila[2].ToString(),
                    tipo = new Tipo { Id_tipo = Convert.ToInt32(fila[3]), Nombre = fila[4].ToString() },

                });

            }
            return listTemp;
        }
    }
}
