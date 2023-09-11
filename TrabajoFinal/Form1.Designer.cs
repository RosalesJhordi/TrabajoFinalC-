namespace TrabajoFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button Restablecer;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Barra_Control = new System.Windows.Forms.Panel();
            this.BtnMini = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOcul = new System.Windows.Forms.PictureBox();
            this.BtnMaxi = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.OFF = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_Soli_Info = new System.Windows.Forms.Button();
            this.BtnMatricula = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Contenedor = new System.Windows.Forms.Panel();
            Restablecer = new System.Windows.Forms.Button();
            this.Barra_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnOcul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Restablecer
            // 
            resources.ApplyResources(Restablecer, "Restablecer");
            Restablecer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            Restablecer.FlatAppearance.BorderSize = 0;
            Restablecer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            Restablecer.ForeColor = System.Drawing.Color.White;
            Restablecer.Name = "Restablecer";
            Restablecer.UseVisualStyleBackColor = false;
            Restablecer.Click += new System.EventHandler(this.Restablecer_Click);
            // 
            // Barra_Control
            // 
            this.Barra_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Barra_Control.Controls.Add(this.BtnMini);
            this.Barra_Control.Controls.Add(this.label1);
            this.Barra_Control.Controls.Add(this.BtnOcul);
            this.Barra_Control.Controls.Add(this.BtnMaxi);
            this.Barra_Control.Controls.Add(this.BtnCerrar);
            resources.ApplyResources(this.Barra_Control, "Barra_Control");
            this.Barra_Control.Name = "Barra_Control";
            this.Barra_Control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barra_Control_MouseDown);
            // 
            // BtnMini
            // 
            resources.ApplyResources(this.BtnMini, "BtnMini");
            this.BtnMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMini.Name = "BtnMini";
            this.BtnMini.TabStop = false;
            this.BtnMini.Click += new System.EventHandler(this.BtnMini_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // BtnOcul
            // 
            resources.ApplyResources(this.BtnOcul, "BtnOcul");
            this.BtnOcul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOcul.Name = "BtnOcul";
            this.BtnOcul.TabStop = false;
            this.BtnOcul.Click += new System.EventHandler(this.BtnOcul_Click);
            // 
            // BtnMaxi
            // 
            resources.ApplyResources(this.BtnMaxi, "BtnMaxi");
            this.BtnMaxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaxi.Name = "BtnMaxi";
            this.BtnMaxi.TabStop = false;
            this.BtnMaxi.Click += new System.EventHandler(this.BtnMaxi_Click);
            // 
            // BtnCerrar
            // 
            resources.ApplyResources(this.BtnCerrar, "BtnCerrar");
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(Restablecer);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.OFF);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Btn_Soli_Info);
            this.panel1.Controls.Add(this.BtnMatricula);
            this.panel1.Controls.Add(this.flowLayoutPanel4);
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // OFF
            // 
            resources.ApplyResources(this.OFF, "OFF");
            this.OFF.Name = "OFF";
            this.OFF.TabStop = false;
            this.OFF.Click += new System.EventHandler(this.OFF_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // Btn_Soli_Info
            // 
            this.Btn_Soli_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Soli_Info.FlatAppearance.BorderSize = 0;
            this.Btn_Soli_Info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.Btn_Soli_Info, "Btn_Soli_Info");
            this.Btn_Soli_Info.ForeColor = System.Drawing.Color.White;
            this.Btn_Soli_Info.Name = "Btn_Soli_Info";
            this.Btn_Soli_Info.UseVisualStyleBackColor = false;
            // 
            // BtnMatricula
            // 
            this.BtnMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnMatricula.FlatAppearance.BorderSize = 0;
            this.BtnMatricula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.BtnMatricula, "BtnMatricula");
            this.BtnMatricula.ForeColor = System.Drawing.Color.White;
            this.BtnMatricula.Name = "BtnMatricula";
            this.BtnMatricula.UseVisualStyleBackColor = false;
            this.BtnMatricula.Click += new System.EventHandler(this.BtnMatricula_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.flowLayoutPanel4, "flowLayoutPanel4");
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.BtnLogin, "BtnLogin");
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Contenedor, "Contenedor");
            this.Contenedor.Name = "Contenedor";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Barra_Control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Barra_Control.ResumeLayout(false);
            this.Barra_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnOcul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Barra_Control;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnMini;
        private System.Windows.Forms.PictureBox BtnOcul;
        private System.Windows.Forms.PictureBox BtnMaxi;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btn_Soli_Info;
        private System.Windows.Forms.Button BtnMatricula;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.PictureBox OFF;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

