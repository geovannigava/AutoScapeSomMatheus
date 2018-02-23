using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Projeto.DataAccess
{
   public class ProdutoDataAcess
    {

        public static int Inserir(Produto pProduto)
        {
            try
            {
                ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                banco.Produto.InsertOnSubmit(pProduto);
                banco.SubmitChanges();
                banco.Dispose();
                return pProduto.id;

                
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static List<int> InserirProds(List<Produto> pProdutos)
        {
            List<int> idProds = new List<int>();
            for (int x=0; x < pProdutos.Count; x++)
            {
                try
                {
                    ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                    banco.Produto.InsertOnSubmit(pProdutos[x]);
                    banco.SubmitChanges();
                    banco.Dispose();
                    idProds.Add(pProdutos[x].id);

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

            return idProds;

        }


        public static bool Alterar(Produto pProduto)
        {
            try
            {
                ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                Produto produto = banco.Produto.Single(u => u.id == pProduto.id);
                produto.id = pProduto.id;
                produto.codigo = pProduto.codigo;
                produto.descricao = pProduto.descricao;
                produto.valor = pProduto.valor;
                produto.marca = pProduto.marca;
                produto.modelo = pProduto.modelo;
                produto.id_tipo_produto = pProduto.id_tipo_produto;
                produto.especie = pProduto.especie;
                produto.cod_equi = pProduto.cod_equi;
                produto.qtde_alerta = pProduto.qtde_alerta;
                banco.SubmitChanges();
                banco.Dispose();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static List<Produto> BuscarProdCombo()
        {
            List<Produto> produtos = new List<Produto>();

            string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(" SELECT p.id, p.codigo, p.descricao, m.nome " +
                        " FROM            produto AS p INNER JOIN " +
                        " produto_modelo AS pm ON p.id = pm.id_produto INNER JOIN " +
                        " modelo AS m ON m.id = pm.id_modelo " +
                        " ORDER BY m.nome ", connection);
                    SqlDataReader dtReader = command.ExecuteReader();

                    while (dtReader.Read())
                    {
                        Produto produto = new Produto();
                        produto.id = dtReader.GetInt32(dtReader.GetOrdinal("id"));
                        produto.descricao =  dtReader.GetString(dtReader.GetOrdinal("codigo")) + " - " + dtReader.GetString(dtReader.GetOrdinal("descricao")) + " - " + dtReader.GetString(dtReader.GetOrdinal("nome"));
                        produtos.Add(produto);
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
            return produtos;

        }

        public static Produto BuscaProduto(int idProduto)
        {
            Produto produto = new Produto();
            string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("select * from produto where id = @ID", connection);
                    command.Parameters.AddWithValue("@ID", idProduto);
                    SqlDataReader dtReader = command.ExecuteReader();

                    while (dtReader.Read())
                    {
                        
                        produto.id = dtReader.GetInt32(dtReader.GetOrdinal("id"));
                        produto.codigo = dtReader.GetString(dtReader.GetOrdinal("codigo"));
                        produto.descricao = dtReader.GetString(dtReader.GetOrdinal("descricao"));
                        produto.valor = dtReader.GetDecimal(dtReader.GetOrdinal("valor"));
                        produto.marca = dtReader.GetString(dtReader.GetOrdinal("marca"));
                        produto.modelo = dtReader.GetString(dtReader.GetOrdinal("modelo"));
                        produto.id_tipo_produto = dtReader.GetInt32(dtReader.GetOrdinal("id_tipo_produto"));
                        produto.especie = dtReader.GetString(dtReader.GetOrdinal("especie"));
                        if (!dtReader.IsDBNull(dtReader.GetOrdinal("qtde_alerta")))
                        {
                            produto.qtde_alerta = dtReader.GetInt32(dtReader.GetOrdinal("qtde_alerta"));
                        }
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
            return produto;
        }

        public static List<Produto> buscaProdporModel(int CodModel)
        {
            List<Produto> ProdsporModel = new List<Produto>();

            string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT        p.id, p.codigo, p.descricao, p.valor, p.marca, p.modelo, p.id_tipo_produto, p.especie, p.cod_equi, pm.id_produto,p.qtde_alerta, pm.id_modelo, pm.id AS id_pm" +
                        " FROM            produto AS p INNER JOIN " +
                        " produto_modelo AS pm ON p.id = pm.id_produto " +
                        " WHERE        (pm.id_modelo = @ID)", connection);
                    command.Parameters.AddWithValue("@ID", CodModel);
                    SqlDataReader dtReader = command.ExecuteReader();

                    while (dtReader.Read())
                    {
                        Produto prod = new Produto();
                        prod.id = dtReader.GetInt32(dtReader.GetOrdinal("id"));
                        prod.codigo = dtReader.GetString(dtReader.GetOrdinal("codigo"));
                        prod.descricao = dtReader.GetString(dtReader.GetOrdinal("descricao"));
                        prod.valor = dtReader.GetDecimal(dtReader.GetOrdinal("valor"));
                        prod.cod_equi = dtReader.GetString(dtReader.GetOrdinal("cod_equi"));
                        prod.id_tipo_produto = dtReader.GetInt32(dtReader.GetOrdinal("id_tipo_produto"));
                        prod.marca = dtReader.GetString(dtReader.GetOrdinal("marca"));
                        prod.qtde_alerta = dtReader.GetInt32(dtReader.GetOrdinal("qtde_alerta"));
                        ProdsporModel.Add(prod);
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

            return ProdsporModel;
        }

        public static List<ProdModelo> BuscaProdporCodigo(string codProd)
        {
            List<ProdModelo> produtos = new List<ProdModelo>();
            string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(" SELECT m.nome,p.id, p.codigo, p.descricao, p.valor, p.marca, p.modelo, p.id_tipo_produto, p.especie, p.cod_equi, p.qtde_alerta " +
                        " FROM produto AS p INNER JOIN " +
                        " produto_modelo AS pm ON pm.id_produto = p.id INNER JOIN " +
                        " modelo AS m ON m.id = pm.id_modelo " +
                        " WHERE (p.codigo = '" + codProd + "') ", connection);
                    //command.Parameters.AddWithValue("@CODIGO", codProd);
                    SqlDataReader dtReader = command.ExecuteReader();

                    while (dtReader.Read())
                    {
                        ProdModelo produto = new ProdModelo();
                        produto.id = dtReader.GetInt32(dtReader.GetOrdinal("id"));
                        produto.codigo = dtReader.GetString(dtReader.GetOrdinal("codigo"));
                        produto.descricao = dtReader.GetString(dtReader.GetOrdinal("descricao"));
                        produto.valor = dtReader.GetDecimal(dtReader.GetOrdinal("valor"));
                        produto.marca = dtReader.GetString(dtReader.GetOrdinal("marca"));
                        produto.modelo = dtReader.GetString(dtReader.GetOrdinal("modelo"));
                        produto.id_tipo_produto = dtReader.GetInt32(dtReader.GetOrdinal("id_tipo_produto"));
                        produto.especie = dtReader.GetString(dtReader.GetOrdinal("especie"));
                        produto.cod_equi = dtReader.GetString(dtReader.GetOrdinal("cod_equi"));
                        produto.qtde_alerta = dtReader.GetInt32(dtReader.GetOrdinal("qtde_alerta"));
                        produto.NomeModelo = dtReader.GetString(dtReader.GetOrdinal("nome"));
                        produtos.Add(produto);
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
            return produtos;
        }

        public static List<ProdModelo> BuscaProdporNome(string nome)
        {
            List<ProdModelo> produtos = new List<ProdModelo>();
            string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(" SELECT m.nome,p.id, p.codigo, p.descricao, p.valor, p.marca, p.modelo, p.id_tipo_produto, p.especie, p.cod_equi, p.qtde_alerta " +
                        "FROM produto AS p INNER JOIN " +
                        " produto_modelo AS pm ON pm.id_produto = p.id INNER JOIN " +
                        " modelo AS m ON m.id = pm.id_modelo " +
                        " WHERE (p.descricao LIKE '%"+nome+"%') OR (m.nome LIKE '%"+nome+"%') ", connection);
                    //command.Parameters.AddWithValue("@NOME", nome);
                    SqlDataReader dtReader = command.ExecuteReader();

                    while (dtReader.Read())
                    {
                        ProdModelo produto = new ProdModelo();
                        produto.id = dtReader.GetInt32(dtReader.GetOrdinal("id"));
                        produto.codigo = dtReader.GetString(dtReader.GetOrdinal("codigo"));
                        produto.descricao = dtReader.GetString(dtReader.GetOrdinal("descricao"));
                        produto.valor = dtReader.GetDecimal(dtReader.GetOrdinal("valor"));
                        produto.marca = dtReader.GetString(dtReader.GetOrdinal("marca"));
                        produto.modelo = dtReader.GetString(dtReader.GetOrdinal("modelo"));
                        produto.id_tipo_produto = dtReader.GetInt32(dtReader.GetOrdinal("id_tipo_produto"));
                        produto.especie = dtReader.GetString(dtReader.GetOrdinal("especie"));
                        produto.cod_equi = dtReader.GetString(dtReader.GetOrdinal("cod_equi"));
                        produto.qtde_alerta = dtReader.GetInt32(dtReader.GetOrdinal("qtde_alerta"));
                        produto.NomeModelo = dtReader.GetString(dtReader.GetOrdinal("nome"));
                        produtos.Add(produto);
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
            return produtos;
        }
    }
}
