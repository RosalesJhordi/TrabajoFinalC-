using System;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using TrabajoFinal.Base_Datos;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace TrabajoFinal.FormHijas
{
    public partial class Restablecer : Form
    {
        public string captchagenerado;
        private SpeechSynthesizer synth = new SpeechSynthesizer();

        public Restablecer()
        {
            InitializeComponent();

            //GENARAR CAPTCHA
            GenerarNuevoCaptcha();

            foreach (InstalledVoice voice in synth.GetInstalledVoices())
            {
                //RECORRE VOCES
                if (voice.VoiceInfo.Culture.Name == "es-ES") // Español de España
                {
                    //SELECIONA VOZ
                    synth.SelectVoice(voice.VoiceInfo.Name);
                    break;
                }
            }
        }

        private void Sonido_Click(object sender, EventArgs e)
        {
            // Obtener el texto del TextBox
            string texto = Captcha.Text;

            if (!string.IsNullOrEmpty(texto)) // VERIFICA QUE EL TEXTO NO ESTE VACIA
            {
                //RECORRER CADA CARACTER DEL TEXTO
                foreach (char letra in texto)
                {
                    string letraTexto = letra.ToString();// Convierte el carácter para que la voz pueda leerlo
					synth.SpeakAsync(letraTexto); // REPRODUCE EL CARACTER
                    System.Threading.Thread.Sleep(50); //HAVER UNA PAUSA DESPUES DE REPRODUCIR CARACTER
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

        //RECARGA CAPTCHA
        private void ReLoad1_Click(object sender, EventArgs e)
        {
            ReLoad1.Visible = false; // IMG 1 NO VISIBLE
            ReLoad2.Visible = true; // IMG 2 VISIBLE
            GenerarNuevoCaptcha(); //GENERA NUEVO CAPTCHA
        }

		//RECARGA CAPTCHA
		private void ReLoad2_Click(object sender, EventArgs e)
        {
            ReLoad2.Visible=false;
            ReLoad1.Visible=true;
            GenerarNuevoCaptcha(); //GENERA NUEVO CAPTCHA
		}
        // Generar un CAPTCHA
        private void GenerarNuevoCaptcha()
        {
            // generar  Captcha
            captchagenerado = GenerarCaptcha(6); // cantidad de caraxteres
            Captcha.Text = captchagenerado; // mostrar captcha en el label
        }
        //Funcion genrar captcha
        private string GenerarCaptcha(int longitud)
        {
			// Definimos lista de caracteres
			const string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder captcha = new StringBuilder(); //construir captcha

            Random random = new Random(); //genera numeros aleatorios
			
            // Recorremos para generar cada caracter del Captcha
			for (int i = 0; i < longitud; i++)
            {
				// Generamos un índice aleatorio
				int indiceCaracter = random.Next(0, caracteresPermitidos.Length);
                captcha.Append(caracteresPermitidos[indiceCaracter]); // Agregamos el carácter aleatorio al Captcha
			}

            return captcha.ToString();
        }

        //clik boton
        private void Btn_camb_Click(object sender, EventArgs e)
        {
           // Obtenedmos datos de los textbox
            string capt = Captcha.Text;
            string valor = input_captcha.Text;
            string ape = input_ape.Text;
            string email = input_email.Text;
            string pwdd1 = input_pwd1.Text;
            string pwdd2 = input_pwd2.Text;

            // usamos la clase seguridad y la funciin ppara encriptar la contraseña
            string pwdhash = Seguridad.Encriptar(pwdd1);

            if (valor == capt)
            {   
                if(pwdd1 == pwdd2)
                {
                    ConexionBD cone = new ConexionBD();
                    using (SQLiteConnection conex = cone.AbrirConexion())
                    {
                        string query = "UPDATE Estudiantes SET Contrasena = @pwd WHERE Email = @ema AND Apellidos = @ape";

                        using (SQLiteCommand comm = new SQLiteCommand(query, conex)) // comando sql
                        {
                            comm.Parameters.AddWithValue("@pwd", pwdhash);
                            comm.Parameters.AddWithValue("@ema", email);
                            comm.Parameters.AddWithValue("@ape", ape);

                            //ejecuta y cuenta las columnas afectadas
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
            synth.SpeakAsyncCancelAll(); // cancela operacion de voz
        }
    }
}