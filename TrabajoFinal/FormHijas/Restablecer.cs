using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal.FormHijas
{
    public partial class Restablecer : Form
    {
        public Restablecer()
        {
            InitializeComponent();
        }

        private void Sonido_Click(object sender, EventArgs e)
        {
            Sonido.Visible = false;
            SinSonido.Visible = true;
        }

        private void SinSonido_Click(object sender, EventArgs e)
        {
            SinSonido.Visible=false;
            Sonido.Visible=true;
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
        }

        private void ReLoad2_Click(object sender, EventArgs e)
        {
            ReLoad2.Visible=false;
            ReLoad1.Visible=true;
        }
    }
}
