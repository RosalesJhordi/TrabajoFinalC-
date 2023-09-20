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
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Contenedor
			// 
			this.Contenedor.Location = new System.Drawing.Point(97, 53);
			this.Contenedor.Name = "Contenedor";
			this.Contenedor.Size = new System.Drawing.Size(717, 553);
			this.Contenedor.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(92, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 25);
			this.label1.TabIndex = 5;
			this.label1.Text = "TAREAS";
			// 
			// ListTareas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(938, 659);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Contenedor);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ListTareas";
			this.Text = "ListTareas";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel Contenedor;
		private System.Windows.Forms.Label label1;
	}
}