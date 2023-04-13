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
            this.lblFuncionarios = new System.Windows.Forms.Label();
            this.btnFecharPainelFuncionario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabFuncionarios = new System.Windows.Forms.TabControl();
            this.tabListaFuncio = new System.Windows.Forms.TabPage();
            this.tabEditarInfoFuncio = new System.Windows.Forms.TabPage();
            this.lblPesquisaFuncionario = new System.Windows.Forms.Label();
            this.txtBarraPesquisaFuncio = new System.Windows.Forms.TextBox();
            this.btnPesquisarFuncio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxFuncionarios = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.TabFuncionarios.SuspendLayout();
            this.tabListaFuncio.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFuncionarios
            // 
            this.lblFuncionarios.AutoSize = true;
            this.lblFuncionarios.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionarios.ForeColor = System.Drawing.Color.White;
            this.lblFuncionarios.Location = new System.Drawing.Point(27, 19);
            this.lblFuncionarios.Name = "lblFuncionarios";
            this.lblFuncionarios.Size = new System.Drawing.Size(129, 23);
            this.lblFuncionarios.TabIndex = 0;
            this.lblFuncionarios.Text = "Funcionarios";
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
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnFecharPainelFuncionario);
            this.panel1.Controls.Add(this.lblFuncionarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 70);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TabFuncionarios
            // 
            this.TabFuncionarios.Controls.Add(this.tabListaFuncio);
            this.TabFuncionarios.Controls.Add(this.tabEditarInfoFuncio);
            this.TabFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabFuncionarios.Location = new System.Drawing.Point(0, 70);
            this.TabFuncionarios.Margin = new System.Windows.Forms.Padding(7);
            this.TabFuncionarios.Name = "TabFuncionarios";
            this.TabFuncionarios.SelectedIndex = 0;
            this.TabFuncionarios.Size = new System.Drawing.Size(1167, 718);
            this.TabFuncionarios.TabIndex = 2;
            // 
            // tabListaFuncio
            // 
            this.tabListaFuncio.BackColor = System.Drawing.Color.White;
            this.tabListaFuncio.Controls.Add(this.panel2);
            this.tabListaFuncio.Controls.Add(this.listBoxFuncionarios);
            this.tabListaFuncio.Controls.Add(this.button3);
            this.tabListaFuncio.Controls.Add(this.button2);
            this.tabListaFuncio.Controls.Add(this.button1);
            this.tabListaFuncio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabListaFuncio.Location = new System.Drawing.Point(4, 22);
            this.tabListaFuncio.Name = "tabListaFuncio";
            this.tabListaFuncio.Padding = new System.Windows.Forms.Padding(7);
            this.tabListaFuncio.Size = new System.Drawing.Size(1159, 692);
            this.tabListaFuncio.TabIndex = 0;
            this.tabListaFuncio.Text = "Lista Funcioários";
            // 
            // tabEditarInfoFuncio
            // 
            this.tabEditarInfoFuncio.BackColor = System.Drawing.Color.White;
            this.tabEditarInfoFuncio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEditarInfoFuncio.Location = new System.Drawing.Point(4, 22);
            this.tabEditarInfoFuncio.Name = "tabEditarInfoFuncio";
            this.tabEditarInfoFuncio.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditarInfoFuncio.Size = new System.Drawing.Size(192, 74);
            this.tabEditarInfoFuncio.TabIndex = 1;
            this.tabEditarInfoFuncio.Text = "Editar informções dos funcionarios";
            // 
            // lblPesquisaFuncionario
            // 
            this.lblPesquisaFuncionario.AutoSize = true;
            this.lblPesquisaFuncionario.Location = new System.Drawing.Point(3, 11);
            this.lblPesquisaFuncionario.Name = "lblPesquisaFuncionario";
            this.lblPesquisaFuncionario.Size = new System.Drawing.Size(207, 22);
            this.lblPesquisaFuncionario.TabIndex = 0;
            this.lblPesquisaFuncionario.Text = "Pesquisar funcionario:";
            // 
            // txtBarraPesquisaFuncio
            // 
            this.txtBarraPesquisaFuncio.Location = new System.Drawing.Point(7, 35);
            this.txtBarraPesquisaFuncio.Name = "txtBarraPesquisaFuncio";
            this.txtBarraPesquisaFuncio.Size = new System.Drawing.Size(677, 31);
            this.txtBarraPesquisaFuncio.TabIndex = 1;
            // 
            // btnPesquisarFuncio
            // 
            this.btnPesquisarFuncio.Location = new System.Drawing.Point(702, 35);
            this.btnPesquisarFuncio.Name = "btnPesquisarFuncio";
            this.btnPesquisarFuncio.Size = new System.Drawing.Size(115, 32);
            this.btnPesquisarFuncio.TabIndex = 2;
            this.btnPesquisarFuncio.Text = "Pesquisar";
            this.btnPesquisarFuncio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(886, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Remover";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(886, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(886, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "Adicionar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listBoxFuncionarios
            // 
            this.listBoxFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFuncionarios.BackColor = System.Drawing.Color.Azure;
            this.listBoxFuncionarios.FormattingEnabled = true;
            this.listBoxFuncionarios.ItemHeight = 22;
            this.listBoxFuncionarios.Location = new System.Drawing.Point(7, 87);
            this.listBoxFuncionarios.Name = "listBoxFuncionarios";
            this.listBoxFuncionarios.Size = new System.Drawing.Size(873, 554);
            this.listBoxFuncionarios.TabIndex = 6;
            this.listBoxFuncionarios.SelectedIndexChanged += new System.EventHandler(this.listBoxFuncionarios_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBarraPesquisaFuncio);
            this.panel2.Controls.Add(this.btnPesquisarFuncio);
            this.panel2.Controls.Add(this.lblPesquisaFuncionario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(7, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1145, 70);
            this.panel2.TabIndex = 7;
            // 
            // Colaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 788);
            this.Controls.Add(this.TabFuncionarios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Colaboradores";
            this.Text = "Colaboradores";
            this.Load += new System.EventHandler(this.Colaboradores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabFuncionarios.ResumeLayout(false);
            this.tabListaFuncio.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFuncionarios;
        private System.Windows.Forms.Label btnFecharPainelFuncionario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl TabFuncionarios;
        private System.Windows.Forms.TabPage tabListaFuncio;
        private System.Windows.Forms.TabPage tabEditarInfoFuncio;
        private System.Windows.Forms.ListBox listBoxFuncionarios;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPesquisarFuncio;
        private System.Windows.Forms.TextBox txtBarraPesquisaFuncio;
        private System.Windows.Forms.Label lblPesquisaFuncionario;
        private System.Windows.Forms.Panel panel2;
    }
}