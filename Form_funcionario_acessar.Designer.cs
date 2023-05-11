namespace ProjetoPimUnip2023Psemestre
{
    partial class Form_funcionario_acessar
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnHoras = new System.Windows.Forms.PictureBox();
            this.btnHorite = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvRegistroHoras = new System.Windows.Forms.DataGridView();
            this.cbEscolherMes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(767, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnHoras
            // 
            this.btnHoras.Image = global::ProjetoPimUnip2023Psemestre.Properties.Resources.Imagens_Icone_Ponto;
            this.btnHoras.Location = new System.Drawing.Point(493, 95);
            this.btnHoras.Name = "btnHoras";
            this.btnHoras.Size = new System.Drawing.Size(130, 123);
            this.btnHoras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHoras.TabIndex = 1;
            this.btnHoras.TabStop = false;
            this.btnHoras.Click += new System.EventHandler(this.btnHoras_Click);
            // 
            // btnHorite
            // 
            this.btnHorite.Image = global::ProjetoPimUnip2023Psemestre.Properties.Resources.Imagem_Icone_Registros;
            this.btnHorite.Location = new System.Drawing.Point(160, 95);
            this.btnHorite.Name = "btnHorite";
            this.btnHorite.Size = new System.Drawing.Size(130, 123);
            this.btnHorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHorite.TabIndex = 2;
            this.btnHorite.TabStop = false;
            this.btnHorite.Click += new System.EventHandler(this.btnHorite_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(183, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Holerite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(460, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Registro de Ponotos";
            // 
            // dgvRegistroHoras
            // 
            this.dgvRegistroHoras.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvRegistroHoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroHoras.Location = new System.Drawing.Point(74, 233);
            this.dgvRegistroHoras.Name = "dgvRegistroHoras";
            this.dgvRegistroHoras.Size = new System.Drawing.Size(626, 189);
            this.dgvRegistroHoras.TabIndex = 5;
            // 
            // cbEscolherMes
            // 
            this.cbEscolherMes.FormattingEnabled = true;
            this.cbEscolherMes.Items.AddRange(new object[] {
            "FEVEREIRO",
            "MARÇO",
            "ABRIL",
            "MAIO"});
            this.cbEscolherMes.Location = new System.Drawing.Point(262, 26);
            this.cbEscolherMes.Name = "cbEscolherMes";
            this.cbEscolherMes.Size = new System.Drawing.Size(108, 21);
            this.cbEscolherMes.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(70, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "SELECIONE O MÊS:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Location = new System.Drawing.Point(561, 440);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(139, 30);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Form_funcionario_acessar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(812, 482);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEscolherMes);
            this.Controls.Add(this.dgvRegistroHoras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHorite);
            this.Controls.Add(this.btnHoras);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_funcionario_acessar";
            this.Text = "Form_funcionario_acessar";
            ((System.ComponentModel.ISupportInitialize)(this.btnHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnHoras;
        private System.Windows.Forms.PictureBox btnHorite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvRegistroHoras;
        private System.Windows.Forms.ComboBox cbEscolherMes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVoltar;
    }
}