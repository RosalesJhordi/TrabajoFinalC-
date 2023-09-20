using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TrabajoFinal.Base_Datos;
using TrabajoFinal.FormHijas;
using System.IO;
using System.Data.SQLite;

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

        //conexion OBJETO
        ConexionBD conexion = new ConexionBD();

        OpenFileDialog openFileDialog = new OpenFileDialog();

        private string Id;

        public PanelAdmin()
        {
            InitializeComponent();

            timer1 = new Timer();
            timer1.Interval = 1000;// intervalo
			timer1.Tick += timer1_Tick; //EVENTO

            //OCULTAR FORM1
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form1)
                {
                    form.Hide();
                    break;
                }
            }
            //FILTRO
            Opciones.Height = 40;
            Opciones.Items.Add("Todo");
            Opciones.Items.Add("Inicial");
            Opciones.Items.Add("Primaria");
            Opciones.Items.Add("Secundaria");
            Opciones.SelectedIndex = 0;
            //NIVEL ACAD
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
        //EVENTO TIMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //ARRASTRAR VENTANA
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
                SQLiteConnection sqlConnection = conexion.AbrirConexion(); //INICIAR CONEXIO
                string consulta = "SELECT Id,Nombres,Apellidos,Direccion,Email,Nivel FROM Estudiantes";
                //APADTADOR DE DATOS
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(consulta, sqlConnection);
                DataTable dataTable = new DataTable(); //ALMACENA DATOS SEGUN EL SESULTADO DE LA CONSULTA
                dataAdapter.Fill(dataTable); //LLENAR DATOS
                Tabla.DataSource = dataTable; //AGREGA EL TABLE A UN DATAGRID
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //EXEPCION
            }
            finally
            {
                conexion.CerrarConexion(); // CERRA CONEXION
            }
        }
        //llamar funcion
        private void PanelAdmin_Load(object sender, EventArgs e)
        {
            //CARGAR DATOS AL INICIAR
            CargarDatos();
        }

        //ELIMINAR
        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            if (Tabla.SelectedCells.Count > 0)// Verificar si se seleccio celda
            {
                int rowIndex = Tabla.SelectedCells[0].RowIndex;// Obtiene índice de la fila
                string valorId = Tabla.Rows[rowIndex].Cells["Id"].Value.ToString();//obtiene valor Id

                SQLiteConnection sqlConnection = conexion.AbrirConexion();
                string consulta = "DELETE FROM Estudiantes WHERE Id = @id";

                using (SQLiteCommand sqlCommand = new SQLiteCommand(consulta, sqlConnection))
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

        //ANADIR
        private void btn_añadir_Click(object sender, EventArgs e)
        {
            string nm = input_nm.Text;
            string ape = input_ape.Text;
            string tel = input_tel.Text;
            string dir = input_dir.Text;
            string ema = input_ema.Text;
            string pwd = input_pwd.Text;
            string nvl = OpcionesNivel.SelectedItem.ToString();

            string pwdhash = Seguridad.Encriptar(pwd);//ENCRIPTAR

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

				SQLiteConnection conex = conexion.AbrirConexion();
                string query = "INSERT INTO Estudiantes (Nombres,Apellidos,Telefono,Direccion,Email,Contrasena,Nivel,Perfil) VALUES (@nm,@ape,@tel,@dir,@ema,@pwd,@nvl,@perfil)";

                using (SQLiteCommand comm = new SQLiteCommand(query,conex))
                {
                    comm.Parameters.AddWithValue("@nm", nm);
                    comm.Parameters.AddWithValue("@ape", ape);
                    comm.Parameters.AddWithValue("@tel", tel);
                    comm.Parameters.AddWithValue("@dir", dir);
                    comm.Parameters.AddWithValue("@ema", ema);
                    comm.Parameters.AddWithValue("@pwd", pwdhash);
                    comm.Parameters.AddWithValue("@nvl", nvl);
					comm.Parameters.Add("@perfil", DbType.Binary).Value = imagenBytes;
					int filas = comm.ExecuteNonQuery();

                    if (filas > 0)
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

        //SELECIONAR IMAGEN
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

        //ACTUALIZAR
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string nomb = input_nm.Text;
            string apel = input_ape.Text;
            string dire = input_dir.Text;
            string email = input_ema.Text;

			SQLiteConnection sqlConnection = conexion.AbrirConexion();
            string consulta = "UPDATE Estudiantes SET Nombres = @nm,Apellidos = @Ap, Direccion = @Dir, Email = @Em WHERE Id = @Id";

            using (SQLiteCommand sqlCommand = new SQLiteCommand(consulta, sqlConnection))
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

        //SELECIONAR USUARIO
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


        //BUSCAR
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string buscado = input_buscar.Text;
			// Recorrer todas las filas de la tabla 
			foreach (DataGridViewRow fila in Tabla.Rows)
            {
                foreach (DataGridViewCell celda in fila.Cells)
                {
					// Verificar si el valor de la celda no es nulo - igual a buscado
					if (celda.Value != null && celda.Value.ToString().Equals(buscado, StringComparison.OrdinalIgnoreCase))
                    {
                        //celda encontrada
                        Tabla.CurrentCell = celda;
                        Tabla.FirstDisplayedScrollingRowIndex = fila.Index; //mostrar fila donde esta
                        return; // sali al encontrarla
                    }
                }
            }
            //si no encuntra el valor buscado
            MessageBox.Show("No encontrado");
        }


        //FILTRAR
        private void Filtrar_Click(object sender, EventArgs e)
        {
            string filt = Opciones.SelectedItem.ToString(); // combobox

            if (filt == "Todo")
            {
                //mostrar todos los niveles
                CargarDatos();
            }
            else
            {

                try
                {
					SQLiteConnection sqlConnection = conexion.AbrirConexion();
                    string consulta = "SELECT Id, Nombres, Apellidos, Direccion, Email, Nivel FROM Estudiantes WHERE Nivel = @nvl";
                    using (SQLiteCommand filtro = new SQLiteCommand(consulta, sqlConnection))
                    {
                        filtro.Parameters.AddWithValue("@nvl", filt);

						SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(filtro);
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

        //VER DATOS
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
                using (SQLiteConnection conex = cone.AbrirConexion())
                {
                    string query = "SELECT Nombres, Apellidos, Telefono, Direccion, Nivel, Perfil FROM Estudiantes WHERE Id = @id";

                    using (SQLiteCommand comm = new SQLiteCommand(query, conex))
                    {
                        comm.Parameters.AddWithValue("@id", Id);
                        using (SQLiteDataReader reader = comm.ExecuteReader())
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

                //verificar imagen
                if (perfil != null && perfil.Length > 0)
                {
                    // Convierte los bytes a img
                    System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                    perfilImagen = (System.Drawing.Image)converter.ConvertFrom(perfil);
                }
                //abrimos form y pasamos argumentos
                DatosInfo info = new DatosInfo(nombres, apellidos, telefono, direccion, nivel, perfilImagen);
                info.Show(); // mostramos
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna estudiante");
            }
        }

        //AÑADIR PROFESOR
		private void Añadir_Profe_Click(object sender, EventArgs e)
		{   
            //abrimos y mostramos el fomulario
            AñadirProfe an = new AñadirProfe();
            an.Show();
		}
	}
}
