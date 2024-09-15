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

namespace SistemaBiblioteca.Model
{
    public class Editora
    {
        //public int Id { get; set; }
        private int _Codigo;
        private string _Nome;
        public int Id
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }
        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }

        public static List<Editora> ListarTodos()
        {
            using (var conexao = DataHelper.Conexao())
            {
                List<Editora> Retorno = new List<Editora>();
                string SQL = "select * from editora";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Editora oEditora = new Editora();
                    oEditora.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oEditora.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oEditora);
                }
                oDr.Close();
                return Retorno;
            }

            //return (from p in DataHelper.ListaEditora select p).ToList();
        }

        public static Editora? Seleciona(int Codigo)
        {
            return (from p in DataHelper.ListaEditora where p.Id == Codigo select p).FirstOrDefault();
        }

        public static Editora? SelecionaNome(Editora oEditora)
        {
            return (from p in DataHelper.ListaEditora where p.Nome == oEditora.Nome select p).FirstOrDefault();
        }

        public static void IncluirEditoraStatico(Editora oEditora)
        {
            DataHelper.ListaEditora.Add(oEditora);
        }

        public void Incluir()
        {
            using (var conexao = DataHelper.Conexao())
            {
                string SQL = $"insert into editora values ('{this.Nome.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                comando.ExecuteNonQuery();
            }
        }

        public static void Alterar(Editora oEditora)
        {
            using (var conexao = DataHelper.Conexao())
            {
                string SQL = $"update editora set Nome = '{oEditora.Nome.Replace("'", "")}' where id={oEditora.Id}";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var conexao = DataHelper.Conexao())
            {
                string SQL = $"delete from editora where id={this.Id}";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                comando.ExecuteNonQuery();
            }
        }

        public static List<Editora> SelecionarPorChave(Editora oEditora)
        {
            using (var conexao = DataHelper.Conexao())
            {
                List<Editora> Retorno = new List<Editora>();
                string SQL = $"select * from editora where id = {oEditora.Id}";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Editora oEditora2 = new Editora();
                    oEditora2.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oEditora2.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oEditora2);
                }
                oDr.Close();
                return Retorno;
            }

            //return (from p in DataHelper.ListaEditora select p).ToList();
        }
    }
}

