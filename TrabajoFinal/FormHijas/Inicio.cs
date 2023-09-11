using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TrabajoFinal.FormHijas
{
    public partial class Inicio : Form
    {
        //Conexion a la bd de SQL server
        private string connectionString = "Data Source=DESKTOP-2QR1BR7\\SQLEXPRESS;Initial Catalog=BD_IE_CM;Integrated Security=True;User ID=DESKTOP-2QR1BR7\\Equipo";
        private SqlConnection conn;

        public Inicio()
        {
            InitializeComponent();

            ChartArea radarArea = new ChartArea("RadarArea");//Creamos un chart para mostrar un radar
            Prestigio.ChartAreas.Add(radarArea); //agregamos
            Prestigio.Height = 350; //le damos una altura
            Series radarSeries = new Series("Prestigio");// creamos una serie que seria como la leyenda
            radarSeries.Color = Color.Salmon;//le damos color al radar
            radarSeries.IsValueShownAsLabel = true;//hacermos visbles los valores en las q esta
            Prestigio.Series.Add(radarSeries);//Agregamos la serie
            double[] valores = { 100, 100, 100, 100, 100 };//creamos los valores q se cargaran al radar
            radarSeries.Points.DataBindY(valores); //se cargan los valores
            radarSeries.ChartType = SeriesChartType.Radar;//selecionamos el tipo de radar
            Prestigio.Invalidate();//actualiza el radarya con los datos

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

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

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@Nivel", nivelQueries.ElementAt(i).Value);
                            int count = (int)command.ExecuteScalar();

                            DataPoint dataPoint = new DataPoint();
                            dataPoint.SetValueY(count);
                            dataPoint.IsValueShownAsLabel = true;
                            dataPoint.Label = nivel; // Mostrar solo el nivel en la leyenda
                            dataPoint.Color = colors[i]; // Asignar un color específico

                            series2.Points.Add(dataPoint);
                        }
                    }

                    Cantidad.Series.Add(series2);
                }

            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
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
