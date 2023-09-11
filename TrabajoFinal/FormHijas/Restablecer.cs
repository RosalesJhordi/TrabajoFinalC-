using System;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                // Deletrear cada letra individualmente
                foreach (char letra in texto)
                {
                    string letraTexto = letra.ToString();
                    synth.Speak(letraTexto); // Convertir y reproducir cada letra
                    Application.DoEvents(); // Permitir la actualización de la interfaz de usuario
                    System.Threading.Thread.Sleep(200); // Esperar un tiempo entre letras (ajusta según tus preferencias)
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

            if (valor == capt)
            {
                MessageBox.Show("Son iguales");
            }
            else
            {
                MessageBox.Show("falla");
            }
        }
    }
}
