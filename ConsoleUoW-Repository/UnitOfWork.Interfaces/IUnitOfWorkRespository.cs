using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Interfaces
{
    public interface IUnitOfWorkRespository
    {

        IClienteRespository Clientes { get; }
        IDireccionesRespository Direcciones { get; }

    }
}
