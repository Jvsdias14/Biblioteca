using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaBiblioteca.Helper;
using SistemaBiblioteca.Model;

namespace SistemaBiblioteca.Mock
{
    internal class MockDados
    {
        public static void Carrega()
        {
            List<Genero> oLista = new List<Genero> ();
            List<Autor> oLista2 = new List<Autor>();

            for (int i = 1;i < 11; i++)
            {
                Genero oGenero = new Genero();
                Autor oAutor = new Autor();

                oGenero.Id = i;
                oAutor.Id = i;
                oGenero.Nome = $"Genero {i}";
                oAutor.Nome = $"Autor {i}";

                oLista.Add(oGenero);
                oLista2.Add(oAutor);
            }

            DataHelper.ListaGenero = oLista;
            DataHelper.ListaAutor = oLista2;
        }
    }
}
