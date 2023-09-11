using System;
using System.Data.SqlClient;
using System.Drawing;
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
            radarSeries.Color = Color.Blue;//le damos color al radar
            radarSeries.IsValueShownAsLabel = true;//hacermos visbles los valores en las q esta
            Prestigio.Series.Add(radarSeries);//Agregamos la serie
            double[] valores = { 100, 100, 100, 100, 100 };//creamos los valores q se cargaran al radar
            radarSeries.Points.DataBindY(valores); //se cargan los valores
            radarSeries.ChartType = SeriesChartType.Radar;//selecionamos el tipo de radar
            Prestigio.Invalidate();//actualiza el radarya con los datos

            try
            {
                conn = new SqlConnection(connectionString); //creamos la conexion a la bd
                conn.Open(); //abrimos la conexion

                // Consulta SQL para contar estudiantes de secundaria
                string querySecundaria = "SELECT COUNT(*) FROM Estudiante WHERE Nivel = 'SECUNDARIA'";
                // Consulta SQL para contar estudiantes de primaria
                string queryPrimaria = "SELECT COUNT(*) FROM Estudiante WHERE Nivel = 'PRIMARIA'";

                using (SqlCommand commandSecundaria = new SqlCommand(querySecundaria, conn))
                using (SqlCommand commandPrimaria = new SqlCommand(queryPrimaria, conn))
                {
                    int countSecundaria = (int)commandSecundaria.ExecuteScalar(); // Estudiantes de secundaria
                    int countPrimaria = (int)commandPrimaria.ExecuteScalar(); // Estudiantes de primaria

                    // Configurar el gráfico
                    ChartArea chartArea = Cantidad.ChartAreas[0];
                    chartArea.AxisX.Title = "Nivel Académico";

                    // Crear una serie de datos
                    Series series2 = new Series("Series2");
                    series2.ChartType = SeriesChartType.Doughnut;
                    series2.IsValueShownAsLabel = true;

                    // Configurar los colores de las secciones
                    series2.Palette = ChartColorPalette.SeaGreen;
                    series2.CustomProperties = "DoughnutRadius=60, PieDrawingStyle=Concave";

                    // Agregar puntos al gráfico con las cantidades y colores adecuados
                    DataPoint dataPointSecundaria = new DataPoint();
                    dataPointSecundaria.SetValueY(countSecundaria);
                    dataPointSecundaria.Label = "Secundaria";

                    DataPoint dataPointPrimaria = new DataPoint();
                    dataPointPrimaria.SetValueY(countPrimaria);
                    dataPointPrimaria.Label = "Primaria";

                    DataPoint dataPointInicial = new DataPoint();
                    dataPointInicial.SetValueY(countPrimaria);
                    dataPointInicial.Label = "Inicial";

                    series2.Points.Add(dataPointSecundaria);
                    series2.Points.Add(dataPointPrimaria);
                    series2.Points.Add(dataPointInicial);

                    // Agregar la serie al gráfico
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
