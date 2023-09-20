using System;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using TrabajoFinal.Base_Datos;
using System.Data.SQLite;

namespace TrabajoFinal.FormsProfesor
{
	public partial class DejarTarea : Form
	{
		private Color[] colores = { Color.SkyBlue, Color.White };
		private int indiceColor = 0;

		//conexion 
		ConexionBD conexion = new ConexionBD();
		public string nvl;

		public DejarTarea(string nivel)
		{
			InitializeComponent();

			fecha.Format = DateTimePickerFormat.Custom;
			fecha.CustomFormat = "yyyy-MM-dd";

			acargo.Text = "Estas a cargo de "+ nivel.ToString();
			Contenedor.AutoScrollMinSize = new System.Drawing.Size(0, 1000);
			nvl = nivel;

			string cons = "SELECT * FROM Tareas WHERE Nivel = @nv";
			SQLiteConnection conex = conexion.AbrirConexion();
			using (SQLiteCommand cmd = new SQLiteCommand(cons, conex))
			{
				cmd.Parameters.AddWithValue("@nv", nvl);

				using (SQLiteDataReader reader = cmd.ExecuteReader())
				{
					//verificar si devuelve un valor o no
					if (reader.HasRows)
					{
						//leer los datos 
						while (reader.Read())
						{
							string descripcion = reader["Descripcion"].ToString();
							string fechae = reader["Fecha"].ToString();
							// Crear un nuevo panel
							Panel nuevoPanel = new Panel();

							nuevoPanel.BackColor = colores[indiceColor];
							indiceColor = (indiceColor + 1) % colores.Length;
							nuevoPanel.Dock = DockStyle.Top; // Alineación en la parte superior
							nuevoPanel.Height = 100;
							nuevoPanel.Margin = new Padding(30, 50, 30, 30);

							Label label = new Label();
							label.Text = "Descripción: " + descripcion;
							label.Dock = DockStyle.Top;

							Label label1 = new Label();
							label1.Text = "Fecha de entrega: " + fechae.ToString();
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

		private void añadir_Click(object sender, EventArgs e)
		{
			string descrip = descripcion.Text;
			DateTime fechah = fecha.Value;
			DateTime fech = fechah.Date;

			string query = "INSERT INTO Tareas (Descripcion,Fecha,Nivel) VALUES (@desc , @entrega ,@nvl);";
			SQLiteConnection conex = conexion.AbrirConexion();
			using (SQLiteCommand comm = new SQLiteCommand(query, conex))
			{
				comm.Parameters.AddWithValue("@desc", descrip);
				comm.Parameters.AddWithValue("@entrega", fech);
				comm.Parameters.AddWithValue("@nvl", nvl);

				int filasAfect = comm.ExecuteNonQuery();
				//verificar si hay filas afectadas - insertadas
				if (filasAfect > 0)
				{
					MessageBox.Show("Tarea Añadida");

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
					label1.Text = "Fecha de entrega: " + fech.ToString();
					label1.Dock = DockStyle.Top;

					nuevoPanel.Controls.Add(label1);
					nuevoPanel.Controls.Add(label);

					Contenedor.Controls.Add(nuevoPanel);
					Contenedor.PerformLayout();
					this.Refresh();
				}
				else
				{
					MessageBox.Show("Tarea no añadida");
				}
			}
		}
	}
}
