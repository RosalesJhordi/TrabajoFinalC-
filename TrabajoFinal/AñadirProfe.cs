using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoFinal.Base_Datos;

namespace TrabajoFinal
{
	public partial class AñadirProfe : Form
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();

		//conexion 
		ConexionBD conexion = new ConexionBD();

		public AñadirProfe()
		{
			InitializeComponent();
			Niveles.Height = 40;
			Niveles.Items.Add("Seleciona Nivel (No seleccionable)");
			Niveles.Items.Add("Inicial");
			Niveles.Items.Add("Primaria");
			Niveles.Items.Add("Secundaria");

			Niveles.SelectedIndex = 0;
		}
		private void Selecionar_perfil_Click(object sender, EventArgs e)
		{
			using (openFileDialog)
			{
				openFileDialog.Title = "Seleccionar una imagen";
				openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{

					string rutaImagen = openFileDialog.FileName;
					Perfil.Image = Image.FromFile(rutaImagen);
				}
			}
		}
		private void Añadir_Click(object sender, EventArgs e)
		{
			string nm = Input_nm.Text;
			string ape = Input_ape.Text;
			string tel = Input_tel.Text;
			string email = Input_email.Text;
			string pwd = Input_pwd.Text;
			string pwdhash = Seguridad.Encriptar(pwd);
			object nvl = Niveles.SelectedItem.ToString();

			Image img = Perfil.Image;

			try
			{
				if (Perfil.Image == null)
				{
					MessageBox.Show("Por favor, seleccione una imagen de perfil.");
					return;
				}

				byte[] imagenBytes;

				using (MemoryStream ms = new MemoryStream())
				{
					Perfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
					imagenBytes = ms.ToArray();
				}
				SQLiteConnection sqlConnection = conexion.AbrirConexion();
				string query = "INSERT INTO Profesores (Nombres, Apellidos, Telefono, Email, Contraseña, Perfil,Nivel_Encargado) VALUES (@nom, @ape, @tel, @ema, @pwd,@img,@nvl)";
				using (SQLiteCommand cmd = new SQLiteCommand(query, sqlConnection))
				{
					cmd.Parameters.AddWithValue("@nom", nm);
					cmd.Parameters.AddWithValue("@ape", ape);
					cmd.Parameters.AddWithValue("@tel", tel);
					cmd.Parameters.AddWithValue("@ema", email);
					cmd.Parameters.AddWithValue("@pwd", pwdhash);
					cmd.Parameters.Add("@img", DbType.Binary).Value = imagenBytes;
					cmd.Parameters.AddWithValue("@nvl", nvl );

					int filasAfect = cmd.ExecuteNonQuery();
					if (filasAfect > 0)
					{
						MessageBox.Show("Profesor Añadido");
						this.Close();
					}
					else
					{
						MessageBox.Show("Error al Añadir.");
					}
				}
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Error en la base de datos: " + ex.Message);
			}
		}

		
	}
}
