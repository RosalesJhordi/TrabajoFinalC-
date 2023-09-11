using System;
using System.Data;
using System.Data.SqlClient;

namespace TrabajoFinal.Base_Datos
{
    internal class ConexionBD
    {
        private string servidor = "DESKTOP-2QR1BR7\\SQLEXPRESS";
        private string bd = "BD_IE_CM";
        private string usuario = "DESKTOP-2QR1BR7\\Equipo";
        private SqlConnection conn;

        public ConexionBD() 
        {
            string conect = $"Data Source={servidor};Initial Catalog={bd};Integrated Security=True;User ID={usuario}";
            conn = new SqlConnection(conect) ;
        }

        public SqlConnection ObtenerConexion()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                return conn;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Fallo en la conexión: " + ex.ToString());
                return null;
            }
        }
    }
}