namespace TrabajoFinal.FomsEstudiante
{
	partial class ListTareas
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Contenedor = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// Contenedor
			// 
			this.Contenedor.Location = new System.Drawing.Point(28, 53);
			this.Contenedor.Name = "Contenedor";
			this.Contenedor.Size = new System.Drawing.Size(882, 553);
			this.Contenedor.TabIndex = 4;
			// 
			// ListTareas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(938, 659);
			this.Controls.Add(this.Contenedor);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ListTareas";
			this.Text = "ListTareas";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Contenedor;
	}
}