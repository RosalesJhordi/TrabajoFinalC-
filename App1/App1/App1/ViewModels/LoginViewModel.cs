using App1.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1.ViewModels
{
	public class LoginViewModel : BaseViewModel
	{

		private string username;
		private string password;

		public string Username
		{
			get { return username; }
			set { SetProperty(ref username, value); }
		}

		public string Password
		{
			get { return password; }
			set { SetProperty(ref password, value); }
		}

		public ICommand LoginCommand { get; }

		public LoginViewModel()
		{
			LoginCommand = new Command(ExecuteLogin);
		}

		private void ExecuteLogin()
		{
			// Aquí obtienes los valores de Username y Password y haces lo que necesites con ellos
			string enteredUsername = Username;
			string enteredPassword = Password;

			// Por ejemplo, puedes mostrarlos en la consola de depuración
			System.Diagnostics.Debug.WriteLine($"Username: {enteredUsername}, Password: {enteredPassword}");
		}
	}
}
