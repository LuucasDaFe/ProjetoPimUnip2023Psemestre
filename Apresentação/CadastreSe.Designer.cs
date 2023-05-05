namespace ProjetoPimUnip2023Psemestre.Apresentação
{
    partial class CadastreSe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastreSe));
            this.lblLoginCadastro = new System.Windows.Forms.Label();
            this.lblSenhaCadastro = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txbLoginCadastro = new System.Windows.Forms.TextBox();
            this.txbSenhaCadastro = new System.Windows.Forms.TextBox();
            this.txbConfirmarSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoginCadastro
            // 
            this.lblLoginCadastro.AutoSize = true;
            this.lblLoginCadastro.Location = new System.Drawing.Point(246, 33);
            this.lblLoginCadastro.Name = "lblLoginCadastro";
            this.lblLoginCadastro.Size = new System.Drawing.Size(33, 13);
            this.lblLoginCadastro.TabIndex = 0;
            this.lblLoginCadastro.Text = "Login";
            this.lblLoginCadastro.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSenhaCadastro
            // 
            this.lblSenhaCadastro.AutoSize = true;
            this.lblSenhaCadastro.Location = new System.Drawing.Point(246, 75);
            this.lblSenhaCadastro.Name = "lblSenhaCadastro";
            this.lblSenhaCadastro.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaCadastro.TabIndex = 1;
            this.lblSenhaCadastro.Text = "Senha:";
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(246, 122);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(88, 13);
            this.lblConfirmarSenha.TabIndex = 2;
            this.lblConfirmarSenha.Text = "Confirmar Senha:";
            this.lblConfirmarSenha.Click += new System.EventHandler(this.label3_Click);
            // 
            // txbLoginCadastro
            // 
            this.txbLoginCadastro.Location = new System.Drawing.Point(249, 49);
            this.txbLoginCadastro.Name = "txbLoginCadastro";
            this.txbLoginCadastro.Size = new System.Drawing.Size(105, 20);
            this.txbLoginCadastro.TabIndex = 4;
            this.txbLoginCadastro.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txbSenhaCadastro
            // 
            this.txbSenhaCadastro.Location = new System.Drawing.Point(249, 91);
            this.txbSenhaCadastro.Name = "txbSenhaCadastro";
            this.txbSenhaCadastro.Size = new System.Drawing.Size(105, 20);
            this.txbSenhaCadastro.TabIndex = 5;
            // 
            // txbConfirmarSenha
            // 
            this.txbConfirmarSenha.Location = new System.Drawing.Point(249, 138);
            this.txbConfirmarSenha.Name = "txbConfirmarSenha";
            this.txbConfirmarSenha.Size = new System.Drawing.Size(105, 20);
            this.txbConfirmarSenha.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(253, 164);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(81, 31);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastre-se";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // CadastreSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 237);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbConfirmarSenha);
            this.Controls.Add(this.txbSenhaCadastro);
            this.Controls.Add(this.txbLoginCadastro);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.lblSenhaCadastro);
            this.Controls.Add(this.lblLoginCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastreSe";
            this.Text = "CadastreSe";
            this.Load += new System.EventHandler(this.CadastreSe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginCadastro;
        private System.Windows.Forms.Label lblSenhaCadastro;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txbLoginCadastro;
        private System.Windows.Forms.TextBox txbSenhaCadastro;
        private System.Windows.Forms.TextBox txbConfirmarSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadastrar;
    }
}