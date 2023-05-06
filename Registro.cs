using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPimUnip2023Psemestre
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void dgvListaFuncio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void abrirFormNoPainel(object formFilho)
        {
            if (this.containerInfoRegistro.Controls.Count > 0)
                this.containerInfoRegistro.Controls.RemoveAt(0);
            Form frm = formFilho as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.containerInfoRegistro.Controls.Add(frm);
            this.containerInfoRegistro.Tag = frm;
            frm.Show();

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void containerInfoRegistro_VisibleChanged(object sender, EventArgs e)
        {
            abrirFormNoPainel(new RegistroFuncionario());
        }
    }
}
