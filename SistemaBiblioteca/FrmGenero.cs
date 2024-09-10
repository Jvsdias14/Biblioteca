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
    public partial class FrmGenero : Form
    {

        private bool Incluir = true;
        public FrmGenero()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Genero.ListarTodos();
        }

        private void LimpaControles()
        {
            TxtCodigo.Text = "";
            TxtNome.Text = "";
        }

        private void FrmGenero_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmMenu)this.MdiParent).menuStrip.Enabled = true;
            ((FrmMenu)this.MdiParent).MenuSuspenso.Enabled = true;
            ((FrmMenu)this.MdiParent).lblStatus.Text = "";
        }

        private void FrmGenero_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void FrmGenero_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).lblStatus.Text = "Cadastrando Gênero...";
        }

        private bool ValidaControles()
        {
            //int Codigo;
            //if (TxtCodigo.Text.Trim() == "")
            //{
            //    MessageBox.Show("O campo código é de preenchimento obrigatório", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    TxtCodigo.Focus();
            //    return false;
            //}
            //else if (int.TryParse(TxtCodigo.Text, out Codigo) == false)
            //{
            //    MessageBox.Show("O campo código não é numérico!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    TxtCodigo.Focus();
            //    return false;
            //}
            if (TxtNome.Text.Trim() == "")
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
                    Genero oGenero = new Genero
                    {
                        //Id = int.Parse(TxtCodigo.Text),
                        Nome = TxtNome.Text
                    };

                    try
                    {
                        oGenero.Incluir();
                        //Genero.IncluirGeneroStatico(oGenero);
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
                    Genero oGenero = new Genero
                    {
                        Id = int.Parse(TxtCodigo.Text),
                        Nome = TxtNome.Text
                    };
                    Genero.Alterar(oGenero);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem != null)
            {
                Genero objselecionado = (Genero)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                if (dataGridView1.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    TxtCodigo.Text = objselecionado.Id.ToString();
                    TxtNome.Text = objselecionado.Nome;
                    TxtCodigo.Enabled = false;
                    TxtNome.Focus();
                    Incluir = false;
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "BtnExcluir")
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
            try
            {
                Genero oGenero = new Genero
                {
                    Id = int.Parse(TxtCodigo.Text)
                };
                Genero.SelecionarPorChave(oGenero);
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
}
