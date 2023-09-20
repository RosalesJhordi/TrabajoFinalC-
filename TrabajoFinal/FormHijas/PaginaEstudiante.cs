using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoFinal.FomsEstudiante;
using TrabajoFinal.FormsProfesor;

namespace TrabajoFinal.FormHijas
{
	public partial class PaginaEstudiante : Form
	{
		public string nom;
		public string apel;
		public string tele;
		public string ema;
		public string nivl;
		public Image perfile;
		public PaginaEstudiante(string nm,string ape,string tel,string dir,string em,string nvl, Image perfil)
		{
			InitializeComponent();

			APE.Text = ape.ToString();
			//verifica si el form esta visible y si es verdadero lo oculta
			foreach (Form form in Application.OpenForms)
			{
				if (form is Form1)
				{
					form.Hide();
					break;
				}
			}
			string ap = nm.ToString();
			AbrirFormHija(new Tareas(ap,nvl));
			nom = nm;
			apel = ape;
			tele = tel;
			ema = em;
			nivl = nvl;
			perfile = perfil;
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

		private void Cerrasesion_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void PaginaEstudiante_Load(object sender, EventArgs e)
		{
		}

		private void Cuenta_Click(object sender, EventArgs e)
		{
			AbrirFormHija(new Cuenta(nom,apel,tele,ema,nivl,perfile));
		}
	}
}
