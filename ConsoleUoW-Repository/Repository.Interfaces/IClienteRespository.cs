using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IClienteRespository
    {
        Cliente Get(int id);

        void Add(Cliente cliente);

    }
}
