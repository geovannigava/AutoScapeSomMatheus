using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Projeto.DataAccess
{
    public class MarcaDataAcess
    {
        public static List<Marca> buscarMarcas()
        {
            List<Marca> marcas = new List<Marca>();
            string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("select * from marca order by nome", connection);
                    SqlDataReader dtReader = command.ExecuteReader();

                    while (dtReader.Read())
                    {
                        Marca marca = new Marca();
                        marca.id = dtReader.GetInt32(dtReader.GetOrdinal("id"));
                        marca.nome = dtReader.GetString(dtReader.GetOrdinal("nome"));
                        marcas.Add(marca);
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
            return marcas;
        }
    }
}
