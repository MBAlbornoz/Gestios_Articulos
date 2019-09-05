using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Articulos
{
    class Articulo
    {

        private int codigoArticulo;
        private string nombre;
        private string descripcion;
        private Marca idMarca;
        private Categoria idCategoría;
        private bool imagen; //Ver 
        private float precio;

        public void SetCodigoArticulo(int codigo) {this.codigoArticulo = codigo; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setDescripcion(string d) { this.descripcion = d; }     
        public void setPrecio(float precio) { this.precio = precio; }

        public int getCodigoArticulo() { return codigoArticulo; }
        public string getNombre() { return nombre; }
        public string getDescripcion() { return descripcion; }
        public float getPrecio() { return precio; }

        //Constructores
        //public Articulo();
        public Articulo(int cod,string nombre, string descripcion,float precio) {
            this.codigoArticulo = cod;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
        }
    }
}
