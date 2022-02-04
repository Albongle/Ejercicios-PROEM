using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Direccion
    {
        private int id;
        private string provincia;
        private string localidad;
        private string calle;


        public Direccion(string provincia, string localidad, string calle)
        {

            this.provincia = provincia;
            this.localidad = localidad;
            this.calle = calle;
        }
        public Direccion(int id, string provincia, string localidad, string calle)
            : this(provincia, localidad, calle)
        {
            this.id = id;

        }

        public int Id { get => id; set => id = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Calle { get => calle; set => calle = value; }
    }
}
