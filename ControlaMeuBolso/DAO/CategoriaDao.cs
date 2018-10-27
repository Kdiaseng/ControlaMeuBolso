using ControlaMeuBolso.Conexao;
using ControlaMeuBolso.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlaMeuBolso.DAO
{
    class CategoriaDao
    {
        public List<Categoria> buscarCategoria(int tipo)
        {
            string sql = "SELECT * FROM CATEGORIA WHERE IDTIPO = @TIPO";
            List <Categoria> lista  = new List<Categoria>();

            try
            {
                SqlDataReader leitor = null;
                ConectarComBanco.conectarComBanco();
                SqlCommand commando = new SqlCommand(sql, ConectarComBanco.conexao);
                commando.Parameters.AddWithValue("@TIPO", tipo);

                leitor = commando.ExecuteReader();

                while (leitor.Read())
                {
                    Categoria categoria = new Categoria()
                    {
                        IdCategoria = leitor.GetInt32(0),
                        Descricao = leitor.GetString(1),
                        Tipo = new Tipo() { IdTipo = leitor.GetInt32(2) }
                        
                    };

                    lista.Add(categoria);               

                }

               
            }
            finally
            {
                ConectarComBanco.fecharConexao();
            }


            return lista;
        }

        public List<Categoria> buscarCategoria()
        {
            string sql = "SELECT * FROM CATEGORIA";
            List<Categoria> lista = new List<Categoria>();

            try
            {
                SqlDataReader leitor = null;
                ConectarComBanco.conectarComBanco();
                SqlCommand commando = new SqlCommand(sql, ConectarComBanco.conexao);
               
                leitor = commando.ExecuteReader();

                while (leitor.Read())
                {
                    Categoria categoria = new Categoria()
                    {
                        IdCategoria = leitor.GetInt32(0),
                        Descricao = leitor.GetString(1),
                       // Tipo = new Tipo() { IdTipo = leitor.GetInt32(2) }

                    };

                    lista.Add(categoria);

                }


            }
            finally
            {
                ConectarComBanco.fecharConexao();
            }


            return lista;
        }


    }
}
