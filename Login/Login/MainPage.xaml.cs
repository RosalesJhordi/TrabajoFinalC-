using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Login
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
		protected override async void OnAppearing()
		{
			base.OnAppearing();
			collectionView.ItemsSource = await App.Database.GetPeopleAsync();
		}

		async void OnButtonClicked(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(Nombres.Text))
			{
				await App.Database.SavePersonAsync(new Estudiantes
				{
					Nombres = Nombres.Text,
					Apellidos = Apellidos.IsChecked
				});

				Nombres.Text = string.Empty;
				Apellidos.IsChecked = false;

				collectionView.ItemsSource = await App.Database.GetPeopleAsync();
			}
		}
	}
}
