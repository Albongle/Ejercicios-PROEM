using Repository.Interfaces;
using Repository.SqlServer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Interfaces;

namespace UnitOfWork.SqlServer
{
    public class UnitOfWorkRepository : IUnitOfWorkRespository
    {

        public UnitOfWorkRepository(SqlConnection context, SqlTransaction transaction)
        {
            this.Clientes = new ClienteRespository(context, transaction);
            this.Direcciones = new DirreccionesRepository(context,transaction);
        }
        public IClienteRespository Clientes { get; }
        public IDireccionesRespository Direcciones { get; }
    }
}
