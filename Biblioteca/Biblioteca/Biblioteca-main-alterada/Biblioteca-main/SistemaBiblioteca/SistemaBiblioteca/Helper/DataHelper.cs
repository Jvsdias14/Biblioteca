using SistemaBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace SistemaBiblioteca.Helper
{
    public static class DataHelper
    {
        public static List<Genero> ListaGenero {  get; set; }
        public static List<Autor> ListaAutor { get; set; }
        public static List<Editora> ListaEditora { get; set; }
        public static List<Idioma> ListaIdioma { get; set; }
        public static SqlConnection Conexao()
        {
            string strconnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=biblioteca;Integrated Security=True;TrustServerCertificate=True;";
            SqlConnection conexao = new SqlConnection(strconnection);
            conexao.Open();
            return conexao;

        }

    }
}
