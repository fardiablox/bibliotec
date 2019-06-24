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
    class DTOusuario
    {
        Ejecutar ejecutar = new Ejecutar();
        public List<Usuarios> listadoUsuario(string filtro)
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
                    tipo = new Tipo { Id_tipo= Convert.ToInt32(fila[3]), Nombre=fila[4].ToString() },

                });

            }
            return listTemp;
        }

        public string agregarUsuario(Usuarios usa)
        {
            string ms = "";
            string sql = string.Format("insert into Usuario values ('{0}','{1}','{2}')",
                usa.Nombre,usa.Clave,usa.tipo.Id_tipo);
            int i = ejecutar.Ejecutarsql(sql);
            if (i > 0)
            {
                ms = "El usuario se inserto correctamente";
            }
            else
            {
                ms = "Error, no se pudo agregar";
            }
            return ms;
        }
        public string eliminarUsuario(string nombre)
        {
            string ms = "";
            string sql = string.Format("delete from Usuario where Nombre ='{0}'", nombre);
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
        public string editarUsuario(Usuarios USA)
        {
            string ms = "";
            string sql = string.Format("update Usuario set Nombre = '{0}', Clave = '{1}', Tipo ='{2}' where Nombre = '{3}'", USA.Nombre,USA.Clave,USA.tipo.Id_tipo,USA.Nombre);
            int i = ejecutar.Ejecutarsql(sql);
            if (i > 0)
            {
                ms = "Usuario  actualizado correctamente";
            }
            else
            {
                ms = "Error al actualizar Usuario";
            }
            return ms;
        }


    }
}
