using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.SqlServer
{
    public abstract class Repository
    {
        protected SqlConnection context;
        protected SqlTransaction transaction;

        protected Repository(SqlConnection context, SqlTransaction transaction)
        {
            this.context = context;
            this.transaction = transaction;
        }
        protected SqlCommand CreateCommand(string query)
        {
            return new SqlCommand(query, this.context, this.transaction);
        }
    }
}
