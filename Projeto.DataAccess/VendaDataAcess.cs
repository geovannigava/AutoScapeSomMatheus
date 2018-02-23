using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Projeto.DataAccess
{
    public class VendaDataAcess
    {
        public static int Inserir(Venda pVenda)
        {
            try
            {
                ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                banco.Venda.InsertOnSubmit(pVenda);
                banco.SubmitChanges();
                banco.Dispose();
                
                return pVenda.id;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public static List<Venda> ConsultaVenda(DateTime dataIni, DateTime dataFim)
        {
            List<Venda> vendas = new List<Venda>();
            try
            {
                ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                var vendasFiltro = banco.Venda.Where((Venda u) => (u.data >= dataIni) && (u.data <= dataFim) );
                banco.SubmitChanges();
                vendas = vendasFiltro.ToList();
                
                for (int x=0;x<vendas.Count;x++)
                {
                    if(vendas[x].id_cliente != null)
                        vendas[x].Cliente = ClienteDataAcess.buscarCliente(vendas[x].id_cliente);
                }
                //var clientes = banco.Cliente.Where((Cliente u) => (u.id==vendas.));
                banco.Dispose();
                return vendas;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static bool CancelaVenda(int pIdVenda)
        {
            try
            {
                ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                Venda venda = banco.Venda.Single(u => u.id == pIdVenda);
                venda.ativo = false;
                banco.SubmitChanges();
                banco.Dispose();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
