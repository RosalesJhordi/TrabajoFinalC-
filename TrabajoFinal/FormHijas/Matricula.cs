using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TrabajoFinal.Base_Datos;

namespace TrabajoFinal.FormHijas
{
    public partial class Matricula : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();

        //conexion object
        ConexionBD conexion = new ConexionBD();

        public Matricula()
        {
            InitializeComponent();

            // ComboBox
            Opciones.Height = 40;
            Opciones.Items.Add("Seleciona Nivel (No seleccionable)");
            Opciones.Items.Add("Inicial");
            Opciones.Items.Add("Primaria");
            Opciones.Items.Add("Secundaria");

            Opciones.SelectedIndex = 0;
        }

        private void Opciones_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Ver_Click(object sender, EventArgs e)
        {
            Ver.Visible = false;
            pictureBox9.Visible = true;
            string texto = input_pwd.Text;//guardamos el valor del textbox en una variable
            input_pwd.PasswordChar = '\0';//Quitamos todos los caracteres
            input_pwd.Text = texto;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            Ver.Visible= true;
            string texto = input_pwd.Text;
            input_pwd.PasswordChar = '*';
            input_pwd.Text = texto;
        }

        private void input_pwd_TextChanged(object sender, EventArgs e)
        {
            input_pwd.PasswordChar = '*';//Convierte el exto en *
        }
		private void Btn_Selecionar_Click(object sender, EventArgs e)
		{
			//permitir selecionar archivo
			using (openFileDialog)
			{
				openFileDialog.Title = "Seleccionar una imagen";
				openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif"; // extensiones permitidas

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					// Obtiene la ruta completa d la imagen
					string rutaImagen = openFileDialog.FileName;
					Perfil.Image = Image.FromFile(rutaImagen);// Carga la imagen desde archivos
				}
			}
		}
		//Btn clik matricular
		private void button1_Click(object sender, EventArgs e)
        {
            //datos de textbox
            string nom = input_nombres.Text;
            string ape = input_ape.Text;
            string tel = input_telefono.Text;
            string dir = input_direcion.Text;
            string ema = input_email.Text;
            string pwd = input_pwd.Text;
            string nvl = Opciones.SelectedItem.ToString();

            string pwdhash = Seguridad.Encriptar(pwd); // encriptamos pwd

            // Verificar si se ha seleccionado un nivel
            if (nvl == "Selecciona Nivel (No seleccionable)")
            {
                MessageBox.Show("Por favor, seleccione un nivel.");
                return;
            }

            Image img = Perfil.Image;

            try
            {
                //verificar imagen
                if (Perfil.Image == null)
                {
                    MessageBox.Show("Por favor, seleccione una imagen de perfil.");
                    return;
                }

                byte[] imagenBytes;

                using (MemoryStream ms = new MemoryStream())// manipular datos almacenados en la memoria RAM en lugar de en archivos físicos
				{
					// Guarda la imagen en formato JPEG en el MemoryStream
					Perfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imagenBytes = ms.ToArray();// Convierte el MemoryStream a un arreglo de bytes
				}

				SQLiteConnection sqlConnection = conexion.AbrirConexion();
				string query = "INSERT INTO Estudiantes (Nombres, Apellidos, Telefono, Direccion, Email, Contrasena, Nivel, Perfil) VALUES (@nom, @ape, @tel, @dir, @ema, @pwd, @nvl, @img)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, sqlConnection))
                {
                        cmd.Parameters.AddWithValue("@nom", nom);
                        cmd.Parameters.AddWithValue("@ape", ape);
                        cmd.Parameters.AddWithValue("@tel", tel);
                        cmd.Parameters.AddWithValue("@dir", dir);
                        cmd.Parameters.AddWithValue("@ema", ema);
                        cmd.Parameters.AddWithValue("@pwd", pwdhash);
                        cmd.Parameters.AddWithValue("@nvl", nvl);
					    cmd.Parameters.Add("@img", DbType.Binary).Value = imagenBytes; //agreamos imagen en bytes

					    int filasAfect = cmd.ExecuteNonQuery();
                        if (filasAfect > 0)
                        {
                            MessageBox.Show("Matriculado exitosamente");
                        }
                        else
                        {
                            MessageBox.Show("Error al matricular. Por favor, inténtelo de nuevo.");
                        }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        private void Matricula_Load(object sender, EventArgs e)
        {

        }
    }
}