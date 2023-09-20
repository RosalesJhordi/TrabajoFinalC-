namespace TrabajoFinal.FomsEstudiante
{
	partial class Tareas
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
			this.Hola = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Contenedor = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// Hola
			// 
			this.Hola.AutoSize = true;
			this.Hola.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Hola.Location = new System.Drawing.Point(23, 23);
			this.Hola.Name = "Hola";
			this.Hola.Size = new System.Drawing.Size(85, 29);
			this.Hola.TabIndex = 0;
			this.Hola.Text = "label1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tareas";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel1.Location = new System.Drawing.Point(29, 98);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(881, 10);
			this.panel1.TabIndex = 2;
			// 
			// Contenedor
			// 
			this.Contenedor.Location = new System.Drawing.Point(28, 123);
			this.Contenedor.Name = "Contenedor";
			this.Contenedor.Size = new System.Drawing.Size(882, 553);
			this.Contenedor.TabIndex = 3;
			// 
			// Tareas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(956, 706);
			this.Controls.Add(this.Contenedor);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Hola);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Tareas";
			this.Text = "Tareas";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Hola;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel Contenedor;
	}
}