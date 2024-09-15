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


namespace SistemaBiblioteca.Model
{
    public class Genero
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

        public static List<Genero> ListarTodos()
        {
            using (var conexao = DataHelper.Conexao())
            {
                List<Genero>Retorno = new List<Genero>();
                string SQL = "select * from genero";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Genero oGenero = new Genero();
                    oGenero.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oGenero.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oGenero);

                }
                oDr.Close();
                return Retorno;
            }
            
            //return (from p in DataHelper.ListaGenero select p).ToList();
        }

        public static Genero? Seleciona(int Codigo)
        {
            return (from p in DataHelper.ListaGenero where p.Id == Codigo select p).FirstOrDefault();
        }

        public static Genero? SelecionaNome(Genero oGenero)
        {
            return (from p in DataHelper.ListaGenero where p.Nome == oGenero.Nome select p).FirstOrDefault();
        }
        public static void IncluirGeneroStatico(Genero oGenero) { 
            DataHelper.ListaGenero.Add(oGenero); 
        }
        public void Incluir() {
            using (var conexao = DataHelper.Conexao())
            {
                string SQL = $"insert into genero values ('{this.Nome.Replace("'","")}')";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                comando.ExecuteNonQuery();
            }
            //if (Seleciona(this.Id) != null)
            //{
            //    throw new Exception($"O código está sendo utilizado no gênero {Seleciona(this.Id).Nome}");
            //}
            //else
            //{
            //    DataHelper.ListaGenero.Add(this);
            //}
        }
        public static void Alterar(Genero oGenero) 
        {
            using (var conexao = DataHelper.Conexao())
            {
                string SQL = $"update genero set Nome = '{oGenero.Nome.Replace("'", "")}' where id={oGenero.Id}";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                comando.ExecuteNonQuery();
            }
            //Genero? GeneroColecao = Seleciona(oGenero.Id);
            //if (GeneroColecao == null)
            //{
            //    throw new Exception($"O objeto informado não exite mais no contexto.");
            //}
            //else if (SelecionaNome(oGenero)!=null)
            //{
            //    throw new Exception($"O Nome já foi utilizado.");
            //}
            //else
            //{
            //    GeneroColecao.Nome = oGenero.Nome;

            //}
        }
        public void Excluir()
        {
            using (var conexao = DataHelper.Conexao())
            {
                string SQL = $"delete from genero where id={this.Id}";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                comando.ExecuteNonQuery();
            }
            //DataHelper.ListaGenero.Remove(this);
        }
        public static List<Genero> SelecionarPorChave(Genero oGenero)
        {
            using (var conexao = DataHelper.Conexao())
            {
                List<Genero> Retorno = new List<Genero>();
                string SQL = $"select * from genero where id = {oGenero.Id}";
                SqlCommand comando = new SqlCommand(SQL, conexao);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Genero oGenero2 = new Genero();
                    oGenero2.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oGenero2.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oGenero2);

                }
                oDr.Close();
                Pesquisar = false;
                return Retorno;
            }

            //return (from p in DataHelper.ListaGenero select p).ToList();
        }
    }


}
