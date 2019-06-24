using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Para trabajar con la base de datos SQL Server x
using System.Data.SqlClient; //ejecutar codigo SQL
using System.Data; // trabajar o procesar datos

namespace Cajaflash.CONFIGURACION
{
    class Conexion
    {
        private string urlConexion
           = @"Data Source = LAPTOP-JRLPPO96\FARDIABLOX; 
                Initial Catalog = Cajaflash; 
                Integrated Security = True";

        private SqlConnection conn; // permite conectar a la base de datos
        private SqlCommand cmd; // ejecutar Insert, update y delete y select
        private SqlDataAdapter result; // recuperar los datos de una consulta, tras la ejecución de un select

        //método conectar a base de datos
        public SqlConnection Conector()
        {
            try
            {
                conn = new SqlConnection(urlConexion);
                conn.Open();
                return conn;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void Desconectar()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }
            catch (Exception)
            {
            }
        }
    }
}
