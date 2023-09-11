namespace TrabajoFinal.FormHijas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NoVerPwd = new System.Windows.Forms.PictureBox();
            this.VerPwd = new System.Windows.Forms.PictureBox();
            this.input_pwd = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Link_OlvidoPwd = new System.Windows.Forms.LinkLabel();
            this.btn_login = new System.Windows.Forms.Button();
            this.input_email = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoVerPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iniciar sesion";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(370, 49);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(233, 214);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(278, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 43);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 43);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.NoVerPwd);
            this.panel2.Controls.Add(this.VerPwd);
            this.panel2.Controls.Add(this.input_pwd);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(278, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 43);
            this.panel2.TabIndex = 6;
            // 
            // NoVerPwd
            // 
            this.NoVerPwd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NoVerPwd.BackgroundImage")));
            this.NoVerPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NoVerPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoVerPwd.Location = new System.Drawing.Point(356, 0);
            this.NoVerPwd.Name = "NoVerPwd";
            this.NoVerPwd.Size = new System.Drawing.Size(45, 43);
            this.NoVerPwd.TabIndex = 4;
            this.NoVerPwd.TabStop = false;
            this.NoVerPwd.Visible = false;
            this.NoVerPwd.Click += new System.EventHandler(this.NoVerPwd_Click);
            // 
            // VerPwd
            // 
            this.VerPwd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VerPwd.BackgroundImage")));
            this.VerPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VerPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VerPwd.Location = new System.Drawing.Point(356, 0);
            this.VerPwd.Name = "VerPwd";
            this.VerPwd.Size = new System.Drawing.Size(45, 43);
            this.VerPwd.TabIndex = 3;
            this.VerPwd.TabStop = false;
            this.VerPwd.Click += new System.EventHandler(this.VerPwd_Click);
            // 
            // input_pwd
            // 
            this.input_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_pwd.Location = new System.Drawing.Point(54, 1);
            this.input_pwd.Multiline = true;
            this.input_pwd.Name = "input_pwd";
            this.input_pwd.Size = new System.Drawing.Size(296, 40);
            this.input_pwd.TabIndex = 1;
            this.input_pwd.TextChanged += new System.EventHandler(this.input_pwd_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 43);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Link_OlvidoPwd
            // 
            this.Link_OlvidoPwd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Link_OlvidoPwd.AutoSize = true;
            this.Link_OlvidoPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Link_OlvidoPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_OlvidoPwd.Location = new System.Drawing.Point(391, 531);
            this.Link_OlvidoPwd.Name = "Link_OlvidoPwd";
            this.Link_OlvidoPwd.Size = new System.Drawing.Size(203, 20);
            this.Link_OlvidoPwd.TabIndex = 8;
            this.Link_OlvidoPwd.TabStop = true;
            this.Link_OlvidoPwd.Text = "Olvidaste tu Contraseña ?";
            this.Link_OlvidoPwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_OlvidoPwd_LinkClicked);
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_login.BackColor = System.Drawing.Color.Blue;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(409, 460);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(163, 40);
            this.btn_login.TabIndex = 9;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // input_email
            // 
            this.input_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_email.Location = new System.Drawing.Point(330, 296);
            this.input_email.Multiline = true;
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(296, 40);
            this.input_email.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 633);
            this.Controls.Add(this.input_email);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.Link_OlvidoPwd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoVerPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox NoVerPwd;
        private System.Windows.Forms.PictureBox VerPwd;
        private System.Windows.Forms.TextBox input_pwd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel Link_OlvidoPwd;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox input_email;
    }
}