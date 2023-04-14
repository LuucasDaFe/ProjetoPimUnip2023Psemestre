namespace ProjetoPimUnip2023Psemestre
{
    partial class Ponto_horarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ponto_horarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFecharPainelFuncionario = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvListaFuncio = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InicioIntervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalIntervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPontoHorario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFuncio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnFecharPainelFuncionario);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 70);
            this.panel1.TabIndex = 3;
            // 
            // btnFecharPainelFuncionario
            // 
            this.btnFecharPainelFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFecharPainelFuncionario.AutoSize = true;
            this.btnFecharPainelFuncionario.Location = new System.Drawing.Point(1073, 9);
            this.btnFecharPainelFuncionario.Name = "btnFecharPainelFuncionario";
            this.btnFecharPainelFuncionario.Size = new System.Drawing.Size(14, 13);
            this.btnFecharPainelFuncionario.TabIndex = 1;
            this.btnFecharPainelFuncionario.Text = "X";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblPontoHorario);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 55);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(758, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(419, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 26);
            this.textBox1.TabIndex = 0;
            // 
            // dgvListaFuncio
            // 
            this.dgvListaFuncio.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaFuncio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvListaFuncio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaFuncio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaFuncio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaFuncio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.HoraInicial,
            this.InicioIntervalo,
            this.FinalIntervalo,
            this.HoraFinal});
            this.dgvListaFuncio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaFuncio.Location = new System.Drawing.Point(0, 125);
            this.dgvListaFuncio.Name = "dgvListaFuncio";
            this.dgvListaFuncio.Size = new System.Drawing.Size(1100, 493);
            this.dgvListaFuncio.TabIndex = 5;
            this.dgvListaFuncio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaFuncio_CellContentClick);
            // 
            // Data
            // 
            this.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.DefaultCellStyle = dataGridViewCellStyle2;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.Width = 200;
            // 
            // HoraInicial
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraInicial.DefaultCellStyle = dataGridViewCellStyle3;
            this.HoraInicial.HeaderText = "Hora incial ";
            this.HoraInicial.Name = "HoraInicial";
            this.HoraInicial.Width = 220;
            // 
            // InicioIntervalo
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InicioIntervalo.DefaultCellStyle = dataGridViewCellStyle4;
            this.InicioIntervalo.HeaderText = "Inicio Intervalo";
            this.InicioIntervalo.Name = "InicioIntervalo";
            this.InicioIntervalo.Width = 220;
            // 
            // FinalIntervalo
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalIntervalo.DefaultCellStyle = dataGridViewCellStyle5;
            this.FinalIntervalo.HeaderText = "Final intervalo";
            this.FinalIntervalo.Name = "FinalIntervalo";
            this.FinalIntervalo.Width = 220;
            // 
            // HoraFinal
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Transparent;
            this.HoraFinal.DefaultCellStyle = dataGridViewCellStyle6;
            this.HoraFinal.HeaderText = "Hora Final";
            this.HoraFinal.Name = "HoraFinal";
            this.HoraFinal.Width = 220;
            // 
            // lblPontoHorario
            // 
            this.lblPontoHorario.AutoSize = true;
            this.lblPontoHorario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontoHorario.Location = new System.Drawing.Point(10, 11);
            this.lblPontoHorario.Name = "lblPontoHorario";
            this.lblPontoHorario.Size = new System.Drawing.Size(401, 22);
            this.lblPontoHorario.TabIndex = 2;
            this.lblPontoHorario.Text = "Pesquisar Horário de ponto do Funcionário:";
            // 
            // Ponto_horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 618);
            this.Controls.Add(this.dgvListaFuncio);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ponto_horarios";
            this.Text = "Ponto_horarios";
            this.Load += new System.EventHandler(this.Ponto_horarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFuncio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btnFecharPainelFuncionario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvListaFuncio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn InicioIntervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalIntervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFinal;
        private System.Windows.Forms.Label lblPontoHorario;
    }
}