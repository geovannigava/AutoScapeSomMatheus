using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Projeto.DataAccess
{
    public class CidadeDataAcess
    {
        public static List<Cidade> preencheCombo() {

            List<Cidade> cidades = new List<Cidade>();

            string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

            using (SqlConnection connection = new SqlConnection(connString)) {

                try{
                    connection.Open();
                    SqlCommand command = new SqlCommand("select * from cidade order by nome", connection);
                    SqlDataReader dtReader = command.ExecuteReader();

                    while (dtReader.Read()){
                        Cidade cidade = new Cidade();

                        cidade.id_cidade = dtReader.GetInt32(dtReader.GetOrdinal("id_cidade"));
                        cidade.nome = dtReader.GetString(dtReader.GetOrdinal("nome")) + " - " + dtReader.GetString(dtReader.GetOrdinal("estado"));
                        cidades.Add(cidade);

                    }

                }
                catch (Exception ex){
                    throw ex;
                }
                finally {
                    connection.Close();
                }
            }
            return cidades;
        }

        public static Cidade buscaCidade(int idCid)
        {

            Cidade cidade = new Cidade();

            string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                ;

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("select * from cidade where id_cidade = "+idCid+"", connection);
                    SqlDataReader dtReader = command.ExecuteReader();

                    while (dtReader.Read())
                    {
                       cidade.id_cidade = dtReader.GetInt32(dtReader.GetOrdinal("id_cidade"));
                        cidade.nome = dtReader.GetString(dtReader.GetOrdinal("nome"));
                        cidade.estado = dtReader.GetString(dtReader.GetOrdinal("estado"));
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
            return cidade;
        }


    }
}
