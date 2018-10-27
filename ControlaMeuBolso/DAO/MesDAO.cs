using ControlaMeuBolso.Conexao;
using ControlaMeuBolso.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ControlaMeuBolso.DAO
{
    public class MesDAO
    {

        public List<Mes> buscarMeses()
        {
            string sql = "SELECT * FROM MES";
            List<Mes> listMes = new List<Mes>();

            try
            {
                ConectarComBanco.conectarComBanco();
                SqlCommand command = new SqlCommand(sql, ConectarComBanco.conexao);
                SqlDataReader reader = null;

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Mes mes = new Mes()
                    {
                        mes = reader["mes"].ToString(),
                        IdMes = Convert.ToInt32(reader["idMes"].ToString())
                        
                    };

                    listMes.Add(mes);

                }
            }
            finally
            {
                ConectarComBanco.fecharConexao();
            }

            return listMes;
        }
    }
}
