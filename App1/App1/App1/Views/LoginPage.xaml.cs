using App1.Droid;
using App1.ViewModels;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
			this.BindingContext = new LoginViewModel();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			Validar(sender, e);
		}
		public bool ValidateEntry()
		{
			bool isValid = !string.IsNullOrEmpty(email.Text) && !string.IsNullOrEmpty(pwd.Text);
			return isValid;
		}
		public SqliteConnection GetConnection()
		{
			var databaseFilename = "BD_IE_CM.db";
			var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			var databasePath = Path.Combine(documentsPath, databaseFilename);

			return new SqliteConnection($"Data Source={databasePath}");
		}


		private void Validar(object sender, EventArgs e)
		{
			if (ValidateEntry())
			{
				string emal = email.Text;
				string contra = pwd.Text;

				string query = "SELECT * FROM Estudiantes WHERE Email = @email and Contrasena = @pwd";

				try
				{
					using (var connection = GetConnection())
					{
						connection.Open();

						using (var command = connection.CreateCommand())
						{
							command.CommandText = query;
							command.Parameters.AddWithValue("@email", emal);
							command.Parameters.AddWithValue("@pwd", contra);

							// Ejecuta la consulta
							using (var reader = command.ExecuteReader())
							{
								if (reader.Read())
								{
									// Autenticación exitosa, obtén los datos del usuario
									string nombres = reader.GetString(reader.GetOrdinal("Nombres"));
									string apellidos = reader.GetString(reader.GetOrdinal("Apellidos"));

									DisplayAlert("Informacion", $"Hola : {nombres}", "Aceptar");
								}
								else
								{
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					DisplayAlert("Error", $"Ocurrió un error: {ex.Message}", "Aceptar");
				}
			}
		}
	}
}