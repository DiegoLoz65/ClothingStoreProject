using System;
namespace TiendaOnline.Models{
    public struct producto5
    {
        public int tmpdato;
        public string tmpimagen;
        public string tmpnombre;
        public int tmpprecio;
        public string tmpcolor;
        public string tmptalla;
        public int tmpunidades;
    }

public class Queue{
    NodoCola cabecera;
    NodoCola referencia;

    public Queue(){
        cabecera = new NodoCola();
        cabecera.Siguiente = null;
        Equeue("Camisa", 35000, "Verde Claro", "S,L,M", 9, "https://i.ibb.co/D1WpPNk/Camisa.jpg");
        Equeue("Camiseta Lila Edition", 30000, "Lila", "S,L", 7, "https://i.ibb.co/MgcWBx2/Camisa2.jpg");
        Equeue("Camisa Men G", 33000, "Verde Oscuro", "S,L,XL", 6, "https://i.ibb.co/3FXJcnC/Camisa3.jpg");
        Equeue("Polo", 31000, "Verde Claro", "S,L,M,X", 11, "https://i.ibb.co/LxvmQ84/Polo.jpg");
    }

    public producto5[] Apuntador(){
        int i=0;
        producto5[] apuntador = new producto5[100];
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

    public void Equeue(string pNombre, int pPrecio, string pColor, string pTalla, int pUnidades, string pImagen){
        referencia = cabecera;
        while(referencia.Siguiente != null){
            referencia = referencia.Siguiente;
        }

        NodoCola tmp = new NodoCola();
        tmp.Imagen = pImagen;
        tmp.Nombre = pNombre;
        tmp.Precio = pPrecio;
        tmp.Color = pColor;
        tmp.Talla = pTalla;
        tmp.Unidades = pUnidades;
        
        tmp.Siguiente = null;
        referencia.Siguiente = tmp;
    }

    public producto5[] Dequeue(){
        producto5[] dequeue = new producto5[1];
        //Realizar excepción (Si está vacio no hacer dequeue)
        if(cabecera.Siguiente != null){
            referencia = cabecera.Siguiente;
            dequeue[0].tmpimagen = referencia.Imagen;
            dequeue[0].tmpnombre = referencia.Nombre;
            dequeue[0].tmpprecio = referencia.Precio;
            dequeue[0].tmpcolor = referencia.Color;
            dequeue[0].tmptalla = referencia.Talla;
            dequeue[0].tmpunidades = referencia.Unidades;
            cabecera.Siguiente = referencia.Siguiente;
            referencia.Siguiente = null;
        }
        return dequeue;
    }

    public producto5[] Peek(){
        producto5[] peek = new producto5[1];
        if(cabecera.Siguiente != null){
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
}
}