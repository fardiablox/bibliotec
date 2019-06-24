using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Cajaflash.CONFIGURACION
{
    class Ejecutar
    {
        Conexion conn = new Conexion();
        private SqlCommand cmd;
        private SqlDataAdapter result;


        public int Ejecutarsql(string sql)
        {
            try
            {
                cmd = new SqlCommand(sql, conn.Conector());
                int num_filas_afectadas = cmd.ExecuteNonQuery();
                conn.Desconectar();
                return num_filas_afectadas;
                //numero de filas afectadas
                //1: si se ejecuto bien la instruccion sql
                //(insert, delete, update)
                //-1: error al ejecutar la instruccion sql
                //si existe error de conexion a bd,
                //lanzara una exepcion, y retornara 0
            }
            catch (Exception)
            {
                return 0;

            }
        }

        public DataTable Ejecutarselect(string sql)
        {
            DataTable dt = new DataTable();
            try
            {

                result = new SqlDataAdapter(sql, conn.Conector());
                result.Fill(dt);
                conn.Desconectar();
                return dt;


            }
            catch (Exception)
            {
                return dt;

            }
        }
    }
}
