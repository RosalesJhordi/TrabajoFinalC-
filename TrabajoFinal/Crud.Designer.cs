namespace TrabajoFinal
{
    partial class Crud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crud));
            this.Barra_Control = new System.Windows.Forms.Panel();
            this.OFF = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ON = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bD_IE_CMDataSet = new TrabajoFinal.BD_IE_CMDataSet();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteTableAdapter = new TrabajoFinal.BD_IE_CMDataSetTableAdapters.EstudianteTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_buscar = new System.Windows.Forms.TextBox();
            this.btn_anadir = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.Opciones = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Barra_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_IE_CMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
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
            this.Barra_Control.Size = new System.Drawing.Size(1275, 55);
            this.Barra_Control.TabIndex = 2;
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
            this.OFF.Location = new System.Drawing.Point(1225, 0);
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
            this.label1.Location = new System.Drawing.Point(569, 15);
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
            this.ON.Location = new System.Drawing.Point(1225, 0);
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.nivelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.estudianteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 511);
            this.dataGridView1.TabIndex = 3;
            // 
            // bD_IE_CMDataSet
            // 
            this.bD_IE_CMDataSet.DataSetName = "BD_IE_CMDataSet";
            this.bD_IE_CMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataMember = "Estudiante";
            this.estudianteBindingSource.DataSource = this.bD_IE_CMDataSet;
            // 
            // estudianteTableAdapter
            // 
            this.estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // nivelDataGridViewTextBoxColumn
            // 
            this.nivelDataGridViewTextBoxColumn.DataPropertyName = "Nivel";
            this.nivelDataGridViewTextBoxColumn.HeaderText = "Nivel";
            this.nivelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nivelDataGridViewTextBoxColumn.Name = "nivelDataGridViewTextBoxColumn";
            this.nivelDataGridViewTextBoxColumn.Width = 125;
            // 
            // input_buscar
            // 
            this.input_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_buscar.Location = new System.Drawing.Point(58, 92);
            this.input_buscar.Multiline = true;
            this.input_buscar.Name = "input_buscar";
            this.input_buscar.Size = new System.Drawing.Size(633, 42);
            this.input_buscar.TabIndex = 4;
            this.input_buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_anadir
            // 
            this.btn_anadir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_anadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_anadir.Location = new System.Drawing.Point(1103, 186);
            this.btn_anadir.Name = "btn_anadir";
            this.btn_anadir.Size = new System.Drawing.Size(160, 42);
            this.btn_anadir.TabIndex = 6;
            this.btn_anadir.Text = "Añadir";
            this.btn_anadir.UseVisualStyleBackColor = true;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actualizar.Location = new System.Drawing.Point(1103, 257);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(160, 42);
            this.btn_actualizar.TabIndex = 7;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.Location = new System.Drawing.Point(1103, 329);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(160, 42);
            this.btn_eliminar.TabIndex = 8;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.Location = new System.Drawing.Point(736, 92);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(160, 42);
            this.btn_buscar.TabIndex = 10;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Opciones
            // 
            this.Opciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Opciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Opciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Opciones.FormattingEnabled = true;
            this.Opciones.Location = new System.Drawing.Point(933, 110);
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(153, 24);
            this.Opciones.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(990, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filtrar:";
            // 
            // Crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1275, 699);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Opciones);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_anadir);
            this.Controls.Add(this.input_buscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Barra_Control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Crud";
            this.Text = "Crud";
            this.Load += new System.EventHandler(this.Crud_Load);
            this.Barra_Control.ResumeLayout(false);
            this.Barra_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_IE_CMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Barra_Control;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ON;
        private System.Windows.Forms.PictureBox OFF;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BD_IE_CMDataSet bD_IE_CMDataSet;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private BD_IE_CMDataSetTableAdapters.EstudianteTableAdapter estudianteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox input_buscar;
        private System.Windows.Forms.Button btn_anadir;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.ComboBox Opciones;
        private System.Windows.Forms.Label label2;
    }
}