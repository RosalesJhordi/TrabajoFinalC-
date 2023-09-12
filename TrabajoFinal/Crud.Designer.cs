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
            this.Barra_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ON)).BeginInit();
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
            this.Barra_Control.Size = new System.Drawing.Size(1264, 55);
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
            this.OFF.Location = new System.Drawing.Point(1214, 0);
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
            this.label1.Location = new System.Drawing.Point(564, 15);
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
            this.ON.Location = new System.Drawing.Point(1214, 0);
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
            // Crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 699);
            this.Controls.Add(this.Barra_Control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Crud";
            this.Text = "Crud";
            this.Barra_Control.ResumeLayout(false);
            this.Barra_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ON)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Barra_Control;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ON;
        private System.Windows.Forms.PictureBox OFF;
        private System.Windows.Forms.Timer timer1;
    }
}