using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TrabajoFinal
{
    public partial class Crud : Form
    {
        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_MOVE = 0xF012;
        private const int HTCAPTION = 0x2;

        // Importacion para poder arrastrar la ventana con el mouse
        [DllImport("user32.dll")]
        private static extern IntPtr ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public Crud()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;

            foreach (Form form in Application.OpenForms)
            {
                if (form is Form1)
                {
                    form.Hide();
                    break;
                }
            }
            Opciones.Height = 40;
            Opciones.Items.Add("Todo");
            Opciones.Items.Add("Inicial");
            Opciones.Items.Add("Primaria");
            Opciones.Items.Add("Secundaria");
            Opciones.SelectedIndex = 0;
        }

        private void ON_Click(object sender, EventArgs e)
        {
            ON.Visible = false;
            OFF.Visible = true;
            timer1.Start();
        }

        private void OFF_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Barra_Control_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void Crud_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_IE_CMDataSet.Estudiante' Puede moverla o quitarla según sea necesario.
            this.estudianteTableAdapter.Fill(this.bD_IE_CMDataSet.Estudiante);

        }
    }
}
