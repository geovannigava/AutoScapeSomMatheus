using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Projeto.DataAccess
{
    public class TipoProdutoDataAcess
    {

        public static List<TipoProduto> buscaTipoProdutos()
        {

            List<TipoProduto> tipoProdutos = new List<TipoProduto>();

            string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("select * from tipo_produto order by nome", connection);
                    SqlDataReader dtReader = command.ExecuteReader();
                    while (dtReader.Read())
                    {
                        TipoProduto tipoProduto = new TipoProduto();
                        tipoProduto.id = dtReader.GetInt32(dtReader.GetOrdinal("id"));
                        tipoProduto.nome = dtReader.GetString(dtReader.GetOrdinal("nome"));
                        tipoProdutos.Add(tipoProduto);
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }

            return tipoProdutos;
        }

        public static List<TipoProduto> tipoProdutoPorModel(int codModel)
        {

            List<TipoProduto> tipoProdutos = new List<TipoProduto>();

            string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT p.id_tipo_produto, tp.nome " +
                        " FROM            produto AS p INNER JOIN " +
                        "tipo_produto AS tp ON p.id_tipo_produto = tp.id INNER JOIN " +
                        " produto_modelo AS pm ON pm.id_produto = p.id " +
                        " WHERE        (pm.id_modelo = @CODMODEL) ", connection);
                    command.Parameters.AddWithValue("@CODMODEL", codModel);
                    SqlDataReader dtReader = command.ExecuteReader();
                    while (dtReader.Read())
                    {
                        TipoProduto tipoProduto = new TipoProduto();
                        tipoProduto.id = dtReader.GetInt32(dtReader.GetOrdinal("id_tipo_produto"));
                        tipoProduto.nome = dtReader.GetString(dtReader.GetOrdinal("nome"));
                        tipoProdutos.Add(tipoProduto);
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }

            return tipoProdutos;
        }



    }
}
