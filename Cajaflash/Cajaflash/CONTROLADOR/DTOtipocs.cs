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
    class DTOtipocs
    {
        Ejecutar ejecutar = new Ejecutar();
        public List<Tipo> listadoTipo(string filtro)
        {
            List<Tipo> listTemp = new List<Tipo>();
            DataTable dttemp = ejecutar.Ejecutarselect("select * from Tipos ");
            foreach (var fila in dttemp.AsEnumerable())
            {


                listTemp.Add(new Tipo
                {
                    Id_tipo = Convert.ToInt32(fila[0]),
                    Nombre = fila[1].ToString()

                });

            }
            return listTemp;
        }

    }
}
