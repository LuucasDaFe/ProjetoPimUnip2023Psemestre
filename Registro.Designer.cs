namespace ProjetoPimUnip2023Psemestre
{
    partial class Registro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHolerite = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnFecharPainelFuncionario = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.containerInfoRegistro = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblHolerite);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnFecharPainelFuncionario);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 70);
            this.panel1.TabIndex = 4;
            // 
            // lblHolerite
            // 
            this.lblHolerite.AutoSize = true;
            this.lblHolerite.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHolerite.Location = new System.Drawing.Point(92, 27);
            this.lblHolerite.Name = "lblHolerite";
            this.lblHolerite.Size = new System.Drawing.Size(210, 19);
            this.lblHolerite.TabIndex = 6;
            this.lblHolerite.Text = "Informações dos Regidtros";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoPimUnip2023Psemestre.Properties.Resources.Imagem_Icone_Registros1;
            this.pictureBox2.Location = new System.Drawing.Point(16, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnFecharPainelFuncionario
            // 
            this.btnFecharPainelFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFecharPainelFuncionario.AutoSize = true;
            this.btnFecharPainelFuncionario.Location = new System.Drawing.Point(1085, 9);
            this.btnFecharPainelFuncionario.Name = "btnFecharPainelFuncionario";
            this.btnFecharPainelFuncionario.Size = new System.Drawing.Size(14, 13);
            this.btnFecharPainelFuncionario.TabIndex = 1;
            this.btnFecharPainelFuncionario.Text = "X";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Funcionario";
            this.dataGridViewImageColumn1.Image = global::ProjetoPimUnip2023Psemestre.Properties.Resources.Imagem_Icone_Funcionario;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // containerInfoRegistro
            // 
            this.containerInfoRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerInfoRegistro.Location = new System.Drawing.Point(0, 70);
            this.containerInfoRegistro.Name = "containerInfoRegistro";
            this.containerInfoRegistro.Size = new System.Drawing.Size(1112, 587);
            this.containerInfoRegistro.TabIndex = 7;
            this.containerInfoRegistro.VisibleChanged += new System.EventHandler(this.containerInfoRegistro_VisibleChanged);
            this.containerInfoRegistro.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1112, 657);
            this.Controls.Add(this.containerInfoRegistro);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHolerite;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label btnFecharPainelFuncionario;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel containerInfoRegistro;
    }
}