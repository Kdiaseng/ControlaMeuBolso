using ControlaMeuBolso.Conexao;
using ControlaMeuBolso.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControlaMeuBolso.DAO
{
    public class FinancasDAO
    {

        public double BuscarValoresFinanceiros(int tipo,Boolean Ispendente)
        {
            double valor = 0;
            string sql = null;

            if (Ispendente)
            {
                sql = "SELECT SUM (CUSTO) AS CUSTOS_REDIMENTOS FROM Financas WHERE TIPO = @tipo  AND dataCadastro IS NULL";
            }
            else
            {
                sql = "SELECT SUM (CUSTO) AS CUSTOS_REDIMENTOS FROM Financas WHERE TIPO = @tipo  AND dataCadastro IS NOT NULL";
            }

            try
            {
                ConectarComBanco.conectarComBanco();

                SqlDataReader leitor;
                SqlCommand comando = new SqlCommand(sql, ConectarComBanco.conexao);
                comando.Parameters.AddWithValue("@tipo", tipo);

                leitor = comando.ExecuteReader();
                leitor.Read();
                valor = Convert.ToDouble(leitor["CUSTOS_REDIMENTOS"]);
                return valor;

            }
            catch
            {

            }
            finally
            {
                ConectarComBanco.fecharConexao();
            }

            return valor;

        }

        public List<Financas> buscarDispesas()
        {
            List<Financas> lista = new List<Financas>();
            SqlCommand command;
            SqlDataReader dataReader;

            try
            {
                ConectarComBanco.conectarComBanco();
                string sql = "SELECT CATEGORIA.DESCRICAO, custo, dataCadastro FROM FINANCAS JOIN CATEGORIA  ON CATEGORIA.IDCATEGORIA = FINANCAS.IDCATEGORIA WHERE 1=1 AND tipo =2 AND FINANCAS.idMes = 10";
               command = new SqlCommand(sql, ConectarComBanco.conexao);

                dataReader = command.ExecuteReader();

                if (dataReader != null)
                {
                    while (dataReader.Read())
                    {
                        Financas financas = new Financas()
                        {
                            categoria = new Categoria()
                            {
                                Descricao = Convert.ToString(dataReader["DESCRICAO"]),

                            },
                            Custo = Convert.ToDouble(dataReader["CUSTO"]),
                            DataCadastro = Convert.ToDateTime(dataReader["dataCadastro"])
                        };

                        lista.Add(financas);
                        
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possivel atualizar os dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                

            }catch(Exception e)
            {

            }
            finally
            {
                ConectarComBanco.fecharConexao();
            }

            return lista;
        }

        public Boolean cadastrarFinancas(Financas financas, Boolean isPendente)
        {
            string sql = null;
            if (isPendente)
            {
                sql = "INSERT INTO FINANCAS(idcategoria, custo, tipo) VALUES(@IDCATEGORIA, @CUSTO, @IDTIPO)";

                try
                {
                    ConectarComBanco.conectarComBanco();
                    SqlCommand command = new SqlCommand(sql, ConectarComBanco.conexao);
                    command.Parameters.AddWithValue("@IDCATEGORIA", financas.categoria.IdCategoria);
                    command.Parameters.AddWithValue("@CUSTO", financas.Custo);
                    command.Parameters.AddWithValue("@IDTIPO", financas.tipo.IdTipo);

                    var linhasModificadas = command.ExecuteNonQuery();

                    return true;
                }
                catch
                {

                }
                finally
                {
                    ConectarComBanco.fecharConexao();
                }

                return false;
            }
            else
            {
                sql = "INSERT INTO FINANCAS (idcategoria,custo,datacadastro,tipo,idMes) VALUES (@IDCATEGORIA, @CUSTO,@DATACADASTRO,@IDTIPO,@IDMES)";

                try
                {
                    ConectarComBanco.conectarComBanco();
                    SqlCommand command = new SqlCommand(sql, ConectarComBanco.conexao);
                    command.Parameters.AddWithValue("@IDCATEGORIA",financas.categoria.IdCategoria);
                    command.Parameters.AddWithValue("@CUSTO", financas.Custo);
                    command.Parameters.AddWithValue("@DATACADASTRO", financas.DataCadastro);
                    command.Parameters.AddWithValue("@IDTIPO", financas.tipo.IdTipo);
                    command.Parameters.AddWithValue("@IDMES", financas.mes.IdMes);


                    var linhasModificadas = command.ExecuteNonQuery();

                    return true;

                }
                catch
                {

                }
                finally
                {
                    ConectarComBanco.fecharConexao();
                }

                return false;
            }


        }

        public List<Financas> SP_BUSCA_FINACAS(int idMes, int financasRedimetoCusto, int idCategoria)
        {
            List<Financas> Listfinancas = new List<Financas>();
          
            
            try
            {
                         
          
                ConectarComBanco.conectarComBanco();          
                SqlCommand command = new SqlCommand("SP_BUSCA_FINACAS", ConectarComBanco.conexao);
                SqlDataReader reader = null;
                command.Parameters.AddWithValue("@mes", idMes);
                command.Parameters.AddWithValue("@tipoFinancas", financasRedimetoCusto);
                command.Parameters.AddWithValue("@categoria", idCategoria);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                reader = command.ExecuteReader();

                if (idMes != 0)
                {
                    while (reader.Read())
                    {
                        Financas financas = new Financas()
                        {
                            categoria = new Categoria() { Descricao = reader["DESCRICAO"].ToString() },
                            Custo = Convert.ToDouble(reader["custo"].ToString()),
                            DataCadastro = reader.GetDateTime(2)
                        };
                        Listfinancas.Add(financas);
                    }

                }
                else
                {
                    while (reader.Read())
                    {
                        Financas financas = new Financas()
                        {
                            categoria = new Categoria() { Descricao = reader["DESCRICAO"].ToString() },
                            Custo = Convert.ToDouble(reader["custo"].ToString()),
                           // DataCadastro = reader.GetDateTime(2)
                        };
                        Listfinancas.Add(financas);
                    }
                }

               

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ConectarComBanco.fecharConexao();
            }

            return Listfinancas;
        }
    }
}
