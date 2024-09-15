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
    public class Usuario
    {
        //public int Id { get; set; }
        private int _Codigo;
        private string _Nome;
        private string _Email;
        private string _Senha;
        private string _Tipo;
        public int Id
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }
        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }
        public string Email { get => _Email; set => _Email = value.Replace("'", ""); }
        public string Senha { get => _Senha; set => _Senha = value.Replace("'", ""); }
        public string Tipo { get => _Tipo; set => _Tipo = value.Replace("'", ""); }

        public static List<Usuario> ListarTodos()
        {
            using (var conexao = DataHelper.Conexao())
            {
                List<Usuario> Retorno = new List<Usuario>();
                string SQL = "select * from Usuario";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Usuario oUsuario = new Usuario();
                    oUsuario.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oUsuario.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    oUsuario.Email = oDr.GetString(oDr.GetOrdinal("Email"));
                    oUsuario.Senha = oDr.GetString(oDr.GetOrdinal("Senha"));
                    oUsuario.Tipo = oDr.GetString(oDr.GetOrdinal("Tipo"));

                    Retorno.Add(oUsuario);
                }
                oDr.Close();
                return Retorno;
            }

            //return (from p in DataHelper.ListaUsuario select p).ToList();
        }

        public void Incluir()
        {
            using (var conexao = DataHelper.Conexao())
            {
                string SQL = $"insert into usuario values ('{this.Nome.Replace("'", "")}','{this.Email.Replace("'", "")}','{this.Senha.Replace("'", "")}','{this.Tipo.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                comando.ExecuteNonQuery();
            }
        }

        public static void Alterar(Usuario oUsuario)
        {
            using (var conexao = DataHelper.Conexao())
            {
                string SQL = "UPDATE usuario SET Nome = @Nome, Email = @Email, Senha = @Senha, Tipo = @Tipo WHERE id = @Id";
                using (SqlCommand comando = new SqlCommand(SQL, conexao))
                {
                    // Adiciona os parâmetros com os valores respectivos
                    comando.Parameters.AddWithValue("@Nome", oUsuario.Nome.Replace("'", ""));
                    comando.Parameters.AddWithValue("@Email", oUsuario.Email.Replace("'", ""));
                    comando.Parameters.AddWithValue("@Senha", oUsuario.Senha.Replace("'", ""));
                    comando.Parameters.AddWithValue("@Tipo", oUsuario.Tipo.Replace("'", ""));
                    comando.Parameters.AddWithValue("@Id", oUsuario.Id); ;
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir()
        {
            using (var conexao = DataHelper.Conexao())
            {
                string SQL = $"delete from usuario where id={this.Id}";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                comando.ExecuteNonQuery();
            }
        }

        public static List<Usuario> SelecionarPorChave(Usuario oUsuario)
        {
            using (var conexao = DataHelper.Conexao())
            {
                List<Usuario> Retorno = new List<Usuario>();
                string SQL = $"select * from usuario where id = {oUsuario.Id}";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Usuario oUsuario2 = new Usuario();
                    oUsuario2.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oUsuario2.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    oUsuario2.Email = oDr.GetString(oDr.GetOrdinal("Email"));
                    oUsuario2.Senha = oDr.GetString(oDr.GetOrdinal("Senha"));
                    oUsuario2.Tipo = oDr.GetString(oDr.GetOrdinal("Tipo"));
                    Retorno.Add(oUsuario2);
                }
                oDr.Close();
                return Retorno;
            }

            //return (from p in DataHelper.ListaUsuario select p).ToList();
        }
    }
}
