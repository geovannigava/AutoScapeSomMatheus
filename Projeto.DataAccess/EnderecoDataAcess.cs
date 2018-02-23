using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Projeto.DataAccess
{
    public class EnderecoDataAcess
    {

        public static bool Inserir(Endereco end)
        {
            try
            {
                ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                banco.Endereco.InsertOnSubmit(end);
                banco.SubmitChanges();
                banco.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static Endereco buscarEnd(int id)
        {
            Endereco end = new Endereco();

            string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

            using (SqlConnection connection = new SqlConnection(connString))
            {

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("select * from endereco where id = @id", connection);
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataReader dtReader = command.ExecuteReader();

                    while (dtReader.Read())
                    {
                        end.id = dtReader.GetInt32(dtReader.GetOrdinal("id"));
                        end.rua = dtReader.GetString(dtReader.GetOrdinal("rua"));
                        end.numero = dtReader.GetString(dtReader.GetOrdinal("numero"));
                        end.bairro = dtReader.GetString(dtReader.GetOrdinal("bairro"));
                        end.cidade = dtReader.GetInt32(dtReader.GetOrdinal("cidade"));
                        end.cep = dtReader.GetString(dtReader.GetOrdinal("cep"));
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
            return end;

        }

    }
}
