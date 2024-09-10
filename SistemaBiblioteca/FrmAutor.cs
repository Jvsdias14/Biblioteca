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
    public partial class FrmAutor : Form
    {
        public FrmAutor()
        {
            InitializeComponent();
        }

        private bool Incluir = true;

        private void CarregaGrid()
        {
            dataGridViewAutor.AutoGenerateColumns = false;
            dataGridViewAutor.DataSource = Autor.ListarTodos();
        }

        private void LimpaControles()
        {
            TxtCodigo.Text = "";
            TxtNome.Text = "";
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAutor_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmMenu)this.MdiParent).menuStrip.Enabled = true;
            ((FrmMenu)this.MdiParent).MenuSuspenso.Enabled = true;
            ((FrmMenu)this.MdiParent).lblStatus.Text = "";
        }

        private void FrmAutor_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).lblStatus.Text = "Cadastrando Autor...";
        }

        private void FrmAutor_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private bool ValidaControles()
        {
            int Id;
            if (TxtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("O campo Id é de preenchimento obrigatório", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigo.Focus();
                return false;
            }
            else if (int.TryParse(TxtCodigo.Text, out Id) == false)
            {
                MessageBox.Show("O campo Id não é numérico!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigo.Focus();
                return false;
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
            Autor oAutor = new Autor
            {
                Id = int.Parse(TxtCodigo.Text),
                Nome = TxtNome.Text
            };
            if (Incluir)
            {
                if (ValidaControles())
                {
                    try
                    {
                        oAutor.Incluir();
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
                try
                {
                    Autor.Alterar(oAutor);
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

        private void dataGridViewAutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAutor.Rows[e.RowIndex].DataBoundItem != null)
            {
                Autor objselecionado = (Autor)dataGridViewAutor.Rows[e.RowIndex].DataBoundItem;
                if (dataGridViewAutor.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    TxtCodigo.Text = objselecionado.Id.ToString();
                    TxtNome.Text = objselecionado.Nome;
                    TxtCodigo.Enabled = false;
                    TxtNome.Focus();
                    Incluir = false;
                }
                else if (dataGridViewAutor.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Confirme a exclusão", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objselecionado.Excluir();
                        CarregaGrid();

                    }
                }
            }
        }
    }
}
