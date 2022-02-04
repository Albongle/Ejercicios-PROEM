using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Interfaces
{
    public interface IUnitOfWorkAdapter:IDisposable
    {
        IUnitOfWorkRespository Repositories { get; }
        void SaveChanges();
    }
}
