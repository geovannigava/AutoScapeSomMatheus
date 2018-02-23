using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Projeto.DataAccess
{
    public class ModeloDataAcess
    {

        public static List<Modelo> buscaModelos(int pMarca)
        {
            List<Modelo> modelos = new List<Modelo>();
            string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("select * from modelo where marca=@MARCA order by nome", connection);
                    command.Parameters.Add(new SqlParameter("@MARCA", pMarca));
                    SqlDataReader dtReader = command.ExecuteReader();

                    while (dtReader.Read())
                    {
                        Modelo modelo = new Modelo();
                        modelo.id = dtReader.GetInt32(dtReader.GetOrdinal("id"));
                        modelo.nome = dtReader.GetString(dtReader.GetOrdinal("nome"));
                        modelo.marca = dtReader.GetInt32(dtReader.GetOrdinal("marca"));
                        modelos.Add(modelo);
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
            return modelos;
        }

        public static bool Inserir(Modelo pModelo)
        {
            try
            {
                
                ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                banco.Modelo.InsertOnSubmit(pModelo);
                banco.SubmitChanges();
                banco.Dispose();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static bool Excluir(List<int> pModelos)
        {
            
            string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    for (int x=0; x < (pModelos.Count) ; x++)
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("delete from modelo where id="+pModelos[x], connection);
                        //command.Parameters.Add(new SqlParameter("@ID", pModelos[x]));
                        command.ExecuteReader();
                        connection.Close();
                    }
                    
                    return true;
                }
                catch (Exception )
                {
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
            
        }

        public static List<MarcaModelo> buscaModelosPorProd(int pCodProd)
        {
           
            List<MarcaModelo> marcamodelos = new List<MarcaModelo>();
            string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

            using (SqlConnection connection = new SqlConnection(connString))
            {

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT pm.id, m.nome, ma.nome AS marca " +
                        " FROM produto_modelo AS pm INNER JOIN " +
                        " modelo AS m ON m.id = pm.id_modelo INNER JOIN " +
                        " marca AS ma ON ma.id = m.marca " +
                        " WHERE (pm.id_produto = @CODPROD) ", connection);
                    command.Parameters.AddWithValue("@CODPROD", pCodProd);
                    SqlDataReader dtReader = command.ExecuteReader();

                    while (dtReader.Read())
                    {
                        MarcaModelo marcamodel = new MarcaModelo();
                        marcamodel.id = dtReader.GetInt32(dtReader.GetOrdinal("id"));
                        marcamodel.nome = dtReader.GetString(dtReader.GetOrdinal("nome"));
                        marcamodel.marca = dtReader.GetString(dtReader.GetOrdinal("marca"));
                        marcamodelos.Add(marcamodel);
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

            return marcamodelos;
        }

        public static Modelo buscaModeloPorProd(int pCodProd)
        {

            Modelo marcamodel = new Modelo();
            string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT pm.id, m.nome, ma.nome AS marca " +
                        " FROM produto_modelo AS pm INNER JOIN " +
                        " modelo AS m ON m.id = pm.id_modelo INNER JOIN " +
                        " marca AS ma ON ma.id = m.marca " +
                        " WHERE (pm.id_produto = @CODPROD) ", connection);
                    command.Parameters.AddWithValue("@CODPROD", pCodProd);
                    SqlDataReader dtReader = command.ExecuteReader();

                    while (dtReader.Read())
                    {
                        marcamodel.id = dtReader.GetInt32(dtReader.GetOrdinal("id"));
                        marcamodel.nome = dtReader.GetString(dtReader.GetOrdinal("nome"));

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

            return marcamodel;
        }




    }
}
