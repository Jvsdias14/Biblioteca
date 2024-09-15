using SistemaBiblioteca.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Model
{
    public class Autor
    {
        private int _Id;
        private string _Nome;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }

        }
        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }

        public static List<Autor> ListarTodos()
        {
            return (from p in DataHelper.ListaAutor select p).ToList();
        }

        public static Autor? Seleciona(int Id)
        {
            return (from p in DataHelper.ListaAutor where p.Id == Id select p).FirstOrDefault();
        }

        public static Autor? SelecionaNome(Autor oAutor)
        {
            return (from p in DataHelper.ListaAutor where p.Nome == oAutor.Nome select p).FirstOrDefault();
        }
        public void Incluir()
        {
            if (Seleciona(this.Id) != null)
            {
                throw new Exception($"O código está sendo utilizado no autor {Seleciona(this.Id).Nome}");
            }
            else
            {
                DataHelper.ListaAutor.Add(this);
            }
        }
        public static void Alterar(Autor oAutor)
        {
            Autor? AutorColecao = Seleciona(oAutor.Id);
            if (AutorColecao == null)
            {
                throw new Exception($"O objeto informado não exite mais no contexto.");
            }
            else if (SelecionaNome(oAutor) != null)
            {
                throw new Exception($"O Nome já foi utilizado.");
            }
            else
            {
                AutorColecao.Nome = oAutor.Nome;

            }
        }
        public void Excluir()
        {
            DataHelper.ListaAutor.Remove(this);
        }
    }

}
