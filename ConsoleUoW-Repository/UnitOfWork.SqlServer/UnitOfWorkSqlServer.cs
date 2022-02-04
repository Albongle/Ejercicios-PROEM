using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Interfaces;

namespace UnitOfWork.SqlServer
{
    public class UnitOfWorkSqlServer : IUnitOfWork
    {
        public IUnitOfWorkAdapter Create()
        {
            return new UnitOfWorkAdapter("Server=.;Database=.NET-PROEM;Trusted_Connection=True");
        }
    }
}
