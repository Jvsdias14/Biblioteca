using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairMenuSuspenso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void gêneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenero oFrmGenero = new FrmGenero();
            oFrmGenero.MdiParent = this;
            menuStrip.Enabled = false;
            MenuSuspenso.Enabled = false;
            oFrmGenero.Show();
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAutor oFrmAutor = new FrmAutor();
            oFrmAutor.MdiParent = this;
            menuStrip.Enabled = false;
            MenuSuspenso.Enabled = false;
            oFrmAutor.Show();
        }
        private void editoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditora oFrmEditora = new FrmEditora();
            oFrmEditora.MdiParent = this;
            menuStrip.Enabled = false;
            MenuSuspenso.Enabled = false;
            oFrmEditora.Show();
        }

        private void idiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIdioma oFrmIdioma = new FrmIdioma();
            oFrmIdioma.MdiParent = this;
            menuStrip.Enabled = false;
            MenuSuspenso.Enabled = false;
            oFrmIdioma.Show();
        }
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario oFrmUsuario = new FrmUsuario();
            oFrmUsuario.MdiParent = this;
            menuStrip.Enabled = false;
            MenuSuspenso.Enabled = false;
            oFrmUsuario.Show();
        }

    }

}
