namespace ProjetoPimUnip2023Psemestre
{
    partial class alteracao_funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alteracao_funcionario));
            this.lblFechar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tctAlterCep = new System.Windows.Forms.TextBox();
            this.alterCidade = new System.Windows.Forms.TextBox();
            this.alterBairro = new System.Windows.Forms.TextBox();
            this.alter_numero_rua_funcionario = new System.Windows.Forms.TextBox();
            this.AlterEmail = new System.Windows.Forms.TextBox();
            this.alterContato = new System.Windows.Forms.TextBox();
            this.alterEndereco = new System.Windows.Forms.TextBox();
            this.nomeFuncionario = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.panelPesquisa = new System.Windows.Forms.Panel();
            this.barraAlteraFuncio = new System.Windows.Forms.ComboBox();
            this.lblPontoHorario = new System.Windows.Forms.Label();
            this.btnPesquisa_Alterar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.alterAgencia = new System.Windows.Forms.ComboBox();
            this.alterCargo = new System.Windows.Forms.ComboBox();
            this.alterDepartamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AlterContabanco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AlterSalario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabConsulta = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisa_Alterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.Color.Red;
            this.lblFechar.Location = new System.Drawing.Point(767, 9);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(21, 20);
            this.lblFechar.TabIndex = 0;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.tctAlterCep);
            this.tabPage2.Controls.Add(this.alterCidade);
            this.tabPage2.Controls.Add(this.alterBairro);
            this.tabPage2.Controls.Add(this.alter_numero_rua_funcionario);
            this.tabPage2.Controls.Add(this.AlterEmail);
            this.tabPage2.Controls.Add(this.alterContato);
            this.tabPage2.Controls.Add(this.alterEndereco);
            this.tabPage2.Controls.Add(this.nomeFuncionario);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.lblN);
            this.tabPage2.Controls.Add(this.panelPesquisa);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnConfirmar);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alterar informações";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tctAlterCep
            // 
            this.tctAlterCep.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctAlterCep.Location = new System.Drawing.Point(537, 126);
            this.tctAlterCep.Name = "tctAlterCep";
            this.tctAlterCep.Size = new System.Drawing.Size(204, 26);
            this.tctAlterCep.TabIndex = 66;
            // 
            // alterCidade
            // 
            this.alterCidade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterCidade.Location = new System.Drawing.Point(537, 193);
            this.alterCidade.Name = "alterCidade";
            this.alterCidade.Size = new System.Drawing.Size(204, 26);
            this.alterCidade.TabIndex = 64;
            // 
            // alterBairro
            // 
            this.alterBairro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterBairro.Location = new System.Drawing.Point(292, 193);
            this.alterBairro.Name = "alterBairro";
            this.alterBairro.Size = new System.Drawing.Size(167, 26);
            this.alterBairro.TabIndex = 62;
            // 
            // alter_numero_rua_funcionario
            // 
            this.alter_numero_rua_funcionario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alter_numero_rua_funcionario.Location = new System.Drawing.Point(637, 161);
            this.alter_numero_rua_funcionario.Name = "alter_numero_rua_funcionario";
            this.alter_numero_rua_funcionario.Size = new System.Drawing.Size(104, 26);
            this.alter_numero_rua_funcionario.TabIndex = 51;
            // 
            // AlterEmail
            // 
            this.AlterEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlterEmail.Location = new System.Drawing.Point(292, 91);
            this.AlterEmail.Name = "AlterEmail";
            this.AlterEmail.Size = new System.Drawing.Size(405, 26);
            this.AlterEmail.TabIndex = 46;
            // 
            // alterContato
            // 
            this.alterContato.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterContato.Location = new System.Drawing.Point(292, 126);
            this.alterContato.Name = "alterContato";
            this.alterContato.Size = new System.Drawing.Size(189, 26);
            this.alterContato.TabIndex = 44;
            // 
            // alterEndereco
            // 
            this.alterEndereco.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterEndereco.Location = new System.Drawing.Point(292, 161);
            this.alterEndereco.Name = "alterEndereco";
            this.alterEndereco.Size = new System.Drawing.Size(303, 26);
            this.alterEndereco.TabIndex = 42;
            // 
            // nomeFuncionario
            // 
            this.nomeFuncionario.Enabled = false;
            this.nomeFuncionario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeFuncionario.Location = new System.Drawing.Point(292, 59);
            this.nomeFuncionario.Name = "nomeFuncionario";
            this.nomeFuncionario.Size = new System.Drawing.Size(405, 26);
            this.nomeFuncionario.TabIndex = 40;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(493, 129);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 20);
            this.label20.TabIndex = 65;
            this.label20.Text = "CEP:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(465, 199);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 20);
            this.label18.TabIndex = 63;
            this.label18.Text = "Cidade:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(203, 196);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 20);
            this.label19.TabIndex = 61;
            this.label19.Text = "Bairro:";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(601, 167);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(30, 20);
            this.lblN.TabIndex = 50;
            this.lblN.Text = "N°:";
            // 
            // panelPesquisa
            // 
            this.panelPesquisa.BackColor = System.Drawing.Color.LightCyan;
            this.panelPesquisa.Controls.Add(this.barraAlteraFuncio);
            this.panelPesquisa.Controls.Add(this.lblPontoHorario);
            this.panelPesquisa.Controls.Add(this.btnPesquisa_Alterar);
            this.panelPesquisa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPesquisa.Location = new System.Drawing.Point(3, 3);
            this.panelPesquisa.Name = "panelPesquisa";
            this.panelPesquisa.Size = new System.Drawing.Size(786, 50);
            this.panelPesquisa.TabIndex = 49;
            this.panelPesquisa.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPesquisa_Paint);
            // 
            // barraAlteraFuncio
            // 
            this.barraAlteraFuncio.FormattingEnabled = true;
            this.barraAlteraFuncio.Location = new System.Drawing.Point(233, 7);
            this.barraAlteraFuncio.Name = "barraAlteraFuncio";
            this.barraAlteraFuncio.Size = new System.Drawing.Size(322, 28);
            this.barraAlteraFuncio.TabIndex = 55;
            this.barraAlteraFuncio.SelectedIndexChanged += new System.EventHandler(this.barraAlteraFuncio_SelectedIndexChanged);
            this.barraAlteraFuncio.VisibleChanged += new System.EventHandler(this.barraAlteraFuncio_VisibleChanged);
            // 
            // lblPontoHorario
            // 
            this.lblPontoHorario.AutoSize = true;
            this.lblPontoHorario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontoHorario.Location = new System.Drawing.Point(17, 13);
            this.lblPontoHorario.Name = "lblPontoHorario";
            this.lblPontoHorario.Size = new System.Drawing.Size(210, 22);
            this.lblPontoHorario.TabIndex = 54;
            this.lblPontoHorario.Text = "Pesquisar Funcionário:";
            // 
            // btnPesquisa_Alterar
            // 
            this.btnPesquisa_Alterar.BackColor = System.Drawing.Color.White;
            this.btnPesquisa_Alterar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnPesquisa_Alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisa_Alterar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisa_Alterar.Image")));
            this.btnPesquisa_Alterar.Location = new System.Drawing.Point(550, 7);
            this.btnPesquisa_Alterar.Name = "btnPesquisa_Alterar";
            this.btnPesquisa_Alterar.Size = new System.Drawing.Size(61, 28);
            this.btnPesquisa_Alterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPesquisa_Alterar.TabIndex = 53;
            this.btnPesquisa_Alterar.TabStop = false;
            this.btnPesquisa_Alterar.Click += new System.EventHandler(this.btnPesquisa_Alterar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(388, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 33);
            this.button1.TabIndex = 48;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Green;
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(181, 350);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(164, 33);
            this.btnConfirmar.TabIndex = 47;
            this.btnConfirmar.Text = "Salvar ";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(201, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "E-mail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(201, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "Contato:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(201, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 20);
            this.label13.TabIndex = 41;
            this.label13.Text = "Rua:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(201, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 39;
            this.label14.Text = "Nome:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjetoPimUnip2023Psemestre.Properties.Resources.Imagem_Icone_Funcionario;
            this.pictureBox1.Location = new System.Drawing.Point(24, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.alterAgencia);
            this.panel3.Controls.Add(this.alterCargo);
            this.panel3.Controls.Add(this.alterDepartamento);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.AlterContabanco);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.AlterSalario);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(24, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 111);
            this.panel3.TabIndex = 37;
            // 
            // alterAgencia
            // 
            this.alterAgencia.FormattingEnabled = true;
            this.alterAgencia.Location = new System.Drawing.Point(524, 48);
            this.alterAgencia.Name = "alterAgencia";
            this.alterAgencia.Size = new System.Drawing.Size(161, 28);
            this.alterAgencia.TabIndex = 56;
            // 
            // alterCargo
            // 
            this.alterCargo.FormattingEnabled = true;
            this.alterCargo.Location = new System.Drawing.Point(157, 43);
            this.alterCargo.Name = "alterCargo";
            this.alterCargo.Size = new System.Drawing.Size(233, 28);
            this.alterCargo.TabIndex = 37;
            this.alterCargo.SelectedIndexChanged += new System.EventHandler(this.alterCargo_SelectedIndexChanged);
            this.alterCargo.VisibleChanged += new System.EventHandler(this.alterCargo_VisibleChanged);
            // 
            // alterDepartamento
            // 
            this.alterDepartamento.FormattingEnabled = true;
            this.alterDepartamento.Location = new System.Drawing.Point(157, 8);
            this.alterDepartamento.Name = "alterDepartamento";
            this.alterDepartamento.Size = new System.Drawing.Size(233, 28);
            this.alterDepartamento.TabIndex = 36;
            this.alterDepartamento.SelectedIndexChanged += new System.EventHandler(this.alterDepartamento_SelectedIndexChanged);
            this.alterDepartamento.VisibleChanged += new System.EventHandler(this.alterDepartamento_VisibleChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Cargo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(409, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Agencia:";
            // 
            // AlterContabanco
            // 
            this.AlterContabanco.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlterContabanco.Location = new System.Drawing.Point(525, 13);
            this.AlterContabanco.Name = "AlterContabanco";
            this.AlterContabanco.Size = new System.Drawing.Size(160, 26);
            this.AlterContabanco.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(409, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Conta banco:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Departamento:";
            // 
            // AlterSalario
            // 
            this.AlterSalario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlterSalario.Location = new System.Drawing.Point(157, 77);
            this.AlterSalario.Name = "AlterSalario";
            this.AlterSalario.Size = new System.Drawing.Size(233, 26);
            this.AlterSalario.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Sálario:";
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.tabPage2);
            this.tabConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabConsulta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConsulta.Location = new System.Drawing.Point(0, 40);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.SelectedIndex = 0;
            this.tabConsulta.Size = new System.Drawing.Size(800, 424);
            this.tabConsulta.TabIndex = 1;
            // 
            // alteracao_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.tabConsulta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "alteracao_funcionario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelPesquisa.ResumeLayout(false);
            this.panelPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisa_Alterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabConsulta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tctAlterCep;
        private System.Windows.Forms.TextBox alterCidade;
        private System.Windows.Forms.TextBox alterBairro;
        private System.Windows.Forms.TextBox alter_numero_rua_funcionario;
        private System.Windows.Forms.TextBox AlterEmail;
        private System.Windows.Forms.TextBox alterContato;
        private System.Windows.Forms.TextBox alterEndereco;
        private System.Windows.Forms.TextBox nomeFuncionario;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Panel panelPesquisa;
        private System.Windows.Forms.ComboBox barraAlteraFuncio;
        private System.Windows.Forms.Label lblPontoHorario;
        private System.Windows.Forms.PictureBox btnPesquisa_Alterar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox alterAgencia;
        private System.Windows.Forms.ComboBox alterCargo;
        private System.Windows.Forms.ComboBox alterDepartamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AlterContabanco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AlterSalario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabConsulta;
    }
}