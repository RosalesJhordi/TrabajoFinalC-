using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TrabajoFinal.FormHijas;

namespace TrabajoFinal
{
    public partial class Form1 : Form
    {
        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_MOVE = 0xF012;
        private const int HTCAPTION = 0x2;

        // Importacion para poder arrastrar la ventana con el mouse
        [DllImport("user32.dll")]
        private static extern IntPtr ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaxi.Visible = false;
            BtnMini.Visible = true;
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnMaxi.Visible = true;
            BtnMini.Visible = false;
        }

        private void BtnOcul_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Barra_Control_MouseDown(object sender, MouseEventArgs e)
        {   
            BtnMaxi.Visible = true;
            BtnMini.Visible = false;
            ReleaseCapture();
            SendMessage(Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            
        }

        private void OFF_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // metodo para abrir un form hija sin cerrar
        private void AbrirFormHija(object formHija)
        {
            // Elimina todos los controles existentes en el form
            foreach (Control control in this.Contenedor.Controls)
            {
                control.Dispose();
            }

            Form formHijo = formHija as Form;
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(formHijo);
            this.Contenedor.Tag = formHijo;
            formHijo.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AbrirFormHija(new Inicio());
        }
    }
}
