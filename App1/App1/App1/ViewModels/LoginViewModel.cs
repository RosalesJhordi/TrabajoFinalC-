using App1.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1.ViewModels
{
	public class LoginViewModel : BaseViewModel
	{
		private void ExecuteLogin()
		{
			// Por ejemplo, puedes mostrarlos en la consola de depuración
			System.Diagnostics.Debug.WriteLine($"Username:");
		}
		//control para mostrar contraseña
		private bool isPwdVisible;
		public bool IsPwdVisible
		{
			get { return isPwdVisible; }
			set
			{
				isPwdVisible = value;
				OnPropertyChanged(nameof(IsPwdVisible));
			}
		}

		private void OnCheckBoxCheckedChanged(bool isChecked)
		{
			IsPwdVisible = isChecked; // contraseña visible
		}

	}
}
