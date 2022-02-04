using Entidades;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.SqlServer
{
    public class ClienteRespository : Repository, IClienteRespository
    {
        public ClienteRespository(SqlConnection context, SqlTransaction transaction) : base(context, transaction)
        {
        }
        /// <summary>
        /// Agrega Cliente
        /// </summary>
        /// <param name="objeto"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Add(Cliente objeto)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Retorna un Cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Cliente Get(int id)
        {
            SqlCommand command = base.CreateCommand("SELECT * FROM CLIENTES WHERE ID = @ID");
            command.Parameters.AddWithValue("id", id);
            using(SqlDataReader reader = command.ExecuteReader())
            {
                reader.Read();
                return new Cliente(reader.GetString(1), reader.GetString(2), reader.GetInt32(4));
            }

        }
    }
}
