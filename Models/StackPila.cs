using System;

namespace TiendaOnline.Models{
    public struct producto4
    {
        public int tmpdato;
        public string tmpimagen;
        public string tmpnombre;
        public int tmpprecio;
        public string tmpcolor;
        public string tmptalla;
        public int tmpunidades;
    }

public class Stack{
    private NodoPila cabecera;
    private NodoPila referencia;
    
    public Stack(){
        cabecera = new NodoPila();
        cabecera.Siguiente = null;
        Push("Manilla", 25000, "Café", "Estandar", 20, "https://cuerosvelezco.vteximg.com.br/arquivos/ids/172829-1563-2344/1030248-02-01-manilla-de-cuero.jpg?v=637409147213370000");
        Push("Manilla Sensorial", 50000, "Café", "Estandar", 12, "https://cuerosvelezco.vteximg.com.br/arquivos/ids/167873-1563-2344/1028974-11-01-Manilla-de-cuero.jpg?v=637409089487430000");
        Push("Manilla Black", 40000, "Negro", "Estandar", 25, "https://cuerosvelezco.vteximg.com.br/arquivos/ids/161592-1563-2344/1026247-00-01-Manilla-de-cuero-para-hombre-.jpg?v=637409054439230000");
        Push("Manilla", 35000, "Café claro", "Estandar", 15, "https://cuerosvelezco.vteximg.com.br/arquivos/ids/168755-1563-2344/1029174-07-01-manilla-de-cuero.jpg?v=637409097496070000");
    }

    //Push
    public void Push(string pNombre, int pPrecio, string pColor, string pTalla, int pUnidades, string pImagen){
        NodoPila tmp = new NodoPila();
        tmp.Imagen = pImagen;
        tmp.Nombre = pNombre;
        tmp.Precio = pPrecio;
        tmp.Color = pColor;
        tmp.Talla = pTalla;
        tmp.Unidades = pUnidades;

        tmp.Siguiente  = cabecera.Siguiente;
        cabecera.Siguiente = tmp;
    }

    //Pop
    public producto4[] Pop(){
        producto4[] pop = new producto4[1];
        if (cabecera.Siguiente != null){
            referencia = cabecera.Siguiente;
            pop[0].tmpimagen = referencia.Imagen;
            pop[0].tmpnombre = referencia.Nombre;
            pop[0].tmpprecio = referencia.Precio;
            pop[0].tmpcolor = referencia.Color;
            pop[0].tmptalla = referencia.Talla;
            pop[0].tmpunidades = referencia.Unidades;
            cabecera.Siguiente = referencia.Siguiente;
            referencia.Siguiente = null;
        }
        return pop;
    }

    //Peek
    public producto4[] Peek(){
        producto4[] peek = new producto4[1];
        if (cabecera.Siguiente != null){
            referencia = cabecera.Siguiente;
            peek[0].tmpimagen = referencia.Imagen;
            peek[0].tmpnombre = referencia.Nombre;
            peek[0].tmpprecio = referencia.Precio;
            peek[0].tmpcolor = referencia.Color;
            peek[0].tmptalla = referencia.Talla;
            peek[0].tmpunidades = referencia.Unidades;
        }
        return peek;
    }

    //Apuntador
    public producto4[] Apuntador(){
        int i=0;
        producto4[] apuntador = new producto4[100];
        referencia = cabecera;
        while(referencia.Siguiente != null){
            referencia = referencia.Siguiente;
            apuntador[i].tmpimagen = referencia.Imagen;
            apuntador[i].tmpnombre = referencia.Nombre;
            apuntador[i].tmpprecio = referencia.Precio;
            apuntador[i].tmpcolor = referencia.Color;
            apuntador[i].tmptalla = referencia.Talla;
            apuntador[i].tmpunidades = referencia.Unidades;
            i++;
        }
        return apuntador;
    }
}
}