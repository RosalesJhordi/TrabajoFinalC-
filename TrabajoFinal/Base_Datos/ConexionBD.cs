using System;
using System.Data;
using System.Data.SQLite;

namespace TrabajoFinal.Base_Datos
{
	internal class ConexionBD
	{
		private SQLiteConnection Conn = new SQLiteConnection("Data Source=C:\\Users\\Equipo\\Desktop\\TrabajoFinalC-\\TrabajoFinalC-\\TrabajoFinal\\Base_Datos\\BD_CM.db;Version=3;");

		// Método para abrir la conexión a la base de datos
		public SQLiteConnection AbrirConexion()
		{
			if (Conn.State == ConnectionState.Closed)
				Conn.Open();
			return Conn;
		}
		// Método para cerrar la conexión a la base de datos
		public SQLiteConnection CerrarConexion()
		{
			if (Conn.State == ConnectionState.Open)
				Conn.Close();
			return Conn;
		}
	}
}