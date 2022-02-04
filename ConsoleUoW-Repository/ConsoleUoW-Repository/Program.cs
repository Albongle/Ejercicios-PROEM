using Entidades;
using GestorBD;
using System;
using UnitOfWork.SqlServer;

namespace ConsoleUoW_Repository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UnitOfWorkSqlServer uow = new UnitOfWorkSqlServer();

            GestorSQL gestorSQl = new GestorSQL(uow);

            Cliente cli = gestorSQl.GetCliente(2);

            Console.WriteLine("Hello World!");
        }
    }
}
