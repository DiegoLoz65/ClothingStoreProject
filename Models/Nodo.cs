using System;
namespace TiendaOnline.Models{
    public class Nodo{
        // El dato o los datos que vamos a almacenar
        private string imagen;
        private string nombre;
        private int precio;
        private string color;
        private string talla;
        private int unidades;
        // Crear una variable que nos haga referencia al nodo siguiente
        // El apuntador que re enlaza al otro nodo o null
        private Nodo siguiente = null;

        //Propiedades getter y setters
        public string Imagen {
            get{return imagen;}
            set{imagen = value;}
        }
        public string Nombre {
            get{return nombre;}
            set{nombre = value;}
        }
        public int Precio {get => precio; set => precio = value;}
        public string Color {
            get{return color;}
            set{color = value;}
        }
        public string Talla {
            get{return talla;}
            set{talla = value;}
        }
        public int Unidades {get => unidades; set => unidades = value;}

        internal Nodo Siguiente {get => siguiente; set => siguiente= value;}

        public override string ToString()
        {
            return string.Format("[{0}]", nombre);
        }
    }
}