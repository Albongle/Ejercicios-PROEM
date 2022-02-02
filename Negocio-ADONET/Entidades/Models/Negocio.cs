using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        
        private string nombre;
     
        public Negocio(string nombre)
        {
            this.nombre = nombre;   
        }

        public List<Cliente> Clientes { get => GestorSQL.GetClientes(); }
        public string Nombre { get => this.nombre; set => this.nombre = value; }

        public static Negocio operator +(Negocio negocio, Cliente cliente)
        {
            
            try
            {
                GestorSQL.AddCliente(cliente);
            }
            catch(Exception ex)
            {
                throw new Exception("No se agrego el cliente", ex);
            }  
            return negocio; 
        }
        public static Negocio operator |(Negocio negocio, Cliente cliente)
        {
            try
            {
                GestorSQL.EditCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("No se modifico el cliente", ex);
            }

            return negocio;
        }

        public Cliente this [int id]
        {
            get
            {
                if (id > 0)
                {
                    return GestorSQL.GetClienteById(id);
                }
                else
                {
                    throw new Exception("Id invalido o inexistente");
                }
            }
        }

        
    }
}
