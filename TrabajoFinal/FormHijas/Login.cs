using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TrabajoFinal.Base_Datos;
using Mono.Data.Sqlite;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrabajoFinal.FormHijas
{
    public partial class Login : Form
    {
        public int borderradius;
        //conexion 
        ConexionBD conexion = new ConexionBD();
        public Login()
        {
            InitializeComponent();
            btn_login.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_login.Width, btn_login.Height, 5, 5));
        }
        // Función para crear un región de botón con esquinas redondeadas
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private void VerPwd_Click(object sender, EventArgs e)
        {
            NoVerPwd.Visible = true; //img no ver visible
            VerPwd.Visible = false; //img ver oculto
            string texto = input_pwd.Text;//guardamos el valor del textbox en una variable
            input_pwd.PasswordChar = '\0';//Quitamos todos los caracteres
            input_pwd.Text = texto; //cargamos el texto
        }

        private void NoVerPwd_Click(object sender, EventArgs e)
        {
            //aparece desdepues de dar clik la imagen del ojo
            VerPwd.Visible = true; //img ver visible
            NoVerPwd.Visible = false;//img no ver oculto
            string texto = input_pwd.Text;
            input_pwd.PasswordChar = '*';
            input_pwd.Text = texto;
        }

        private void input_pwd_TextChanged(object sender, EventArgs e)
        {
            input_pwd.PasswordChar = '*';//Convierte el exto en *
        }

        private void Link_OlvidoPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dialogo popup = new Dialogo();
            popup.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            try {
                string email = input_email.Text;
                string pwd = input_pwd.Text;

                string userAdmin = "Admin";
                string pwdAdmin = "Admin";

                if (email == userAdmin && pwd == pwdAdmin)
                {
                    PanelAdmin admin = new PanelAdmin();
                    admin.Show();
                }
                else
                {
                    string query = "SELECT * FROM Estudiantes WHERE Email = @em";
                    SQLiteConnection conex = conexion.AbrirConexion();
                    using (SQLiteCommand comm = new SQLiteCommand(query, conex))
                    {
                        comm.Parameters.AddWithValue("@em", email);

                        using (SQLiteDataReader reader = comm.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string pwd2 = reader["Contrasena"].ToString();
                                    //función Desencriptar
                                    string pwdhash = Seguridad.Desencriptar(pwd2);
                                    string Nombre = reader["Nombres"].ToString();
                                    string Apellidos = reader["Apellidos"].ToString();
                                    string Telefono = reader["Telefono"].ToString();
                                    string Direccion = reader["Direccion"].ToString();
                                    string Email = reader["Email"].ToString();
                                    string Nivel = reader["Nivel"].ToString();
                                    byte[] perfilBytes = (byte[])reader["Perfil"];
									System.Drawing.Image perfilImagen = null;

									if (perfilBytes != null && perfilBytes.Length > 0)
									{
										// Convierte los bytes
										System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
										perfilImagen = (System.Drawing.Image)converter.ConvertFrom(perfilBytes);
									}
									if (pwd == pwdhash)
                                    {
                                        PaginaEstudiante est = new PaginaEstudiante(Nombre, Apellidos, Telefono, Direccion, Email, Nivel, perfilImagen);
                                        est.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Falla");
                                    }
                                }
                            }
                            else if(reader.HasRows == false)
                            {
								string query1 = "SELECT * FROM Profesores WHERE Email = @em";
								using (SQLiteCommand comm1 = new SQLiteCommand(query1, conex))
								{
									comm1.Parameters.AddWithValue("@em", email);

									using (SQLiteDataReader reader1 = comm1.ExecuteReader())
									{
										if (reader1.HasRows)
										{
											while (reader1.Read())
											{
												string pwd2 = reader1["Contraseña"].ToString();
												//función Desencriptar
												string pwdhash = Seguridad.Desencriptar(pwd2);
												string Nombre = reader1["Nombres"].ToString();
												string Apellidos = reader1["Apellidos"].ToString();
												string Telefono = reader1["Telefono"].ToString();
												string Email = reader1["Email"].ToString();
												string Nivel = reader1["Nivel_Encargado"].ToString();
												byte[] perfilBytes = (byte[])reader1["Perfil"];
												System.Drawing.Image perfilImagen = null;

												if (perfilBytes != null && perfilBytes.Length > 0)
												{
													// Convierte los bytes
													System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
													perfilImagen = (System.Drawing.Image)converter.ConvertFrom(perfilBytes);
												}
												if (pwd == pwdhash)
												{
													PaginaProfesor pr = new PaginaProfesor(Nombre,Apellidos,Telefono,Email,Nivel,perfilImagen);
                                                    pr.Show();
												}
												else
												{
													MessageBox.Show("Falla");
												}
											}
										}
									}
								}
							}
                            else
                            {
                                MessageBox.Show("Error: Este usuario no existe");
                            }
                        }
                    }
                }
            } catch (Exception ex)
            {
				MessageBox.Show("Error: " + ex.Message);
			}
        }
	}
}
