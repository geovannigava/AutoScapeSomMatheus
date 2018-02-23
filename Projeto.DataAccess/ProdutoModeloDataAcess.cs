using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Projeto.DataAccess
{
    public class ProdutoModeloDataAcess
    {

        public static bool Inserir(ProdutoModelo pProdModel)
        {
            try
            {
                ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                banco.ProdutoModelo.InsertOnSubmit(pProdModel);
                banco.SubmitChanges();
                banco.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Excluir(List<int> pProdModel)
        {

            string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    for (int x = 0; x < (pProdModel.Count); x++)
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("delete from produto_modelo where id=" + pProdModel[x], connection);
                        //command.Parameters.Add(new SqlParameter("@ID", pModelos[x]));
                        command.ExecuteReader();
                        connection.Close();
                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        
    }
}
