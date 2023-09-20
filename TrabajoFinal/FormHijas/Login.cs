using System;
using System.Windows.Forms;
using TrabajoFinal.Base_Datos;
using System.Data.SQLite;

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
        }

        //clik ojo
        private void VerPwd_Click(object sender, EventArgs e)
        {
            NoVerPwd.Visible = true; //img no ver visible
            VerPwd.Visible = false; //img ver oculto
            string texto = input_pwd.Text;//guardamos el valor del textbox en una variable
            input_pwd.PasswordChar = '\0';//Quitamos todos los caracteres
            input_pwd.Text = texto; //cargamos el texto
        }

        //clik ojo cerrado
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
        //label link
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
                //obtener datos de los textbox
                string email = input_email.Text;
                string pwd = input_pwd.Text;

                //variables definidas
                string userAdmin = "Admin";
                string pwdAdmin = "Admin";

                //veerificar admin
                if (email == userAdmin && pwd == pwdAdmin)
                {
                    PanelAdmin admin = new PanelAdmin();
                    admin.Show();
                }
                //verificar alimno - profesor
                else
                {
                    string query = "SELECT * FROM Estudiantes WHERE Email = @em";
                    SQLiteConnection conex = conexion.AbrirConexion(); // Abrir conexion
                    using (SQLiteCommand comm = new SQLiteCommand(query, conex))
                    {
                        comm.Parameters.AddWithValue("@em", email);

                        using (SQLiteDataReader reader = comm.ExecuteReader()) //ejecutar
                        {
                            //verificar si tiene filas
                            if (reader.HasRows)
                            {
                                //leer las filas q devolvio la bd
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
                                    //verificar contraseña
									if (pwd == pwdhash)
                                    {   
                                        //si la contraseña es correcta
                                        PaginaEstudiante est = new PaginaEstudiante(Nombre, Apellidos, Telefono, Direccion, Email, Nivel, perfilImagen);
                                        est.Show();
                                    }
                                    else
                                    {   
                                        //si la contraseña no coincide
                                        MessageBox.Show("CONTRASEÑA INCORRECTA");
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
												string pwd2 = reader1["Contrasena"].ToString();
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
                                                    //SI LAS CONTRASEÑAS SON IGUAALES
													PaginaProfesor pr = new PaginaProfesor(Nombre,Apellidos,Telefono,Email,Nivel,perfilImagen);
                                                    pr.Show();
												}
												else
												{
													MessageBox.Show("CONTRASEÑA INCORRECTA");
												}
											}
										}
									}
								}
							}
                            // si los datos no existen en Esudiantes - profesores
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
