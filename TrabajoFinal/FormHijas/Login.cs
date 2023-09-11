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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

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
    }
}
