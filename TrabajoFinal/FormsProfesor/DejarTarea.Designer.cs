namespace TrabajoFinal.FormsProfesor
{
	partial class DejarTarea
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
			this.acargo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Contenedor = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.descripcion = new System.Windows.Forms.TextBox();
			this.fecha = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.añadir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// acargo
			// 
			this.acargo.AutoSize = true;
			this.acargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.acargo.Location = new System.Drawing.Point(12, 9);
			this.acargo.Name = "acargo";
			this.acargo.Size = new System.Drawing.Size(70, 25);
			this.acargo.TabIndex = 0;
			this.acargo.Text = "label1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tareas dejadas";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Location = new System.Drawing.Point(17, 78);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(891, 10);
			this.panel1.TabIndex = 2;
			// 
			// Contenedor
			// 
			this.Contenedor.Location = new System.Drawing.Point(17, 107);
			this.Contenedor.Name = "Contenedor";
			this.Contenedor.Size = new System.Drawing.Size(441, 587);
			this.Contenedor.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(495, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(210, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "Descripcion de tarea";
			// 
			// descripcion
			// 
			this.descripcion.Location = new System.Drawing.Point(500, 156);
			this.descripcion.Multiline = true;
			this.descripcion.Name = "descripcion";
			this.descripcion.Size = new System.Drawing.Size(386, 149);
			this.descripcion.TabIndex = 5;
			// 
			// fecha
			// 
			this.fecha.Location = new System.Drawing.Point(500, 376);
			this.fecha.Name = "fecha";
			this.fecha.Size = new System.Drawing.Size(386, 22);
			this.fecha.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(495, 336);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(181, 25);
			this.label3.TabIndex = 7;
			this.label3.Text = "Fecha de entrega";
			// 
			// añadir
			// 
			this.añadir.BackColor = System.Drawing.Color.Lime;
			this.añadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.añadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.añadir.Location = new System.Drawing.Point(566, 584);
			this.añadir.Name = "añadir";
			this.añadir.Size = new System.Drawing.Size(261, 36);
			this.añadir.TabIndex = 8;
			this.añadir.Text = "Añadir tarea";
			this.añadir.UseVisualStyleBackColor = false;
			this.añadir.Click += new System.EventHandler(this.añadir_Click);
			// 
			// DejarTarea
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(956, 706);
			this.Controls.Add(this.añadir);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.fecha);
			this.Controls.Add(this.descripcion);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Contenedor);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.acargo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DejarTarea";
			this.Text = "DejarTarea";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label acargo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel Contenedor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox descripcion;
		private System.Windows.Forms.DateTimePicker fecha;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button añadir;
	}
}