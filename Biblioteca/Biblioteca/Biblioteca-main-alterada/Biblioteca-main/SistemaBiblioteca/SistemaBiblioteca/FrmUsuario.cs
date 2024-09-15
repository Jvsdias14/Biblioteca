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
    public partial class FrmUsuario : Form
    {

        private bool Incluir = true;
        private bool Pesquisar = false;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            if (Pesquisar)
            {
                Usuario oUsuario = new Usuario
                {
                    Id = int.Parse(TxtCodigo.Text)
                };
                dataGridViewUsuario.AutoGenerateColumns = false;
                dataGridViewUsuario.DataSource = Usuario.SelecionarPorChave(oUsuario);
                Pesquisar = false;
            }
            else
            {
                dataGridViewUsuario.AutoGenerateColumns = false;
                dataGridViewUsuario.DataSource = Usuario.ListarTodos();
            }

        }

        private void LimpaControles()
        {
            TxtCodigo.Text = "";
            TxtNome.Text = "";
        }

        private void FrmUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmMenu)this.MdiParent).menuStrip.Enabled = true;
            ((FrmMenu)this.MdiParent).MenuSuspenso.Enabled = true;
            ((FrmMenu)this.MdiParent).lblStatus.Text = "";
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void FrmUsuario_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).lblStatus.Text = "Cadastrando Usuario...";
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
                    Usuario oUsuario = new Usuario
                    {
                        Nome = TxtNome.Text,
                        Email = TxtEmail.Text,
                        Senha = TxtSenha.Text,
                        Tipo = UsuariocomboBox.Text
                    };

                    try
                    {
                        oUsuario.Incluir();
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
                    Usuario oUsuario = new Usuario
                    {
                        Id = int.Parse(TxtCodigo.Text),
                        Nome = TxtNome.Text,
                        Email = TxtEmail.Text,
                        Senha = TxtSenha.Text,
                        Tipo = UsuariocomboBox.Text
                    };
                    Usuario.Alterar(oUsuario);
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

        private void dataGridViewUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUsuario.Rows[e.RowIndex].DataBoundItem != null)
            {
                Usuario objselecionado = (Usuario)dataGridViewUsuario.Rows[e.RowIndex].DataBoundItem;
                if (dataGridViewUsuario.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    TxtCodigo.Text = objselecionado.Id.ToString();
                    TxtNome.Text = objselecionado.Nome;
                    TxtEmail.Text = objselecionado.Email;
                    TxtSenha.Text = objselecionado.Senha;
                    UsuariocomboBox.Text = objselecionado.Tipo;
                    TxtCodigo.Enabled = false;
                    TxtNome.Focus();
                    Incluir = false;
                }
                else if (dataGridViewUsuario.Columns[e.ColumnIndex].Name == "BtnExcluir")
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

