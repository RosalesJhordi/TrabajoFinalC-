using System;
using System.Data;
using System.Data.SQLite;

namespace TrabajoFinal.Base_Datos
{
	internal class ConexionBD
	{
		private SQLiteConnection Conn = new SQLiteConnection("Data Source=C:\\RosalesC#\\TrabajoFinal\\Base_Datos\\BD_IE_CM.db;Version=3;");

		public SQLiteConnection AbrirConexion()
		{
			if (Conn.State == ConnectionState.Closed)
				Conn.Open();
			return Conn;
		}

		public SQLiteConnection CerrarConexion()
		{
			if (Conn.State == ConnectionState.Open)
				Conn.Close();
			return Conn;
		}
	}
}