using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Projeto.DataAccess
{
    public class ClienteDataAcess
    {

        public static bool Inserir(Cliente pCliente )
        {
            try
            {
                ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                banco.Cliente.InsertOnSubmit(pCliente);
                banco.SubmitChanges();
                banco.Dispose();
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
       
        }

        public static bool Alterar(Cliente pCliente, Endereco pEndereco)
        {
            try {
                ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                Cliente cliente = banco.Cliente.Single(u => u.id == pCliente.id);
                cliente.id = pCliente.id;
                cliente.nome = pCliente.nome;
                cliente.email = pCliente.email;
                cliente.tel_fixo = pCliente.tel_fixo;
                cliente.celular = pCliente.celular;
                cliente.data_nasc = pCliente.data_nasc;
                Endereco endereco = banco.Endereco.Single(u => u.id == pEndereco.id);
                endereco.id = pEndereco.id;
                endereco.rua = pEndereco.rua;
                endereco.bairro = pEndereco.bairro;
                endereco.numero = pEndereco.numero;
                endereco.cidade = pEndereco.cidade;
                endereco.cep = pEndereco.cep;
                banco.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static List<Cliente> buscarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("select * from cliente order by nome", connection);
                    SqlDataReader dtReader = command.ExecuteReader();

                    while (dtReader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.id = dtReader.GetInt32(dtReader.GetOrdinal("id"));
                        cliente.nome = dtReader.GetString(dtReader.GetOrdinal("nome"));
                        cliente.email = dtReader.GetString(dtReader.GetOrdinal("email"));
                        

                        clientes.Add(cliente);
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
            return clientes;

        }

        public static Cliente buscarCliente(int? id)
        {
            Cliente cliente = new Cliente();

            string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("select * from cliente where id = @id", connection);
                    command.Parameters.AddWithValue("@id",id);
                    SqlDataReader dtReader = command.ExecuteReader();

                    while (dtReader.Read())
                    {
                        cliente.id = dtReader.GetInt32(dtReader.GetOrdinal("id"));
                        cliente.nome = dtReader.GetString(dtReader.GetOrdinal("nome"));
                        cliente.email = dtReader.GetString(dtReader.GetOrdinal("email"));
                        cliente.tel_fixo = dtReader.GetString(dtReader.GetOrdinal("tel_fixo"));
                        cliente.celular = dtReader.GetString(dtReader.GetOrdinal("celular"));
                        ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                        Endereco endereco = banco.Endereco.Single(u => u.id == dtReader.GetInt32(dtReader.GetOrdinal("id_endereco")));
                        cliente.Endereco = endereco;
                        if (!dtReader.IsDBNull(dtReader.GetOrdinal("data_nasc")))
                        {
                            cliente.data_nasc = dtReader.GetDateTime(dtReader.GetOrdinal("data_nasc"));
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
            return cliente;

        }

        public static List<Cliente> buscarClientesporNome(string pNome)
        {
            List<Cliente> clientes = new List<Cliente>();

            string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("select * from cliente where nome  LIKE '%"+pNome+"%' order by nome", connection);
                    SqlDataReader dtReader = command.ExecuteReader();

                    while (dtReader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.id = dtReader.GetInt32(dtReader.GetOrdinal("id"));
                        cliente.nome = dtReader.GetString(dtReader.GetOrdinal("nome"));
                        cliente.email = dtReader.GetString(dtReader.GetOrdinal("email"));
                        ProjetoDataClassesDataContext banco = new ProjetoDataClassesDataContext();
                        Endereco endereco = banco.Endereco.Single(u => u.id == dtReader.GetInt32(dtReader.GetOrdinal("id_endereco")));
                        Cidade cidade = banco.Cidade.Single(u => u.id_cidade == endereco.cidade);
                        endereco.Cidade1 = cidade;
                        cliente.Endereco = endereco;
                        cliente.celular = dtReader.GetString(dtReader.GetOrdinal("celular"));
                        cliente.tel_fixo = dtReader.GetString(dtReader.GetOrdinal("tel_fixo"));
                        if (!dtReader.IsDBNull(dtReader.GetOrdinal("data_nasc")))
                        {
                            cliente.data_nasc = dtReader.GetDateTime(dtReader.GetOrdinal("data_nasc"));
                        }
                        clientes.Add(cliente);
                        
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
            return clientes;

        }
    }
}
