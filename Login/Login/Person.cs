using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Login
{
	public class Estudiantes
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Nombres { get; set; }
		public bool Apellidos { get; set; }
	}
}
