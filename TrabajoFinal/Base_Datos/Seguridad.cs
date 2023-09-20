using System;

namespace TrabajoFinal.Base_Datos
{
    internal class Seguridad
    {
		// Método para encriptar 
		public static string Encriptar(string cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadenaAencriptar); // La cadena de entrada se convierte en una matriz de bytes
			result = Convert.ToBase64String(encryted); //bytes - base 64 utilizado para repr bynarios 
            return result; //retornamos
        }
		// Método para desencriptar
		public static string Desencriptar(string cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(cadenaAdesencriptar); //conertimos base64 a bytes
            result = System.Text.Encoding.Unicode.GetString(decryted); // los bytes se convierten en string
            return result;
        }
    }
}