namespace ProjetoPimUnip2023Psemestre
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastreSe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(324, 73);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(46, 16);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "LOGIN:";
            this.lblLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(321, 122);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 16);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "SENHA:";
            this.lblSenha.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(273, 141);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(160, 20);
            this.txbSenha.TabIndex = 3;
            this.txbSenha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnConectar
            // 
            this.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConectar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnConectar.Location = new System.Drawing.Point(273, 179);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(67, 33);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "FOLHA DE PAGAMENTO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(273, 92);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(160, 20);
            this.txbLogin.TabIndex = 9;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(358, 179);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 33);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnCadastreSe
            // 
            this.btnCadastreSe.Location = new System.Drawing.Point(307, 218);
            this.btnCadastreSe.Name = "btnCadastreSe";
            this.btnCadastreSe.Size = new System.Drawing.Size(84, 29);
            this.btnCadastreSe.TabIndex = 11;
            this.btnCadastreSe.Text = "Cadastre-se";
            this.btnCadastreSe.UseVisualStyleBackColor = false;
            this.btnCadastreSe.Click += new System.EventHandler(this.btnCadastreSe_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(460, 273);
            this.ControlBox = false;
            this.Controls.Add(this.btnCadastreSe);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadastreSe;
    }
}