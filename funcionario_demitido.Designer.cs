namespace ProjetoPimUnip2023Psemestre
{
    partial class funcionario_demitido
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
            this.txtNomee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MotivoDemissao = new System.Windows.Forms.TextBox();
            this.ldlDemissao = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomee
            // 
            this.txtNomee.FormattingEnabled = true;
            this.txtNomee.Location = new System.Drawing.Point(82, 21);
            this.txtNomee.Name = "txtNomee";
            this.txtNomee.Size = new System.Drawing.Size(319, 21);
            this.txtNomee.TabIndex = 9;
            this.txtNomee.SelectedIndexChanged += new System.EventHandler(this.txtNomee_SelectedIndexChanged);
            this.txtNomee.VisibleChanged += new System.EventHandler(this.txtNomee_VisibleChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(19, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome:";
            // 
            // txt_MotivoDemissao
            // 
            this.txt_MotivoDemissao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MotivoDemissao.Location = new System.Drawing.Point(82, 68);
            this.txt_MotivoDemissao.Multiline = true;
            this.txt_MotivoDemissao.Name = "txt_MotivoDemissao";
            this.txt_MotivoDemissao.Size = new System.Drawing.Size(219, 101);
            this.txt_MotivoDemissao.TabIndex = 30;
            this.txt_MotivoDemissao.TextChanged += new System.EventHandler(this.txt_addContato_TextChanged);
            // 
            // ldlDemissao
            // 
            this.ldlDemissao.AutoSize = true;
            this.ldlDemissao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlDemissao.Location = new System.Drawing.Point(12, 68);
            this.ldlDemissao.Name = "ldlDemissao";
            this.ldlDemissao.Size = new System.Drawing.Size(62, 18);
            this.ldlDemissao.TabIndex = 29;
            this.ldlDemissao.Text = "Motivo:";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisa.FlatAppearance.BorderSize = 0;
            this.btnPesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.ForeColor = System.Drawing.Color.White;
            this.btnPesquisa.Location = new System.Drawing.Point(353, 127);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(214, 42);
            this.btnPesquisa.TabIndex = 31;
            this.btnPesquisa.Text = "Comfirma";
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // funcionario_demitido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(604, 201);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txt_MotivoDemissao);
            this.Controls.Add(this.ldlDemissao);
            this.Controls.Add(this.txtNomee);
            this.Controls.Add(this.label2);
            this.Name = "funcionario_demitido";
            this.Text = "funcionario_demitido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtNomee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MotivoDemissao;
        private System.Windows.Forms.Label ldlDemissao;
        private System.Windows.Forms.Button btnPesquisa;
    }
}