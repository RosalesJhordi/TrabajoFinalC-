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

namespace TrabajoFinal
{
	public partial class PaginaProfesor : Form
	{
		public string nom;
		public string apel;
		public string tele;
		public string ema;
		public string nivl;
		public Image perfile;
		public PaginaProfesor(string nm,string ape,string tel,string em,string nvl, Image perfil)
		{
			InitializeComponent();
			APE.Text = ape.ToString();

			foreach (Form form in Application.OpenForms)
			{
				if (form is Form1)
				{
					form.Hide();
					break;
				}
			}
			AbrirFormHija(new DejarTarea(nvl));

			nom = nm;
			apel = ape;
			tele = tel;
			ema = em;
			nivl = nvl;
			perfile = perfil;
		}
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

		private void PaginaProfesor_Load(object sender, EventArgs e)
		{
		}

		private void Cuenta_Click(object sender, EventArgs e)
		{
			AbrirFormHija(new Cuenta(nom, apel, tele, ema, nivl, perfile));
		}

		private void Tarea_Click(object sender, EventArgs e)
		{
			AbrirFormHija(new ListTareas(nivl));
		}

		private void Tareas_Click(object sender, EventArgs e)
		{
			AbrirFormHija(new DejarTarea(nivl));
		}
	}
}
