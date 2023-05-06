namespace ProjetoPimUnip2023Psemestre
{
    partial class Colaboradores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Colaboradores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFecharPainelFuncionario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDemissoes = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnColaboradores = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvListaFuncio = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFuncio)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFecharPainelFuncionario
            // 
            this.btnFecharPainelFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFecharPainelFuncionario.AutoSize = true;
            this.btnFecharPainelFuncionario.Location = new System.Drawing.Point(1140, 9);
            this.btnFecharPainelFuncionario.Name = "btnFecharPainelFuncionario";
            this.btnFecharPainelFuncionario.Size = new System.Drawing.Size(14, 13);
            this.btnFecharPainelFuncionario.TabIndex = 1;
            this.btnFecharPainelFuncionario.Text = "X";
            this.btnFecharPainelFuncionario.Click += new System.EventHandler(this.btnFecharPainelFuncionario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnDemissoes);
            this.panel1.Controls.Add(this.btnColaboradores);
            this.panel1.Controls.Add(this.btnFecharPainelFuncionario);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 70);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDemissoes
            // 
            this.btnDemissoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDemissoes.FlatAppearance.BorderSize = 0;
            this.btnDemissoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDemissoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnDemissoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemissoes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemissoes.ForeColor = System.Drawing.Color.Green;
            this.btnDemissoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDemissoes.ImageIndex = 13;
            this.btnDemissoes.ImageList = this.imageList1;
            this.btnDemissoes.Location = new System.Drawing.Point(286, 0);
            this.btnDemissoes.Name = "btnDemissoes";
            this.btnDemissoes.Size = new System.Drawing.Size(258, 70);
            this.btnDemissoes.TabIndex = 4;
            this.btnDemissoes.Text = "Iniciar nova admissão\r\n";
            this.btnDemissoes.UseVisualStyleBackColor = true;
            this.btnDemissoes.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Imagem_Icone_Funcionario.png");
            this.imageList1.Images.SetKeyName(1, "Imagem_Icone_Holerite.png");
            this.imageList1.Images.SetKeyName(2, "Imagem_Icone_Informação.png");
            this.imageList1.Images.SetKeyName(3, "Imagem_Icone_Lanche.png");
            this.imageList1.Images.SetKeyName(4, "Imagem_Icone_Suporte.png");
            this.imageList1.Images.SetKeyName(5, "Imagem_Icone_X.png");
            this.imageList1.Images.SetKeyName(6, "Imagens_Icone_maximizar.png");
            this.imageList1.Images.SetKeyName(7, "Imagens_Icone_Menu.png");
            this.imageList1.Images.SetKeyName(8, "Imagens_Icone_Minimizar.png");
            this.imageList1.Images.SetKeyName(9, "Imagens_Icone_Ponto.png");
            this.imageList1.Images.SetKeyName(10, "Imagens_Icone_Reduzir_tela.png");
            this.imageList1.Images.SetKeyName(11, "Imagens_Icone_Registro.png");
            this.imageList1.Images.SetKeyName(12, "Imagem_Icone_holerite (2).png");
            this.imageList1.Images.SetKeyName(13, "Imagem_Icone_Funcionarios.png");
            this.imageList1.Images.SetKeyName(14, "Imagem_Icone_Registros.png");
            // 
            // btnColaboradores
            // 
            this.btnColaboradores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColaboradores.FlatAppearance.BorderSize = 0;
            this.btnColaboradores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnColaboradores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnColaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColaboradores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColaboradores.ForeColor = System.Drawing.Color.Blue;
            this.btnColaboradores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColaboradores.ImageIndex = 13;
            this.btnColaboradores.ImageList = this.imageList1;
            this.btnColaboradores.Location = new System.Drawing.Point(23, 0);
            this.btnColaboradores.Name = "btnColaboradores";
            this.btnColaboradores.Size = new System.Drawing.Size(257, 70);
            this.btnColaboradores.TabIndex = 2;
            this.btnColaboradores.Text = "Alterar informções do funcionario\r\n";
            this.btnColaboradores.UseVisualStyleBackColor = true;
            this.btnColaboradores.Click += new System.EventHandler(this.btnColaboradores_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1167, 718);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvListaFuncio);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1167, 663);
            this.panel4.TabIndex = 1;
            // 
            // dgvListaFuncio
            // 
            this.dgvListaFuncio.AllowUserToAddRows = false;
            this.dgvListaFuncio.AllowUserToDeleteRows = false;
            this.dgvListaFuncio.AllowUserToResizeColumns = false;
            this.dgvListaFuncio.AllowUserToResizeRows = false;
            this.dgvListaFuncio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaFuncio.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaFuncio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvListaFuncio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaFuncio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListaFuncio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaFuncio.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListaFuncio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaFuncio.Location = new System.Drawing.Point(0, 0);
            this.dgvListaFuncio.Name = "dgvListaFuncio";
            this.dgvListaFuncio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaFuncio.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dgvListaFuncio.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListaFuncio.Size = new System.Drawing.Size(1167, 663);
            this.dgvListaFuncio.TabIndex = 0;
            this.dgvListaFuncio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaFuncio_CellContentClick);
            this.dgvListaFuncio.VisibleChanged += new System.EventHandler(this.dgvListaFuncio_VisibleChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnPesquisa);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1167, 55);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Holerite do Mes";
            this.dataGridViewImageColumn1.Image = global::ProjetoPimUnip2023Psemestre.Properties.Resources.Imagem_Icon_verficar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Todos";
            this.dataGridViewImageColumn2.Image = global::ProjetoPimUnip2023Psemestre.Properties.Resources.Imagem_Icon_Pastas;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPesquisa.FlatAppearance.BorderSize = 0;
            this.btnPesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.ForeColor = System.Drawing.Color.White;
            this.btnPesquisa.Location = new System.Drawing.Point(883, 8);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(269, 32);
            this.btnPesquisa.TabIndex = 2;
            this.btnPesquisa.Text = "Pesquisar\r\n";
            this.btnPesquisa.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(314, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Departamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(35, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(439, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(98, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(664, 19);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(178, 21);
            this.comboBox3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(612, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filtro:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 13;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(550, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 70);
            this.button1.TabIndex = 5;
            this.button1.Text = "Iniciar demissão";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Colaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Colaboradores";
            this.Text = "Colaboradores";
            this.Load += new System.EventHandler(this.Colaboradores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFuncio)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label btnFecharPainelFuncionario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnColaboradores;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnDemissoes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvListaFuncio;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}