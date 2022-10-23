using System;
namespace TiendaOnline.Models{
    public class NodoPila{
        private int dato;
        private string imagen;
        private string nombre;
        private int precio;
        private string color;
        private string talla;
        private int unidades;

        private NodoPila siguiente = null;

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

        internal NodoPila Siguiente{
            get => siguiente;
            set => siguiente = value;
        }

        //Método que permita usar el writeline y se muestre de una forma lo que se imprime
        //Presentación
        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }
    }
}