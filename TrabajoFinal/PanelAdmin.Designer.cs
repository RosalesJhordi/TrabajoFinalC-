namespace TrabajoFinal
{
    partial class PanelAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelAdmin));
            this.Barra_Control = new System.Windows.Forms.Panel();
            this.OFF = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ON = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.InputBuscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.Opciones = new System.Windows.Forms.ComboBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_añadir = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.input_nm = new System.Windows.Forms.TextBox();
            this.input_ape = new System.Windows.Forms.TextBox();
            this.input_tel = new System.Windows.Forms.TextBox();
            this.input_dir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OpcionesNivel = new System.Windows.Forms.ComboBox();
            this.btn_verdatos = new System.Windows.Forms.Button();
            this.Barra_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // Barra_Control
            // 
            this.Barra_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Barra_Control.Controls.Add(this.OFF);
            this.Barra_Control.Controls.Add(this.label1);
            this.Barra_Control.Controls.Add(this.ON);
            this.Barra_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_Control.Location = new System.Drawing.Point(0, 0);
            this.Barra_Control.Name = "Barra_Control";
            this.Barra_Control.Size = new System.Drawing.Size(1404, 55);
            this.Barra_Control.TabIndex = 3;
            this.Barra_Control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barra_Control_MouseDown);
            // 
            // OFF
            // 
            this.OFF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OFF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.OFF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OFF.BackgroundImage")));
            this.OFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OFF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OFF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OFF.Location = new System.Drawing.Point(1354, 0);
            this.OFF.Name = "OFF";
            this.OFF.Size = new System.Drawing.Size(47, 52);
            this.OFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OFF.TabIndex = 3;
            this.OFF.TabStop = false;
            this.OFF.Visible = false;
            this.OFF.Click += new System.EventHandler(this.OFF_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(634, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "PANEL ADMINISTRADOR";
            // 
            // ON
            // 
            this.ON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ON.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ON.BackgroundImage")));
            this.ON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ON.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ON.Location = new System.Drawing.Point(1354, 0);
            this.ON.Name = "ON";
            this.ON.Size = new System.Drawing.Size(47, 52);
            this.ON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ON.TabIndex = 0;
            this.ON.TabStop = false;
            this.ON.Click += new System.EventHandler(this.ON_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tabla
            // 
            this.Tabla.AllowUserToOrderColumns = true;
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Location = new System.Drawing.Point(8, 164);
            this.Tabla.Name = "Tabla";
            this.Tabla.RowHeadersWidth = 51;
            this.Tabla.RowTemplate.Height = 24;
            this.Tabla.Size = new System.Drawing.Size(885, 527);
            this.Tabla.TabIndex = 4;
            // 
            // InputBuscar
            // 
            this.InputBuscar.Location = new System.Drawing.Point(8, 82);
            this.InputBuscar.Multiline = true;
            this.InputBuscar.Name = "InputBuscar";
            this.InputBuscar.Size = new System.Drawing.Size(499, 51);
            this.InputBuscar.TabIndex = 5;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.Location = new System.Drawing.Point(529, 86);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(190, 47);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Opciones
            // 
            this.Opciones.FormattingEnabled = true;
            this.Opciones.Location = new System.Drawing.Point(744, 109);
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(149, 24);
            this.Opciones.TabIndex = 7;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.Location = new System.Drawing.Point(8, 721);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(190, 47);
            this.btn_eliminar.TabIndex = 8;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_añadir
            // 
            this.btn_añadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_añadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_añadir.Image = ((System.Drawing.Image)(resources.GetObject("btn_añadir.Image")));
            this.btn_añadir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_añadir.Location = new System.Drawing.Point(948, 644);
            this.btn_añadir.Name = "btn_añadir";
            this.btn_añadir.Size = new System.Drawing.Size(190, 47);
            this.btn_añadir.TabIndex = 10;
            this.btn_añadir.Text = "Añadir";
            this.btn_añadir.UseVisualStyleBackColor = true;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_actualizar.Location = new System.Drawing.Point(1164, 644);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(190, 47);
            this.btn_actualizar.TabIndex = 11;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // input_nm
            // 
            this.input_nm.Location = new System.Drawing.Point(990, 164);
            this.input_nm.Multiline = true;
            this.input_nm.Name = "input_nm";
            this.input_nm.Size = new System.Drawing.Size(360, 44);
            this.input_nm.TabIndex = 12;
            // 
            // input_ape
            // 
            this.input_ape.Location = new System.Drawing.Point(990, 245);
            this.input_ape.Multiline = true;
            this.input_ape.Name = "input_ape";
            this.input_ape.Size = new System.Drawing.Size(360, 44);
            this.input_ape.TabIndex = 13;
            // 
            // input_tel
            // 
            this.input_tel.Location = new System.Drawing.Point(990, 331);
            this.input_tel.Multiline = true;
            this.input_tel.Name = "input_tel";
            this.input_tel.Size = new System.Drawing.Size(360, 44);
            this.input_tel.TabIndex = 14;
            // 
            // input_dir
            // 
            this.input_dir.Location = new System.Drawing.Point(990, 414);
            this.input_dir.Multiline = true;
            this.input_dir.Name = "input_dir";
            this.input_dir.Size = new System.Drawing.Size(360, 44);
            this.input_dir.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(986, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(986, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(986, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(986, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(986, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nivel";
            // 
            // OpcionesNivel
            // 
            this.OpcionesNivel.FormattingEnabled = true;
            this.OpcionesNivel.Location = new System.Drawing.Point(990, 514);
            this.OpcionesNivel.Name = "OpcionesNivel";
            this.OpcionesNivel.Size = new System.Drawing.Size(360, 24);
            this.OpcionesNivel.TabIndex = 22;
            // 
            // btn_verdatos
            // 
            this.btn_verdatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_verdatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verdatos.Image = ((System.Drawing.Image)(resources.GetObject("btn_verdatos.Image")));
            this.btn_verdatos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_verdatos.Location = new System.Drawing.Point(223, 721);
            this.btn_verdatos.Name = "btn_verdatos";
            this.btn_verdatos.Size = new System.Drawing.Size(190, 47);
            this.btn_verdatos.TabIndex = 23;
            this.btn_verdatos.Text = "Ver Datos";
            this.btn_verdatos.UseVisualStyleBackColor = true;
            // 
            // PanelAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 780);
            this.Controls.Add(this.btn_verdatos);
            this.Controls.Add(this.OpcionesNivel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_dir);
            this.Controls.Add(this.input_tel);
            this.Controls.Add(this.input_ape);
            this.Controls.Add(this.input_nm);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_añadir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.Opciones);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.InputBuscar);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.Barra_Control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelAdmin";
            this.Text = "PanelAdmin";
            this.Load += new System.EventHandler(this.PanelAdmin_Load);
            this.Barra_Control.ResumeLayout(false);
            this.Barra_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Barra_Control;
        private System.Windows.Forms.PictureBox OFF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ON;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.TextBox InputBuscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.ComboBox Opciones;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_añadir;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.TextBox input_nm;
        private System.Windows.Forms.TextBox input_ape;
        private System.Windows.Forms.TextBox input_tel;
        private System.Windows.Forms.TextBox input_dir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox OpcionesNivel;
        private System.Windows.Forms.Button btn_verdatos;
    }
}