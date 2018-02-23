using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Projeto.DataAccess
{
    public class VendaCancelDataAcess
    {
        public static bool Inserir(VendaCancel pVendCancel)
        {
            try
            {
                ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                banco.VendaCancel.InsertOnSubmit(pVendCancel);
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
