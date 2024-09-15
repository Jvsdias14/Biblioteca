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
    public partial class FrmLivro : Form
    {

        private bool Incluir = true;
        private bool Pesquisar = false;
        public FrmLivro()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            if (Pesquisar)
            {
                Livro oLivro = new Livro
                {
                    Id = int.Parse(TxtCodigo.Text)
                };
                dataGridViewLivro.AutoGenerateColumns = false;
                dataGridViewLivro.DataSource = Livro.SelecionarPorChave(oLivro);
                Pesquisar = false;
            }
            else
            {
                dataGridViewLivro.AutoGenerateColumns = false;
                dataGridViewLivro.DataSource = Livro.ListarTodos();
            }

        }

        private void LimpaControles()
        {
            TxtCodigo.Text = "";
            TxtNome.Text = "";
            TxtAutor.Text = "";
            TxtEditora.Text = "";
            TxtAno.Text = "";
        }

        private void FrmLivro_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmMenu)this.MdiParent).menuStrip.Enabled = true;
            ((FrmMenu)this.MdiParent).MenuSuspenso.Enabled = true;
            ((FrmMenu)this.MdiParent).lblStatus.Text = "";
        }

        private void FrmLivro_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void FrmLivro_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).lblStatus.Text = "Cadastrando Livro...";
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
                MessageBox.Show("O campo Título é de preenchimento obrigatório", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Livro oLivro = new Livro
                    {
                        Nome = TxtNome.Text,
                        Idioma = TxtIdioma.Text,
                        Editora = TxtEditora.Text,
                        
                    };

                    try
                    {
                        oLivro.Incluir();
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
                    Livro oLivro = new Livro
                    {
                        Id = int.Parse(TxtCodigo.Text),
                        Nome = TxtNome.Text,
                        Autor = TxtAutor.Text,
                        Editora = TxtEditora.Text,
                        Ano = TxtAno.Text
                    };
                    Livro.Alterar(oLivro);
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

        private void dataGridViewLivro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewLivro.Rows[e.RowIndex].DataBoundItem != null)
            {
                Livro objselecionado = (Livro)dataGridViewLivro.Rows[e.RowIndex].DataBoundItem;
                if (dataGridViewLivro.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    TxtCodigo.Text = objselecionado.Id.ToString();
                    TxtNome.Text = objselecionado.Nome;
                    //TxtAutor.Text = objselecionado.Autor;
                    TxtEditora.Text = objselecionado.Editora;
                    TxtAno.Text = objselecionado.Ano;
                    TxtCodigo.Enabled = false;
                    TxtNome.Focus();
                    Incluir = false;
                }
                else if (dataGridViewLivro.Columns[e.ColumnIndex].Name == "BtnExcluir")
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
