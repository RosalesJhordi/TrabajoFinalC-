using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoFinal.Base_Datos;
using Color = System.Drawing.Color;

namespace TrabajoFinal.FomsEstudiante
{
	public partial class ListTareas : Form
	{
		//conexion 
		ConexionBD conexion = new ConexionBD();

		private Color[] colores = { Color.SkyBlue, Color.White };
		private int indiceColor = 0;

		public ListTareas(string nvl)
		{
			InitializeComponent();

			Contenedor.AutoScrollMinSize = new System.Drawing.Size(0, 1000);

			string query = "SELECT * FROM Tareas WHERE Nivel = @nv";
			SQLiteConnection conex = conexion.AbrirConexion();
			using (SQLiteCommand comm = new SQLiteCommand(query, conex))
			{
				comm.Parameters.AddWithValue("@nv", nvl);

				using (SQLiteDataReader reader = comm.ExecuteReader())
				{
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							string descrip = reader["Descripcion"].ToString();
							string fecha = reader["Fecha"].ToString();

							// Crear un nuevo panel
							Panel nuevoPanel = new Panel();

							nuevoPanel.BackColor = colores[indiceColor];
							indiceColor = (indiceColor + 1) % colores.Length;
							nuevoPanel.Dock = DockStyle.Top; // Alineación en la parte superior
							nuevoPanel.Height = 100;
							nuevoPanel.Margin = new Padding(30, 50, 30, 30);

							Label label = new Label();
							label.Text = "Descripción: " + descrip;
							label.Dock = DockStyle.Top;

							Label label1 = new Label();
							label1.Text = "Fecha de entrega: " + fecha.ToString();
							label1.Dock = DockStyle.Top;

							nuevoPanel.Controls.Add(label1);
							nuevoPanel.Controls.Add(label);

							Contenedor.Controls.Add(nuevoPanel);
							Contenedor.PerformLayout();
						}
					}
				}

			}
		}
	}
}
