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
        public static SqlConnection Conexao()
        {
            string strconnection = "Data Source=JVSDIAS\\SQLEXPRESS;Initial Catalog = Biblioteca;Integrated Security=True;Connect Timeout=30;Trust Server Certificate=True;Application Intent=ReadWrite";
            SqlConnection conexao = new SqlConnection(strconnection);
            conexao.Open();
            return conexao;

        }

    }
}
