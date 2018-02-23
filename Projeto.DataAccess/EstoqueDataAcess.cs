using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace Projeto.DataAccess
{
    public class EstoqueDataAcess
    {

        public static bool GravaEstoque(List<Estoque> pEstoque)
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    for (int x = 0; x < pEstoque.Count; x++)
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("select * from estoque where id_produto = @ID  ", connection);
                        command.Parameters.AddWithValue("@ID", pEstoque[x].id_produto);
                        SqlDataReader dtReader = command.ExecuteReader();
                        while (dtReader.Read())
                        {
                            ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                            Estoque est = banco.Estoque.Single(u => u.id == dtReader.GetInt32(dtReader.GetOrdinal("id")));
                            est.qtde = est.qtde + pEstoque[x].qtde_C + pEstoque[x].qtde_S;
                            est.qtde_C = est.qtde_C + pEstoque[x].qtde_C;
                            est.qtde_S = est.qtde_S + pEstoque[x].qtde_S;
                            banco.SubmitChanges();
                            banco.Dispose();
                        }
                        if (!dtReader.HasRows)
                        {
                            pEstoque[x].qtde = pEstoque[x].qtde_C + pEstoque[x].qtde_S;
                            Inserir(pEstoque[x]);
                        }
                        connection.Close();
                    }
                    
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public static bool Inserir(Estoque estoque)
        {
            try
            {
                ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                banco.Estoque.InsertOnSubmit(estoque);
                banco.SubmitChanges();
                banco.Dispose();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static Estoque ConsultaEstoque(int idProduto)
        {
            Estoque estoque = new Estoque();
            try
            {
                ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                Estoque est = banco.Estoque.Single(u => u.id_produto == idProduto);
                banco.SubmitChanges();
                banco.Dispose();
                estoque = est;
                return estoque;
            }
            catch (Exception )
            {
                // throw ex;
                //estoque.qtde = 0;
                return estoque;
            }
        }

        public static bool DiminuiEstoque(List<Estoque> pItens){

            try
            {
                string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    
                    for (int x = 0; x < pItens.Count; x++)
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("select * from estoque where id_produto = @ID  ", connection);
                        command.Parameters.AddWithValue("@ID", pItens[x].id_produto);
                        SqlDataReader dtReader = command.ExecuteReader();
                        while (dtReader.Read())
                        {
                            ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                            Estoque est = banco.Estoque.Single(u => u.id == dtReader.GetInt32(dtReader.GetOrdinal("id")));
                            est.qtde = est.qtde - pItens[x].qtde_C - pItens[x].qtde_S;
                            est.qtde_C = est.qtde_C - pItens[x].qtde_C;
                            est.qtde_S = est.qtde_S - pItens[x].qtde_S;
                            banco.SubmitChanges();
                            banco.Dispose();
                        }
                        connection.Close();
                    }                  
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }

        public static List<ProdModelo> ConsultaEstTotal()
        {
            List<ProdModelo> prods = new List<ProdModelo>();
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

                using (SqlConnection connection = new SqlConnection(connString))
                {
                        connection.Open();
                        SqlCommand command = new SqlCommand(" SELECT est.id, est.id_produto, est.qtde, est.qtde_C, est.qtde_S, p.codigo, p.descricao, p.valor,  " +
                            " p.marca, p.id_tipo_produto, p.qtde_alerta, pm.id_modelo, m.nome " +
                            " FROM            estoque AS est INNER JOIN " +
                            " produto AS p ON est.id_produto = p.id INNER JOIN " +
                            " produto_modelo AS pm ON pm.id_produto = p.id INNER JOIN " +
                            " modelo AS m ON m.id = pm.id_modelo ", connection);
                        
                        SqlDataReader dtReader = command.ExecuteReader();
                        while (dtReader.Read())
                        {
                        ProdModelo prod = new ProdModelo();
                        prod.id = dtReader.GetInt32(dtReader.GetOrdinal("id_produto"));
                        prod.codigo = dtReader.GetString(dtReader.GetOrdinal("codigo"));
                        prod.descricao = dtReader.GetString(dtReader.GetOrdinal("descricao"));
                        prod.NomeModelo = dtReader.GetString(dtReader.GetOrdinal("nome"));
                        prod.QtdeEstoque = dtReader.GetInt32(dtReader.GetOrdinal("qtde"));
                        prod.QtdeEstoqueC = dtReader.GetInt32(dtReader.GetOrdinal("qtde_C"));
                        prod.QtdeEstoqueS = dtReader.GetInt32(dtReader.GetOrdinal("qtde_S"));
                        prod.DataUltComp = EntradaDataAcess.UltimaEntrada(prod.id);
                        prods.Add(prod);
                        }
                        connection.Close();
                    
                }
                return prods;
            }
            catch (Exception ex)
            {
                return prods;
                throw ex;
                
            }


        }
        public static List<ProdModelo> ConsultaEstPorNome(string pNome)
        {
            List<ProdModelo> prods = new List<ProdModelo>();
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(" SELECT est.id, est.id_produto, est.qtde, est.qtde_C, est.qtde_S, p.codigo, p.descricao, p.valor,  " +
                        " p.marca, p.id_tipo_produto, p.qtde_alerta, pm.id_modelo, m.nome " +
                        " FROM            estoque AS est INNER JOIN " +
                        " produto AS p ON est.id_produto = p.id INNER JOIN " +
                        " produto_modelo AS pm ON pm.id_produto = p.id INNER JOIN " +
                        " modelo AS m ON m.id = pm.id_modelo INNER JOIN " +
                        " marca AS mar ON mar.id = m.marca " +
                        " WHERE        (p.descricao LIKE '%"+pNome+"%') OR (m.nome LIKE '%"+pNome+"%')", connection);

                    SqlDataReader dtReader = command.ExecuteReader();
                    while (dtReader.Read())
                    {
                        ProdModelo prod = new ProdModelo();
                        prod.id = dtReader.GetInt32(dtReader.GetOrdinal("id_produto"));
                        prod.codigo = dtReader.GetString(dtReader.GetOrdinal("codigo"));
                        prod.descricao = dtReader.GetString(dtReader.GetOrdinal("descricao"));
                        prod.NomeModelo = dtReader.GetString(dtReader.GetOrdinal("nome"));
                        prod.QtdeEstoque = dtReader.GetInt32(dtReader.GetOrdinal("qtde"));
                        prod.QtdeEstoqueC = dtReader.GetInt32(dtReader.GetOrdinal("qtde_C"));
                        prod.QtdeEstoqueS = dtReader.GetInt32(dtReader.GetOrdinal("qtde_S"));
                        prod.DataUltComp = EntradaDataAcess.UltimaEntrada(prod.id);
                        prods.Add(prod);
                    }
                    connection.Close();

                }
                return prods;
            }
            catch (Exception ex)
            {
                return prods;
                throw ex;

            }
        }
        public static List<ProdModelo> ConsultaEstPorModel(int pModel)
        {
            List<ProdModelo> prods = new List<ProdModelo>();
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(" SELECT est.id, est.id_produto, est.qtde, est.qtde_C, est.qtde_S, p.codigo, p.descricao, p.valor,  " +
                        " p.marca, p.id_tipo_produto, p.qtde_alerta, pm.id_modelo, m.nome " +
                        " FROM            estoque AS est INNER JOIN " +
                        " produto AS p ON est.id_produto = p.id INNER JOIN " +
                        " produto_modelo AS pm ON pm.id_produto = p.id INNER JOIN " +
                        " modelo AS m ON m.id = pm.id_modelo " +
                        " WHERE        (pm.id_modelo = "+pModel+") ", connection);

                    SqlDataReader dtReader = command.ExecuteReader();
                    while (dtReader.Read())
                    {
                        ProdModelo prod = new ProdModelo();
                        prod.id = dtReader.GetInt32(dtReader.GetOrdinal("id_produto"));
                        prod.codigo = dtReader.GetString(dtReader.GetOrdinal("codigo"));
                        prod.descricao = dtReader.GetString(dtReader.GetOrdinal("descricao"));
                        prod.NomeModelo = dtReader.GetString(dtReader.GetOrdinal("nome"));
                        prod.QtdeEstoque = dtReader.GetInt32(dtReader.GetOrdinal("qtde"));
                        prod.QtdeEstoqueC = dtReader.GetInt32(dtReader.GetOrdinal("qtde_C"));
                        prod.QtdeEstoqueS = dtReader.GetInt32(dtReader.GetOrdinal("qtde_S"));
                        prod.DataUltComp = EntradaDataAcess.UltimaEntrada(prod.id);
                        prods.Add(prod);
                    }
                    connection.Close();

                }
                return prods;
            }
            catch (Exception ex)
            {
                return prods;
                throw ex;

            }


        }
        public static List<ProdModelo> ConsultaEstPorTpProd(int pIdTipo)
        {
            List<ProdModelo> prods = new List<ProdModelo>();
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(" SELECT est.id, est.id_produto, est.qtde, est.qtde_C, est.qtde_S, p.codigo, p.descricao, p.valor,  " +
                        " p.marca, p.id_tipo_produto, p.qtde_alerta, pm.id_modelo, m.nome " +
                        " FROM            estoque AS est INNER JOIN " +
                        " produto AS p ON est.id_produto = p.id INNER JOIN " +
                        " produto_modelo AS pm ON pm.id_produto = p.id INNER JOIN " +
                        " modelo AS m ON m.id = pm.id_modelo " +
                        " WHERE        (p.id_tipo_produto = " + pIdTipo + ") ", connection);

                    SqlDataReader dtReader = command.ExecuteReader();
                    while (dtReader.Read())
                    {
                        ProdModelo prod = new ProdModelo();
                        prod.id = dtReader.GetInt32(dtReader.GetOrdinal("id_produto"));
                        prod.codigo = dtReader.GetString(dtReader.GetOrdinal("codigo"));
                        prod.descricao = dtReader.GetString(dtReader.GetOrdinal("descricao"));
                        prod.NomeModelo = dtReader.GetString(dtReader.GetOrdinal("nome"));
                        prod.QtdeEstoque = dtReader.GetInt32(dtReader.GetOrdinal("qtde"));
                        prod.QtdeEstoqueC = dtReader.GetInt32(dtReader.GetOrdinal("qtde_C"));
                        prod.QtdeEstoqueS = dtReader.GetInt32(dtReader.GetOrdinal("qtde_S"));
                        prod.DataUltComp = EntradaDataAcess.UltimaEntrada(prod.id);
                        prods.Add(prod);
                    }
                    connection.Close();

                }
                return prods;
            }
            catch (Exception ex)
            {
                return prods;
                throw ex;

            }
        }
        public static List<ProdModelo> ConsultaEstPorMarcaVeic(int pIdMarca)
        {
            List<ProdModelo> prods = new List<ProdModelo>();
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(" SELECT est.id, est.id_produto, est.qtde, est.qtde_C, est.qtde_S, p.codigo, p.descricao, p.valor,  " +
                        " p.marca, p.id_tipo_produto, p.qtde_alerta, pm.id_modelo, m.nome " +
                        " FROM            estoque AS est INNER JOIN " +
                        " produto AS p ON est.id_produto = p.id INNER JOIN " +
                        " produto_modelo AS pm ON pm.id_produto = p.id INNER JOIN " +
                        " modelo AS m ON m.id = pm.id_modelo INNER JOIN " +
                        " marca AS mar ON mar.id = m.marca " +
                        " WHERE  (mar.id = "+pIdMarca+") ", connection);

                    SqlDataReader dtReader = command.ExecuteReader();
                    while (dtReader.Read())
                    {
                        ProdModelo prod = new ProdModelo();
                        prod.id = dtReader.GetInt32(dtReader.GetOrdinal("id_produto"));
                        prod.codigo = dtReader.GetString(dtReader.GetOrdinal("codigo"));
                        prod.descricao = dtReader.GetString(dtReader.GetOrdinal("descricao"));
                        prod.NomeModelo = dtReader.GetString(dtReader.GetOrdinal("nome"));
                        prod.QtdeEstoque = dtReader.GetInt32(dtReader.GetOrdinal("qtde"));
                        prod.QtdeEstoqueC = dtReader.GetInt32(dtReader.GetOrdinal("qtde_C"));
                        prod.QtdeEstoqueS = dtReader.GetInt32(dtReader.GetOrdinal("qtde_S"));
                        prod.DataUltComp = EntradaDataAcess.UltimaEntrada(prod.id);
                        prods.Add(prod);
                    }
                    connection.Close();

                }
                return prods;
            }
            catch (Exception ex)
            {
                return prods;
                throw ex;

            }
        }
    }
}
