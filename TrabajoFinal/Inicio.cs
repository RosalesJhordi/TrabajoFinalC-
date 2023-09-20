using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
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

			// Configuración del área del gráfico
			ChartArea chartArea = Cantidad.ChartAreas[0];
            chartArea.AxisX.Title = "Alumnos"; //titulo

			// nueva serie
            Series series2 = new Series("Series2");
            series2.ChartType = SeriesChartType.Doughnut;// Tipo de gráfico de dona
			series2.Palette = ChartColorPalette.SeaGreen; // Paleta de colores para las porciones de la dona
            series2.CustomProperties = "DoughnutRadius=60, PieDrawingStyle=Concave";

			// Diccionario que mapea niveles y valores
			Dictionary<string, string> nivelQueries = new Dictionary<string, string>
			{
				{ "Secundaria", "Secundaria" },
				{ "Primaria", "Primaria" },
				{ "Inicial", "Inicial" }
			};

			// Arreglo de colores para asignar a cada nivel
			Color[] colors = new Color[] { Color.Blue, Color.Red, Color.Green };

			// Recorre todos los niveles en el diccionario
			foreach (var nivelQuery in nivelQueries)
			{
				string nivel = nivelQuery.Key;// Obtiene el nombre del nivel
				string query = "SELECT COUNT(*) FROM Estudiantes WHERE Nivel = @Nivel";
				SQLiteConnection conex = conexion.AbrirConexion();// Abrir conexion
				using (SQLiteCommand command = new SQLiteCommand(query, conex)) 
				{
					command.Parameters.AddWithValue("@Nivel", nivelQuery.Value);
	
					int count = Convert.ToInt32(command.ExecuteScalar());//ejecuta consulta

					// Crea un punto de datos para la dona
					DataPoint dataPoint = new DataPoint
					{
						YValues = new double[] { count },// Establece el valor
						IsValueShownAsLabel = true,// Muestra el valor 
						Label = nivel, // Etiqueta del nivel (Secundaria, Primaria, Inicial)
						Color = colors[nivelQueries.Keys.ToList().IndexOf(nivel)],// Asigna un color al nivel
						LabelForeColor = Color.White //color de label
					};
					// Agrega datos a la serie
					series2.Points.Add(dataPoint);
				}
			}	

			// Agregar la serie al gráfico
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
            HoraRegresiva.Text = DateTime.Now.ToString("h:mm");//hora 2
        }
    }
}
