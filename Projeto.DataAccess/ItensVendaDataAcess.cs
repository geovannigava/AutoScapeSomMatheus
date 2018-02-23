using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Projeto.DataAccess
{
    public class ItensVendaDataAcess
    {

        public static bool Inserir(List<ItensVenda> pItens)
        {
            try
            {
                ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                
                for(int x=0;x<pItens.Count; x++)
                {
                    banco.ItensVenda.InsertOnSubmit(pItens[x]);
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
        public static List<ItensVenda> BuscaItens(int pIdVenda)
        {
            List<ItensVenda> ItensVenda = new List<ItensVenda>();
            try
            {
                ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                var Itens = banco.ItensVenda.Where((ItensVenda u) => (u.id_venda == pIdVenda));
                banco.SubmitChanges();
                ItensVenda = Itens.ToList();

                for (int x = 0; x < ItensVenda.Count; x++)
                {
                    ItensVenda[x].Produto = ProdutoDataAcess.BuscaProduto(ItensVenda[x].id_produto);
                }
                
                banco.Dispose();
                return ItensVenda;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

    }
}
