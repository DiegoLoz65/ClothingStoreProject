using System;
namespace TiendaOnline.Models{
    public class NodoCola {
        private int dato;
        private string imagen;
        private string nombre;
        private int precio;
        private string color;
        private string talla;
        private int unidades;
        private NodoCola siguiente = null;

        public int Dato{
            get => dato;
            set => dato = value;
        }
        public string Imagen{
        get => imagen;
        set => imagen = value;
        }
        
         public string Nombre{
        get => nombre;
        set => nombre = value;
        }

        public int Precio{
            get => precio;
            set => precio = value;
        }

        public string Color{
            get => color;
            set => color = value;
        }

        public string Talla{
            get => talla;
            set => talla = value;
        }

        public int Unidades{
            get => unidades;
            set => unidades = value;
        }
        internal NodoCola Siguiente{
            get => siguiente;
            set => siguiente = value;
        }


    }
}