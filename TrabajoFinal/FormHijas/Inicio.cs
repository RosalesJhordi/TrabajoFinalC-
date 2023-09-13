using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TrabajoFinal.Base_Datos;

namespace TrabajoFinal.FormHijas
{
    public partial class Inicio : Form
    {
        //Conexion a la bd de SQL server
        ConexionBD conexion = new ConexionBD();

        public Inicio()
        {
            InitializeComponent();


            ChartArea chartArea = Cantidad.ChartAreas[0];
            chartArea.AxisX.Title = "Alumnos";
            Series series2 = new Series("Series2");
            series2.ChartType = SeriesChartType.Doughnut;
            series2.Palette = ChartColorPalette.SeaGreen; // Paleta de colores para las porciones de la dona
            series2.CustomProperties = "DoughnutRadius=60, PieDrawingStyle=Concave";

            Dictionary<string, string> nivelQueries = new Dictionary<string, string>
            {
                 { "Secundaria", "SECUNDARIA" },
                 { "Primaria", "PRIMARIA" },
                 { "Inicial", "INICIAL" }
            };

            // Definir colores específicos para cada nivel
            Color[] colors = new Color[] { Color.Blue, Color.Red, Color.Green };

            for (int i = 0; i < nivelQueries.Count; i++)
            {
                string nivel = nivelQueries.ElementAt(i).Key;
                string query = "SELECT COUNT(*) FROM Estudiantes WHERE Nivel = @Nivel";

                SqlConnection sqlConnection = conexion.AbrirConexion();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Nivel", nivelQueries.ElementAt(i).Value);
                    int count = (int)command.ExecuteScalar();

                    DataPoint dataPoint = new DataPoint();
                    dataPoint.SetValueY(count);
                    dataPoint.IsValueShownAsLabel = true;
                    dataPoint.Label = nivel; // Mostrar solo el nivel en la leyenda
                    dataPoint.Color = colors[i]; // Asignar un color específico
                    dataPoint.LabelForeColor = Color.White;
                    series2.Points.Add(dataPoint);
                }
            }

            Cantidad.Series.Add(series2);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
        }

        private void HoraFechs_Tick(object sender, EventArgs e)
        {
            //mostramos la hora
            Hora.Text = DateTime.Now.ToString("h:mm:ss");//hora
            fecha.Text = DateTime.Now.ToShortDateString();//fecha
            HoraRegresiva.Text = DateTime.Now.ToString("h:mm");//hora
        }
    }
}
