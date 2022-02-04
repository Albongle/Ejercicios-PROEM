using Entidades;
using System;
using UnitOfWork.Interfaces;

namespace GestorBD
{
    public class GestorSQL
    {
        private IUnitOfWork uniOfWork;

        public GestorSQL(IUnitOfWork unitOfWork)
        {
            this.uniOfWork = unitOfWork;    
        }
        public Cliente GetCliente (int id)
        {
            using(IUnitOfWorkAdapter context = this.uniOfWork.Create())
            {
                return context.Repositories.Clientes.Get(id);
            }
        }
    }
}
