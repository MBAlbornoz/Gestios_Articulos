using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Articulos
{
    class Marca
    {

        private int id;
        private string nombre;
        public void setId(int id) { this.id = id; }
        public void setNombre(string nombre) { this.nombre = nombre; }

        public int getId() { return id; }
        public string getNombre() { return nombre; }

        Marca(int id,string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

    }
}
