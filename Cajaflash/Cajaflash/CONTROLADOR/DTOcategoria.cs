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
    class DTOcategoria
    {
        Ejecutar ejecutar = new Ejecutar();
        public List<Categoria> listadoCategoria(string filtro)
        {
            List<Categoria> listTemp = new List<Categoria>();
            DataTable dttemp = ejecutar.Ejecutarselect("select * from Categoria");
            foreach (var fila in dttemp.AsEnumerable())
            {


                listTemp.Add(new Categoria
                {
                    Id_categoria = Convert.ToInt32(fila[0]),
                    Nombre = fila[1].ToString()

                });

            }
            return listTemp;
        }

        public string agregarCategoria(Categoria CAT)
        {
            string ms = "";
            string sql = string.Format("insert into Categoria values ('{0}','{1}')",CAT.Id_categoria,CAT.Nombre);
            int i = ejecutar.Ejecutarsql(sql);
            if (i > 0)
            {
                ms = "La Categoria se inserto correctamente";
            }
            else
            {
                ms = "Error, no se pudo agregar";
            }
            return ms;
        }
        public string eliminarCategoria(string nombre)
        {
            string ms = "";
            string sql = string.Format("delete from Categoria where Nombre ='{0}'", nombre);
            int i = ejecutar.Ejecutarsql(sql);
            if (i > 0)
            {
                ms = "El usuario se elimino correctamente";
            }
            else
            {
                ms = "Error, no se pudo eliminar";
            }
            return ms;
        }
        public string editarCategoria(Categoria cat)
        {
            string ms = "";
            string sql = string.Format("update Categoria set Nombre = '{0}' where Nombre = '{0}'", cat.Nombre);
            int i = ejecutar.Ejecutarsql(sql);
            if (i > 0)
            {
                ms = "Categoria  actualizado correctamente";
            }
            else
            {
                ms = "Error al actualizar Categoria";
            }
            return ms;
        }


    }
}
