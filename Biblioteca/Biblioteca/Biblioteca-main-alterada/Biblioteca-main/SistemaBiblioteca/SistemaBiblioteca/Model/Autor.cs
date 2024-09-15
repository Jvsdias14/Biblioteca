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
    public class Autor
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

        public static List<Autor> ListarTodos()
        {
            using (var conexao = DataHelper.Conexao())
            {
                List<Autor> Retorno = new List<Autor>();
                string SQL = "select * from autor";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Autor oAutor = new Autor();
                    oAutor.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oAutor.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oAutor);
                }
                oDr.Close();
                return Retorno;
            }

            //return (from p in DataHelper.ListaAutor select p).ToList();
        }

        public static Autor? Seleciona(int Codigo)
        {
            return (from p in DataHelper.ListaAutor where p.Id == Codigo select p).FirstOrDefault();
        }

        public static Autor? SelecionaNome(Autor oAutor)
        {
            return (from p in DataHelper.ListaAutor where p.Nome == oAutor.Nome select p).FirstOrDefault();
        }

        public static void IncluirAutorStatico(Autor oAutor)
        {
            DataHelper.ListaAutor.Add(oAutor);
        }

        public void Incluir()
        {
            using (var conexao = DataHelper.Conexao())
            {
                string SQL = $"insert into autor values ('{this.Nome.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                comando.ExecuteNonQuery();
            }
        }

        public static void Alterar(Autor oAutor)
        {
            using (var conexao = DataHelper.Conexao())
            {
                string SQL = $"update autor set Nome = '{oAutor.Nome.Replace("'", "")}' where id={oAutor.Id}";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var conexao = DataHelper.Conexao())
            {
                string SQL = $"delete from autor where id={this.Id}";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                comando.ExecuteNonQuery();
            }
        }

        public static List<Autor> SelecionarPorChave(Autor oAutor)
        {
            using (var conexao = DataHelper.Conexao())
            {
                List<Autor> Retorno = new List<Autor>();
                string SQL = $"select * from autor where id = {oAutor.Id}";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Autor oAutor2 = new Autor();
                    oAutor2.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oAutor2.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oAutor2);
                }
                oDr.Close();
                return Retorno;
            }

            //return (from p in DataHelper.ListaAutor select p).ToList();
        }
    }
}
