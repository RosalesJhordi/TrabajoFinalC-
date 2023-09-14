using System;
using System.Data.SqlClient;
using System.Data;
using System.Reflection.Emit;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TrabajoFinal.Base_Datos;
using TrabajoFinal.FormHijas;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.Common;
using System.Security.Cryptography;

namespace TrabajoFinal
{
    public partial class PanelAdmin : Form
    {
        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_MOVE = 0xF012;
        private const int HTCAPTION = 0x2;

        // Importacion para poder arrastrar la ventana con el mouse
        [DllImport("user32.dll")]
        private static extern IntPtr ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        //conexion 
        ConexionBD conexion = new ConexionBD();

        OpenFileDialog openFileDialog = new OpenFileDialog();

        private string Id;

        public PanelAdmin()
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

            OpcionesNivel.Items.Add("Seleciona Nivel (No selecionable)");
            OpcionesNivel.Items.Add("Inicial");
            OpcionesNivel.Items.Add("Primaria");
            OpcionesNivel.Items.Add("Secundaria");
            OpcionesNivel.SelectedIndex = 0;
        }

        private void OFF_Click(object sender, EventArgs e)
        {
            
        }

        private void ON_Click(object sender, EventArgs e)
        {
            ON.Visible = false;
            OFF.Visible = true;
            timer1.Start();
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

        //datagrid cargar datos

        private void CargarDatos()
        {
            try
            {
                SqlConnection sqlConnection = conexion.AbrirConexion();
                string consulta = "SELECT Id,Nombres,Apellidos,Direccion,Email,Nivel FROM Estudiantes";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta, sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                Tabla.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        //llamar funcion
        private void PanelAdmin_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            if (Tabla.SelectedCells.Count > 0)// Verificar si se seleccio celda
            {
                int rowIndex = Tabla.SelectedCells[0].RowIndex;// Obtiene índice de la fila
                string valorId = Tabla.Rows[rowIndex].Cells["Id"].Value.ToString();//obtiene valo

                SqlConnection sqlConnection = conexion.AbrirConexion();
                string consulta = "DELETE FROM Estudiantes WHERE Id = @id";

                using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@id", valorId);
                    int filasEliminadas = sqlCommand.ExecuteNonQuery();// Ejecutar la consulta DELETE

                    if (filasEliminadas > 0)
                    {
                        MessageBox.Show("Registro eliminado correctamente.");
                        CargarDatos(); //recargar los datos
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún registro con ese ID.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna celda.");
            }

        }

        private void btn_añadir_Click(object sender, EventArgs e)
        {
            string nm = input_nm.Text;
            string ape = input_ape.Text;
            string tel = input_tel.Text;
            string dir = input_dir.Text;
            string ema = input_ema.Text;
            string pwd = input_pwd.Text;
            string nvl = OpcionesNivel.SelectedItem.ToString();

            string pwdhash = Seguridad.Encriptar(pwd);
            Console.WriteLine("Cadena Encriptada: " + pwdhash);


            // Verificar si se ha seleccionado un nivel
            if (nvl == "Selecciona Nivel (No seleccionable)")
            {
                MessageBox.Show("Por favor, seleccione un nivel.");
                return;
            }

            Image img = Perfil.Image;

            try
            {
                if (Perfil.Image == null)
                {
                    MessageBox.Show("Por favor, seleccione una imagen de perfil.");
                    return;
                }

                byte[] imagenBytes;

                using (MemoryStream ms = new MemoryStream())
                {
                    Perfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imagenBytes = ms.ToArray();
                }

                SqlConnection conex = conexion.AbrirConexion();
                string query = "INSERT INTO Estudiantes (Nombres,Apellidos,Telefono,Direccion,Email,Contrasena,Nivel,Perfil) VALUES (@nm,@ape,@tel,@dir,@ema,@pwd,@nvl,@perfil)";

                using (SqlCommand comm = new SqlCommand(query,conex))
                {
                    comm.Parameters.AddWithValue("@nm", nm);
                    comm.Parameters.AddWithValue("@ape", ape);
                    comm.Parameters.AddWithValue("@tel", tel);
                    comm.Parameters.AddWithValue("@dir", dir);
                    comm.Parameters.AddWithValue("@ema", ema);
                    comm.Parameters.AddWithValue("@pwd", pwdhash);
                    comm.Parameters.AddWithValue("@nvl", nvl);
                    comm.Parameters.Add("@perfil", SqlDbType.VarBinary).Value = imagenBytes;
                    int filasEliminadas = comm.ExecuteNonQuery();// Ejecutar la consulta DELETE

                if (filasEliminadas > 0)
                {
                    MessageBox.Show("Añadido exitosamente");
                    CargarDatos(); //recargar los datos
                }
                else
                {
                    MessageBox.Show("No se añadio");
                }
            }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_selec_Click(object sender, EventArgs e)
        {
            using (openFileDialog)
            {
                openFileDialog.Title = "Seleccionar una imagen";
                openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string rutaImagen = openFileDialog.FileName;
                    Perfil.Image = Image.FromFile(rutaImagen);
                }
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string nomb = input_nm.Text;
            string apel = input_ape.Text;
            string dire = input_dir.Text;
            string email = input_ema.Text;

            SqlConnection sqlConnection = conexion.AbrirConexion();
            string consulta = "UPDATE Estudiantes SET Nombres = @nm,Apellidos = @Ap, Direccion = @Dir, Email = @Em WHERE Id = @Id";

            using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@nm", nomb);
                sqlCommand.Parameters.AddWithValue("@Ap", apel);
                sqlCommand.Parameters.AddWithValue("@Dir", dire);
                sqlCommand.Parameters.AddWithValue("@Em", email);
                sqlCommand.Parameters.AddWithValue("@Id", Id); // Parámetro para la condición WHERE

                int filasActualizadas = sqlCommand.ExecuteNonQuery(); // Ejecutar la consulta UPDATE

                if (filasActualizadas > 0)
                {
                    MessageBox.Show("Registro actualizado correctamente.");
                    CargarDatos(); // Recargar los datos si es necesario
                }
                else
                {
                    MessageBox.Show("No se encontró ningún registro con ese nombre.");
                }
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            if (Tabla.SelectedCells.Count > 0)// Verificar si se seleccio celda
            {
                int rowIndex = Tabla.SelectedCells[0].RowIndex;// Obtiene índice de la fila
                string nom = Tabla.Rows[rowIndex].Cells["Nombres"].Value.ToString();//obtiene valor
                string ape = Tabla.Rows[rowIndex].Cells["Apellidos"].Value.ToString();
                string dir = Tabla.Rows[rowIndex].Cells["Direccion"].Value.ToString();
                string ema = Tabla.Rows[rowIndex].Cells["Email"].Value.ToString();
                Id = Tabla.Rows[rowIndex].Cells["Id"].Value.ToString();


                input_nm.Text = nom;
                input_ape.Text = ape;
                input_tel.Text = "No se puede cambiar";
                input_tel.ReadOnly = true;
                input_dir.Text = dir;
                input_ema.Text = ema;
                input_pwd.Text = "No se puede cambiar";
                input_pwd.ReadOnly = true;
                OpcionesNivel.Enabled = false;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna celda.");
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string buscado = input_buscar.Text;

            foreach (DataGridViewRow fila in Tabla.Rows)
            {
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (celda.Value != null && celda.Value.ToString().Equals(buscado, StringComparison.OrdinalIgnoreCase))
                    {
                        Tabla.CurrentCell = celda;
                        Tabla.FirstDisplayedScrollingRowIndex = fila.Index;
                        return;
                    }
                }
            }
            MessageBox.Show("No encontrado");
        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            string filt = Opciones.SelectedItem.ToString();

            if (filt == "Todo")
            {
                CargarDatos();
            }
            else
            {

                try
                {
                    SqlConnection sqlConnection = conexion.AbrirConexion();
                    string consulta = "SELECT Id, Nombres, Apellidos, Direccion, Email, Nivel FROM Estudiantes WHERE Nivel = @nvl";
                    using (SqlCommand filtro = new SqlCommand(consulta, sqlConnection))
                    {
                        filtro.Parameters.AddWithValue("@nvl", filt);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(filtro);
                        DataTable dataTable = new DataTable();

                        dataAdapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            Tabla.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron registros con ese nivel");
                            Tabla.DataSource = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }
        }

        private void btn_verdatos_Click(object sender, EventArgs e)
        {
            if (Tabla.SelectedCells.Count > 0)// Verificar si se seleccio celda
            {
                int rowIndex = Tabla.SelectedCells[0].RowIndex;// Obtiene índice de la fila
                Id = Tabla.Rows[rowIndex].Cells["Id"].Value.ToString();

                string nombres = "";
                string apellidos = "";
                string telefono = "";
                string direccion = "";
                string nivel = "";
                byte[] perfil = null;

                ConexionBD cone = new ConexionBD();
                using (SqlConnection conex = cone.AbrirConexion())
                {
                    string query = "SELECT Nombres, Apellidos, Telefono, Direccion, Nivel, Perfil FROM Estudiantes WHERE Id = @id";

                    using (SqlCommand comm = new SqlCommand(query, conex))
                    {
                        comm.Parameters.AddWithValue("@id", Id);
                        using (SqlDataReader reader = comm.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nombres = reader["Nombres"].ToString();
                                apellidos = reader["Apellidos"].ToString();
                                telefono = reader["Telefono"].ToString();
                                direccion = reader["Direccion"].ToString();
                                nivel = reader["Nivel"].ToString();
                                perfil = (byte[])reader["Perfil"];
                            }
                        }
                    }
                }
                System.Drawing.Image perfilImagen = null;

                if (perfil != null && perfil.Length > 0)
                {
                    // Convierte los bytes
                    System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                    perfilImagen = (System.Drawing.Image)converter.ConvertFrom(perfil);
                }
                DatosInfo info = new DatosInfo(nombres, apellidos, telefono, direccion, nivel, perfilImagen);
                info.Show();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna estudiante");
            }
        }
    }
}
