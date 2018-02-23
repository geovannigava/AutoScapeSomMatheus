using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Projeto.DataAccess
{
    public class EntradaDataAcess
    {
        public static bool Inserir(List<Entrada> pEntradas)
        {
            try
            {
                ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                for (int x=0; x<pEntradas.Count;x++)
                {
                    banco.Entrada.InsertOnSubmit(pEntradas[x]);
                }
                banco.SubmitChanges();
                banco.Dispose();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

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
                banco.SubmitChanges();
                banco.Dispose();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static List<Entrada> ConsultaEnt(DateTime dataIni, DateTime dataFim)
        {
            List<Entrada> entradas = new List<Entrada>();
            try
            {
                ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                var EntFiltro = banco.Entrada.Where((Entrada u) => (u.data >= dataIni) && (u.data <= dataFim));
                banco.SubmitChanges();
                entradas = EntFiltro.ToList();

                for (int x = 0; x < entradas.Count; x++)
                {
                    entradas[x].Produto = ProdutoDataAcess.BuscaProduto(entradas[x].id_produto);
                }
                
                banco.Dispose();
                return entradas;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static bool CancelaEntrada(int pIdEntrada)
        {
            try
            {
                ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                Entrada ent = banco.Entrada.Single(u => u.id == pIdEntrada);
                ent.ativo = false;
                banco.SubmitChanges();
                banco.Dispose();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Entrada BuscaEntrada(int pIdEntrada)
        {
            Entrada ent = new Entrada();
            try
            {
                ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                ent = banco.Entrada.Single((Entrada u) => (u.id == pIdEntrada));
                banco.SubmitChanges();
                banco.Dispose();
                return ent;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DateTime UltimaEntrada(int pIdProd)
        {
            DateTime data = new DateTime();
            string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT TOP (1) id, data FROM entrada WHERE (id_produto = "+pIdProd+") ORDER BY id DESC", connection);
                    SqlDataReader dtReader = command.ExecuteReader();
                    while (dtReader.Read())
                    {
                        data = dtReader.GetDateTime(dtReader.GetOrdinal("data"));
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
            return data;

        }
    }
}
