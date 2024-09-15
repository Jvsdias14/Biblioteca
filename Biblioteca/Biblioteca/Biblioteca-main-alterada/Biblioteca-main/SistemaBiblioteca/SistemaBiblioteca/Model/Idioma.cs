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
    public class Idioma
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

        public static List<Idioma> ListarTodos()
        {
            using (var conexao = DataHelper.Conexao())
            {
                List<Idioma> Retorno = new List<Idioma>();
                string SQL = "select * from idioma";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Idioma oIdioma = new Idioma();
                    oIdioma.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oIdioma.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oIdioma);
                }
                oDr.Close();
                return Retorno;
            }

            //return (from p in DataHelper.ListaIdioma select p).ToList();
        }

        public static Idioma? Seleciona(int Codigo)
        {
            return (from p in DataHelper.ListaIdioma where p.Id == Codigo select p).FirstOrDefault();
        }

        public static Idioma? SelecionaNome(Idioma oIdioma)
        {
            return (from p in DataHelper.ListaIdioma where p.Nome == oIdioma.Nome select p).FirstOrDefault();
        }

        public static void IncluirIdiomaStatico(Idioma oIdioma)
        {
            DataHelper.ListaIdioma.Add(oIdioma);
        }

        public void Incluir()
        {
            using (var conexao = DataHelper.Conexao())
            {
                string SQL = $"insert into idioma values ('{this.Nome.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                comando.ExecuteNonQuery();
            }
        }

        public static void Alterar(Idioma oIdioma)
        {
            using (var conexao = DataHelper.Conexao())
            {
                string SQL = $"update idioma set Nome = '{oIdioma.Nome.Replace("'", "")}' where id={oIdioma.Id}";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var conexao = DataHelper.Conexao())
            {
                string SQL = $"delete from idioma where id={this.Id}";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                comando.ExecuteNonQuery();
            }
        }

        public static List<Idioma> SelecionarPorChave(Idioma oIdioma)
        {
            using (var conexao = DataHelper.Conexao())
            {
                List<Idioma> Retorno = new List<Idioma>();
                string SQL = $"select * from idioma where id = {oIdioma.Id}";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Idioma oIdioma2 = new Idioma();
                    oIdioma2.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oIdioma2.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oIdioma2);
                }
                oDr.Close();
                return Retorno;
            }

            //return (from p in DataHelper.ListaIdioma select p).ToList();
        }
    }
}
