using System.Drawing;
using System.Windows.Forms;

namespace TrabajoFinal.FormHijas
{
    public partial class DatosInfo : Form
    {
        public DatosInfo(string nom,string apel,string tele,string dire,string nivl,Image perfil)
        {
            InitializeComponent();

            nm.Text = nom;
            ape.Text = apel;
            tel.Text = tele;
            dir.Text = dire;
            nvl.Text = nivl;
            Perfil.SizeMode = PictureBoxSizeMode.StretchImage;
            Perfil.Image = perfil;

        }
    }
}
