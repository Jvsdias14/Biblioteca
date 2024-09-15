using Microsoft.Data.SqlClient;
using SistemaBiblioteca.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaBiblioteca.Model
{
    public class Livro
    {
            //public int Id { get; set; }
        private int _Codigo;
        private string _Idioma;
        private string _Genero;   
        private string _Editora;
        private string _ISBN;
        private string _Nome; 
        private string _Descricao;
        private string _Edicao;
        private string _QtdPaginas;
        public int Id
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }
        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }
        public string Idioma { get => _Idioma; set => _Idioma = value.Replace("'", ""); }
        public string Genero { get => _Genero; set => _Genero = value.Replace("'", ""); }
        public string Editora { get => _Editora;set=>_Editora = value.Replace("'",""); }
        public string ISBN { get => _ISBN; set => _ISBN = value.Replace("'", ""); }
        public string Descricao { get => _Descricao; set => _Descricao = value.Replace("'", ""); }
        public string Edicao { get => _Edicao; set => _Edicao = value.Replace("'", ""); }
        public string QtdPaginas { get => _QtdPaginas; set => _QtdPaginas = value.Replace("'", ""); }
        public static List<Livro> ListarTodos()
        {
            using (var conexao = DataHelper.Conexao())
            {
                List<Livro> Retorno = new List<Livro>();
                string SQL = "select * from Livro";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Livro oLivro = new Livro();
                    oLivro.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oLivro.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    oLivro.Idioma = oDr.GetString(oDr.GetOrdinal("Idioma"));
                    oLivro.Genero = oDr.GetString(oDr.GetOrdinal("Genero"));
                    oLivro.Editora = oDr.GetString(oDr.GetOrdinal("Editora"));
                    oLivro.ISBN = oDr.GetString(oDr.GetOrdinal("ISBN"));
                    oLivro.Descricao = oDr.GetString(oDr.GetOrdinal("Descricao"));
                    oLivro.Edicao = oDr.GetString(oDr.GetOrdinal("Edicao"));
                    oLivro.QtdPaginas = oDr.GetString(oDr.GetOrdinal("QtdPaginas"));
                    Retorno.Add(oLivro);
                }
                oDr.Close();
                return Retorno;
            }

            //return (from p in DataHelper.ListaLivro select p).ToList();
        }

        public void Incluir()
        {
            using (var conexao = DataHelper.Conexao())
            {
                string SQL = $"insert into Livro values ('{this.Nome.Replace("'", "")}','{this.Genero.Replace("'", "")}','{this.ISBN.Replace("'", "")}','{this.QtdPaginas.Replace("'", "")},'{this.Descricao.Replace("'", "")}','{this.Edicao.Replace("'", "")}','{this.Idioma.Replace("'", "")}'')";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                comando.ExecuteNonQuery();
            }
        }

        public static void Alterar(Livro oLivro)
        {
            using (var conexao = DataHelper.Conexao())
            {
                string SQL = "UPDATE Livro SET Nome = @Nome, Idioma = @Idioma, Genero = @Genero,Editora = @Editora, Edicao = @Edicao, ISBN = @ISBN, Descricao = @Descricao, Edicao = @Edicao, QtdPaginas = @QtdPaginas, WHERE id = @Id";
                using (SqlCommand comando = new SqlCommand(SQL, conexao))
                {
                    // Adiciona os parâmetros com os valores respectivos
                    comando.Parameters.AddWithValue("@Nome", oLivro.Nome.Replace("'", ""));
                    comando.Parameters.AddWithValue("@Idioma", oLivro.Idioma.Replace("'", ""));
                    comando.Parameters.AddWithValue("@Genero", oLivro.Genero.Replace("'", ""));
                    comando.Parameters.AddWithValue("@Editora", oLivro.Editora.Replace("'", ""));
                    comando.Parameters.AddWithValue("@ISBN", oLivro.ISBN.Replace("'", ""));
                    comando.Parameters.AddWithValue("@Descricao", oLivro.Descricao.Replace("'", ""));
                    comando.Parameters.AddWithValue("@Edicao", oLivro.Edicao.Replace("'", ""));
                    comando.Parameters.AddWithValue("@QtdPaginas", oLivro.QtdPaginas.Replace("'", ""));
                    comando.Parameters.AddWithValue("@Id", oLivro.Id);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir()
        {
            using (var conexao = DataHelper.Conexao())
            {
                string SQL = $"delete from Livro where id={this.Id}";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                comando.ExecuteNonQuery();
            }
        }

        public static List<Livro> SelecionarPorChave(Livro oLivro)
        {
            using (var conexao = DataHelper.Conexao())
            {
                List<Livro> Retorno = new List<Livro>();
                string SQL = $"select * from Livro where id = {oLivro.Id}";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Livro oLivro2 = new Livro();
                    oLivro2.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oLivro2.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    oLivro2.Genero = oDr.GetString(oDr.GetOrdinal("Genero"));
                    oLivro2.Editora = oDr.GetString(oDr.GetOrdinal("Editora"));
                    oLivro2.Idioma = oDr.GetString(oDr.GetOrdinal("Idioma"));
                    oLivro2.ISBN = oDr.GetString(oDr.GetOrdinal("ISBN"));
                    oLivro2.Descricao = oDr.GetString(oDr.GetOrdinal("Descricao"));
                    oLivro2.Edicao = oDr.GetString(oDr.GetOrdinal("Edicao"));
                    oLivro2.QtdPaginas = oDr.GetString(oDr.GetOrdinal("QtdPaginas"));
                    Retorno.Add(oLivro2);
                }
                oDr.Close();
                return Retorno;
            }

            //return (from p in DataHelper.ListaLivro select p).ToList();
        }
    }
}
