using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Articulos
{
    class Gestion
    {
        List<Articulo> articulos;
       
        public void listarArticulos();
        public Articulo buscarArticulos(Articulo obj);
        public void agregaArticulos(Articulo obj);
        public void modificarArticulos();
        public void eliminarArticulos();
        public void verDetalleArtículo();


    }
}
