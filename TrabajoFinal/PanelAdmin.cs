﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TrabajoFinal.Base_Datos;

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

        //datagrid

        private void CargarDatos()
        {
            try
            {
                SqlConnection sqlConnection = conexion.AbrirConexion();
                string consulta = "SELECT Id,Nombres,Apellidos,Direccion,Nivel FROM Estudiante";
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
                string consulta = "DELETE * FROM Estudiantes WHERE Id = @id";

                using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@id", valorId);
                    int filasEliminadas = sqlCommand.ExecuteNonQuery();// Ejecutar la consulta DELETE

                    if (filasEliminadas > 0)
                    {
                        MessageBox.Show("Registro eliminado correctamente.");
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
    }
}
