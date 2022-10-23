using System;
namespace TiendaOnline.Models{
    public class NodoArbol{
    private string imagen;
    private string dato;
    private string nombre;
    private int precio;
    private string color;
    private string talla;
    private int unidades;
    private NodoArbol hijo;
    private NodoArbol hermano;

    public string Dato{
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

    public NodoArbol Hijo{
        get => hijo;
        set => hijo = value;
    }

    public NodoArbol Hermano{
        get => hermano;
        set => hermano = value;
    }

    public NodoArbol(){
        nombre = "";
        imagen = "";
        precio = '0';
        color = "";
        talla = "";
        unidades = '0';
        hijo = null;
        hermano = null;
    }
}
}