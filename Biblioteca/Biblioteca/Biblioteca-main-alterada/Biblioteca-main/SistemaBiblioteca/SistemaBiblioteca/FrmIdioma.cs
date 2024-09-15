using SistemaBiblioteca.Helper;
using SistemaBiblioteca.Model;
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
    public partial class FrmIdioma : Form
    {

        private bool Incluir = true;
        private bool Pesquisar = false;
        public FrmIdioma()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            if (Pesquisar)
            {
                Idioma oIdioma = new Idioma
                {
                    Id = int.Parse(TxtCodigo.Text)
                };
                dataGridViewIdioma.AutoGenerateColumns = false;
                dataGridViewIdioma.DataSource = Idioma.SelecionarPorChave(oIdioma);
                Pesquisar = false;
            }
            else
            {
                dataGridViewIdioma.AutoGenerateColumns = false;
                dataGridViewIdioma.DataSource = Idioma.ListarTodos();
            }

        }

        private void LimpaControles()
        {
            TxtCodigo.Text = "";
            TxtNome.Text = "";
        }

        private void FrmIdioma_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmMenu)this.MdiParent).menuStrip.Enabled = true;
            ((FrmMenu)this.MdiParent).MenuSuspenso.Enabled = true;
            ((FrmMenu)this.MdiParent).lblStatus.Text = "";
        }

        private void FrmIdioma_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void FrmIdioma_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).lblStatus.Text = "Cadastrando Idioma...";
        }

        private bool ValidaControles()
        {
            if (Pesquisar)
            {
                int Codigo;
                if (TxtCodigo.Text.Trim() == "")
                {
                    MessageBox.Show("O campo código é de preenchimento obrigatório", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCodigo.Focus();
                    return false;
                }
                else if (int.TryParse(TxtCodigo.Text, out Codigo) == false)
                {
                    MessageBox.Show("O campo código não é numérico!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCodigo.Focus();
                    return false;
                }

            }

            else if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("O campo Nome é de preenchimento obrigatório", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNome.Focus();
                return false;
            }

            return true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (Incluir)
            {
                if (ValidaControles())
                {
                    Idioma oIdioma = new Idioma
                    {
                        Nome = TxtNome.Text
                    };

                    try
                    {
                        oIdioma.Incluir();
                        CarregaGrid();
                        LimpaControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigo.Focus();
                    }
                }
            }
            else
            {
                if (ValidaControles())
                {
                    Idioma oIdioma = new Idioma
                    {
                        Id = int.Parse(TxtCodigo.Text),
                        Nome = TxtNome.Text

                    };
                    Idioma.Alterar(oIdioma);
                }
                try
                {

                    CarregaGrid();
                    LimpaControles();
                    Incluir = true;
                    TxtCodigo.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCodigo.Focus();
                }

            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewIdioma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewIdioma.Rows[e.RowIndex].DataBoundItem != null)
            {
                Idioma objselecionado = (Idioma)dataGridViewIdioma.Rows[e.RowIndex].DataBoundItem;
                if (dataGridViewIdioma.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    TxtCodigo.Text = objselecionado.Id.ToString();
                    TxtNome.Text = objselecionado.Nome;
                    TxtCodigo.Enabled = false;
                    TxtNome.Focus();
                    Incluir = false;
                }
                else if (dataGridViewIdioma.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Confirme a exclusão", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objselecionado.Excluir();
                        CarregaGrid();

                    }
                }
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar = true;
            TxtCodigo.Enabled = true;
            if (ValidaControles())
            {
                CarregaGrid();
                LimpaControles();
            }
            else
            {
                Pesquisar = false;
                CarregaGrid();
                LimpaControles();
            }
        }
    }
}
