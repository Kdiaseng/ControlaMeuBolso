using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlaMeuBolso.Conexao
{
    public class ConectarComBanco
    {
        private static string stringConexao = @"server =KALEB_PC; Database = controle_financas; integrated security = true";
        public static SqlConnection conexao = null;

        public static SqlConnection conectarComBanco()
        {
            conexao = new SqlConnection(stringConexao);

            try
            {
                conexao.Open();
            }catch(SqlException ex)
            {
                conexao = null;
                MessageBox.Show("Conexão não estabecida"+ ex.Message, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            return conexao;
        }

        public static void fecharConexao()
        {
            if(conexao!= null)
            {
                conexao.Close();
            }
        }
    

    }
}
