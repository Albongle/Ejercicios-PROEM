using System;

namespace Entidades
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private string apellido;
        private string direccion;
        private int telefono;


        public Cliente(int id, string nombre, string apellido, string direccion, int telefono)
            :this(nombre,apellido,direccion, telefono)
        {
            this.id = id;
        }
        public Cliente(string nombre, string apellido, string direccion, int telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Apellido { get => this.apellido; set => this.apellido = value; }
        public string Direccion { get => this.direccion; set => this.direccion = value; }
        public int Telefono { get => this.telefono; set => this.telefono = value; }
        public override string ToString()
        {
            return $"Cliente {this.Apellido}, {this.Nombre} con direccion en {this.Direccion}";
        }
    }
}
