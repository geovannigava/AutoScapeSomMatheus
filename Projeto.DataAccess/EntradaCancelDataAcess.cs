using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Projeto.DataAccess
{
    public class EntradaCancelDataAcess
    {
        public static bool Inserir(EntradaCancel pEntradaCancel)
        {
            try
            {
                ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                banco.EntradaCancel.InsertOnSubmit(pEntradaCancel);
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
