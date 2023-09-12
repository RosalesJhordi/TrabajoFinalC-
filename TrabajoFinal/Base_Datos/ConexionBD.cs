using System;
using System.Data;
using System.Data.SqlClient;

namespace TrabajoFinal.Base_Datos
{
    internal class ConexionBD
    {
        private SqlConnection Conn = new SqlConnection("Server= DESKTOP-2QR1BR7\\SQLEXPRESS;DataBase= BD_IE_CM;Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            return Conn;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conn.State == ConnectionState.Open)
                Conn.Close();
            return Conn;
        }
    }
}