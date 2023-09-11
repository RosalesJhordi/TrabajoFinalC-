﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TrabajoFinal.Base_Datos;

namespace TrabajoFinal.FormHijas
{
    public partial class Matricula : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();

        private string connectionString = "Data Source=DESKTOP-2QR1BR7\\SQLEXPRESS;Initial Catalog=BD_IE_CM;Integrated Security=True;User ID=DESKTOP-2QR1BR7\\Equipo";
        private SqlConnection conn;

        public Matricula()
        {
            InitializeComponent();

            // ComboBox
            Opciones.Height = 40;
            Opciones.Items.Add("Seleciona Nivel (No seleccionable)");
            Opciones.Items.Add("INICIAL");
            Opciones.Items.Add("PRIMARIA");
            Opciones.Items.Add("SECUNDARIA");

            Opciones.SelectedIndex = 0;
        }

        private void Opciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string seleccion = Opciones.SelectedItem.ToString();
        }

        private void Btn_Selecionar_Click(object sender, EventArgs e)
        {
            using (openFileDialog)
            {
                // Establece las propiedades del OpenFileDialog
                openFileDialog.Title = "Seleccionar una imagen";
                openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

                // Verifica si el usuario seleccionó un archivo
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtén la ruta del archivo seleccionado
                    string rutaImagen = openFileDialog.FileName;

                    // Puedes cargar y mostrar la imagen en un PictureBox u otro control
                    Perfil.Image = Image.FromFile(rutaImagen);
                }
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = input_nombres.Text;
            string ape = input_ape.Text;
            string tel = input_telefono.Text;
            string dir = input_direcion.Text;
            string ema = input_email.Text;
            string pwd = input_pwd.Text;
            string nvl = Opciones.SelectedItem.ToString();

            // Verificar si se ha seleccionado un nivel
            if (nvl == "Seleciona Nivel (No seleccionable)")
            {
                MessageBox.Show("Por favor, seleccione un nivel.");
                return;
            }

            Image img = Perfil.Image;

            try
            {
                // Convertir la imagen en un arreglo de bytes
                byte[] imagenBytes = null;

                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Cambia el formato según sea necesario
                    imagenBytes = ms.ToArray();
                }

                conn = new SqlConnection(connectionString); //creamos la conexion a la bd
                conn.Open();
                string query = "INSERT INTO Estudiantes (Nombres, Apellidos, Telefono, Direccion, Email, Contrasena, Nivel, Perfil) VALUES (@nom, @ape, @tel, @dir, @ema, @pwd, @nvl, @img)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@ape", ape);
                    cmd.Parameters.AddWithValue("@tel", tel);
                    cmd.Parameters.AddWithValue("@dir", dir);
                    cmd.Parameters.AddWithValue("@ema", ema);
                    cmd.Parameters.AddWithValue("@pwd", pwd);
                    cmd.Parameters.AddWithValue("@nvl", nvl);
                    cmd.Parameters.Add("@img", SqlDbType.VarBinary).Value = imagenBytes;
                    

                    // Ejecutamos la consulta
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
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message);
            }

        }
    }
}