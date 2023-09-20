using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal.FormsProfesor
{
	public partial class Cuenta : Form
	{
		public Cuenta(string nm,string ape,string tel,string ema,string niv, Image perfil)
		{
			InitializeComponent();
			foto.SizeMode = PictureBoxSizeMode.StretchImage;
			foto.Image = perfil;
			nombres.Text = nm;
			apellidos.Text = ape;
			telefono.Text = tel;
			mail.Text = ema;
			nivl.Text = niv;
		}

		private void cerrar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Cuenta_Load(object sender, EventArgs e)
		{

		}
	}
}
