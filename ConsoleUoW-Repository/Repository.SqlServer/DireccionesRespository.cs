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
    public class DirreccionesRepository : Repository, IDireccionesRespository
    {
        public DirreccionesRepository(SqlConnection context, SqlTransaction transaction) : base(context, transaction)
        {
        }

        public void Add(Direccion objeto)
        {
            throw new NotImplementedException();
        }

        public Direccion Get(int id)
        {
            SqlCommand command = base.CreateCommand("SELECT * FROM DIRECCION WHERE ID = @ID");

            using (SqlDataReader reader = command.ExecuteReader())
            {
                reader.Read();
                return new Direccion(reader.GetString(1), reader.GetString(2), reader.GetString(3));
            }

        }

        public List<Direccion> GetDirecciones()
        {
            throw new NotImplementedException();
        }
    }
}
