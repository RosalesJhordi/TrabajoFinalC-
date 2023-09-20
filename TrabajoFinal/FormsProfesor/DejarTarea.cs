using NPOI.SS.Formula.Functions;
using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using Color = System.Drawing.Color;
using Rand = Org.BouncyCastle.Asn1.Cmp.Challenge.Rand;
using TrabajoFinal.Base_Datos;
using System.Data.SQLite;
using FirebaseAdmin.Messaging;
using MathNet.Numerics.Providers.LinearAlgebra;
using static NPOI.HSSF.Util.HSSFColor;

namespace TrabajoFinal.FormsProfesor
{
	public partial class DejarTarea : Form
	{
		private int panelnum = 0;
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
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							string descripcion = reader["Descripcion"].ToString();
							string fechae = reader["Fecha_Entrega"].ToString();
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


			string query = "INSERT INTO Tareas (Descripcion,Fecha_Entrega,Nivel) VALUES (@desc , @entrega ,@nvl);";
			SQLiteConnection conex = conexion.AbrirConexion();
			using (SQLiteCommand comm = new SQLiteCommand(query, conex))
			{
				comm.Parameters.AddWithValue("@desc", descrip);
				comm.Parameters.AddWithValue("@entrega", fech);
				comm.Parameters.AddWithValue("@nvl", nvl);

				int filasAfect = comm.ExecuteNonQuery();
				if (filasAfect > 0)
				{
					MessageBox.Show("Tarea Añadida");
				}
				else
				{
					MessageBox.Show("Tarea no añadida");
				}
			}
		}
	}
}
