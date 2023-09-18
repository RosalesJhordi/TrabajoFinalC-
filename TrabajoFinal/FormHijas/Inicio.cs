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


            ChartArea chartArea = Cantidad.ChartAreas[0];
            chartArea.AxisX.Title = "Alumnos";
            Series series2 = new Series("Series2");
            series2.ChartType = SeriesChartType.Doughnut;
            series2.Palette = ChartColorPalette.SeaGreen; // Paleta de colores para las porciones de la dona
            series2.CustomProperties = "DoughnutRadius=60, PieDrawingStyle=Concave";

			Dictionary<string, string> nivelQueries = new Dictionary<string, string>
			{
				{ "Secundaria", "Secundaria" },
				{ "Primaria", "Primaria" },
				{ "Inicial", "Inicial" }
			};
			Color[] colors = new Color[] { Color.Blue, Color.Red, Color.Green };
			foreach (var nivelQuery in nivelQueries)
			{
				string nivel = nivelQuery.Key;
				string query = "SELECT COUNT(*) FROM Estudiantes WHERE Nivel = @Nivel";
				SQLiteConnection conex = conexion.AbrirConexion();
				using (SQLiteCommand command = new SQLiteCommand(query, conex))
			{
			command.Parameters.AddWithValue("@Nivel", nivelQuery.Value);
			int count = Convert.ToInt32(command.ExecuteScalar());
			
			DataPoint dataPoint = new DataPoint
			{
				YValues = new double[] { count },
				IsValueShownAsLabel = true,
				Label = nivel,
				Color = colors[nivelQueries.Keys.ToList().IndexOf(nivel)],
				LabelForeColor = Color.White
			};
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
            HoraRegresiva.Text = DateTime.Now.ToString("h:mm");//hora
        }
    }
}
