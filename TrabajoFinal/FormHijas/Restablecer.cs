using System;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TrabajoFinal.Base_Datos;
using System.Data.SqlClient;

namespace TrabajoFinal.FormHijas
{
    public partial class Restablecer : Form
    {
        public string captchagenerado;
        private SpeechSynthesizer synth = new SpeechSynthesizer();

        public Restablecer()
        {
            InitializeComponent();
            GenerarNuevoCaptcha();

            foreach (InstalledVoice voice in synth.GetInstalledVoices())
            {
                if (voice.VoiceInfo.Culture.Name == "es-ES") // Español de España
                {
                    synth.SelectVoice(voice.VoiceInfo.Name);
                    break;
                }
            }
        }

        private void Sonido_Click(object sender, EventArgs e)
        {
            // Obtener el texto del TextBox
            string texto = Captcha.Text;

            if (!string.IsNullOrEmpty(texto))
            {
                foreach (char letra in texto)
                {
                    string letraTexto = letra.ToString();
                    synth.SpeakAsync(letraTexto);
                    System.Threading.Thread.Sleep(100);
                }
            }

        }

        private void Ver_Click(object sender, EventArgs e)
        {
            NoVer.Visible = true; //img no ver visible
            Ver.Visible = false; //img ver oculto
            string texto = input_pwd1.Text;//guardamos el valor del textbox en una variable
            input_pwd1.PasswordChar = '\0';//Quitamos todos los caracteres
            input_pwd1.Text = texto; //cargamos el texto
        }

        private void NoVer_Click(object sender, EventArgs e)
        {
            //aparece desdepues de dar clik la imagen del ojo
            Ver.Visible = true; //img ver visible
            NoVer.Visible = false;//img no ver oculto
            string texto = input_pwd1.Text;
            input_pwd1.PasswordChar = '*';
            input_pwd1.Text = texto;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            input_pwd1.PasswordChar = '*';//Convierte el exto en *
        }

        private void input_pwd2_TextChanged(object sender, EventArgs e)
        {
            input_pwd2.PasswordChar = '*';//Convierte el exto en *
        }

        private void ReLoad1_Click(object sender, EventArgs e)
        {
            ReLoad1.Visible = false;
            ReLoad2.Visible = true;
            GenerarNuevoCaptcha();
        }

        private void ReLoad2_Click(object sender, EventArgs e)
        {
            ReLoad2.Visible=false;
            ReLoad1.Visible=true;
            GenerarNuevoCaptcha();
        }
        // Generar un CAPTCHA
        private void GenerarNuevoCaptcha()
        {
            // Llamada para generar un CAPTCHA de 6 caracteres y mostrarlo en un Label llamado "Captcha"
            captchagenerado = GenerarCaptcha(6);
            Captcha.Text = captchagenerado;
        }
        //captcha
        private string GenerarCaptcha(int longitud)
        {
            const string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder captcha = new StringBuilder();

            Random random = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int indiceCaracter = random.Next(0, caracteresPermitidos.Length);
                captcha.Append(caracteresPermitidos[indiceCaracter]);
            }

            return captcha.ToString();
        }

        private void Btn_camb_Click(object sender, EventArgs e)
        {
            string capt = Captcha.Text;
            string valor = input_captcha.Text;
            string ape = input_ape.Text;
            string email = input_email.Text;
            string pwdd1 = input_pwd1.Text;
            string pwdd2 = input_pwd2.Text;

            string pwdhash = Seguridad.Encriptar(pwdd1);
            Console.WriteLine("Cadena Encriptada: " + pwdhash);

            if (valor == capt)
            {   
                if(pwdd1 == pwdd2)
                {
                    ConexionBD cone = new ConexionBD();
                    using (SqlConnection conex = cone.AbrirConexion())
                    {
                        string query = "UPDATE Estudiantes SET Contrasena = @pwd WHERE Email = @ema AND Apellidos = @ape";

                        using (SqlCommand comm = new SqlCommand(query, conex))
                        {
                            comm.Parameters.AddWithValue("@pwd", pwdhash);
                            comm.Parameters.AddWithValue("@ema", email);
                            comm.Parameters.AddWithValue("@ape", ape);

                            int filasActualizadas = comm.ExecuteNonQuery();

                            if (filasActualizadas > 0)
                            {
                               MessageBox.Show("Contraseña actualizada correctamente");
                            }
                            else
                            {
                               MessageBox.Show("No se encontró ningún registro con ese nombre");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
            else
            {
                MessageBox.Show("error en el captcha");
                GenerarNuevoCaptcha();
            }
        }

        private void Parar_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
        }
    }
}