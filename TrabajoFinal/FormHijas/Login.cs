using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TrabajoFinal.Base_Datos;

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
                SqlConnection conex = conexion.AbrirConexion();
                string query = "SELECT * FROM Estudiantes WHERE Email = @em";

                using (SqlCommand comm = new SqlCommand(query, conex))
                {
                    comm.Parameters.AddWithValue("@em", email);

                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string pwd2 = reader["Contrasena"].ToString();
                                //función Desencriptar
                                string pwdhash = Seguridad.Desencriptar(pwd2);
                                if(pwd == pwdhash)
                                {
                                    MessageBox.Show("Correcto");
                                }
                                else
                                {
                                    MessageBox.Show("Falla");
                                }
                            }
                        }
                        else
                        {
                            // No se encontraron resultados
                        }
                    }
                }
            }
        }
    }
}
