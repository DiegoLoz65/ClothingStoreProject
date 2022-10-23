//Apuntador y añadir propiedades de una lista enlazada
// we will make a list 
using System;
namespace TiendaOnline.Models{
    public struct producto
    {
        public string tmpimagen;
        public string tmpnombre;
        public int tmpprecio;
        public string tmpcolor;
        public string tmptalla;
        public int tmpunidades;
    }
    
    public class ListaEnlazada{
        
        //Crear cabecera o Head
        private Nodo cabecera;

        //Crear variable de referencia nos ayuda a identificar 
        private Nodo referencia;

        //Creamos otra variable de referencia para que no se sobreescriba con la otra
        private Nodo referencia2;
        public ListaEnlazada() {
            //Instancia cabecera
            cabecera = new Nodo();
            cabecera.Siguiente = null;
            Adicionar("Buso", 75000, "Negro", "S,M,L,XL", 20, "https://i.ibb.co/DYsgt4X/Busp.jpg");
            Adicionar("Camisa", 40000, "Gris", "S,M", 13, "https://i.ibb.co/W0DQXsf/Camisa.jpg");
            Adicionar("Camiseta", 28000, "Blanca", "S,M,L", 25, "https://i.ibb.co/HFybLxf/Camiseta.jpg");
            Adicionar("Chaqueta", 120000, "Azul Claro", "S,M,L,XL", 25, "https://i.ibb.co/Rj7Wfsq/Chaqueta.jpg");
        }
        
        public producto[] Apuntador() {
            //Referencia al inicio
            
            referencia = cabecera;
            int contador = 0;
            while (referencia.Siguiente != null){
                referencia = referencia.Siguiente;
                contador++;
            }
            producto[] apuntador = new producto[contador];
            int i=0;
            referencia = cabecera;
            while (referencia.Siguiente != null){
                referencia = referencia.Siguiente;
                apuntador[i].tmpimagen = referencia.Imagen;
                apuntador[i].tmpnombre = referencia.Nombre;
                apuntador[i].tmpprecio = referencia.Precio;
                apuntador[i].tmpcolor = referencia.Color;
                apuntador[i].tmptalla = referencia.Talla;
                apuntador[i].tmpunidades = referencia.Unidades;
                i++;
            }
            for(i=0; i<contador; i++){
                Console.WriteLine(apuntador[i].tmpnombre);
            }
            
            return apuntador;
        }

        public producto[] Detail(string pNombre){
            referencia = cabecera;
            producto[] detail = new producto[1];
            while (referencia.Siguiente != null){
                referencia = referencia.Siguiente;
                if (referencia.Nombre == pNombre){
                    Console.WriteLine("EL PRODUCTO SI ESTÁ EN EL INVENTARIO");
                    detail[0].tmpimagen = referencia.Imagen;
                    detail[0].tmpnombre = referencia.Nombre;
                    detail[0].tmpprecio = referencia.Precio;
                    detail[0].tmpcolor = referencia.Color;
                    detail[0].tmptalla = referencia.Talla;
                    detail[0].tmpunidades = referencia.Unidades;
                }
            }
            return detail;
        }

        public void Editar(string pNombre, int pPrecio, string pColor, string pTalla, int pUnidades, string pImagen){
            referencia = cabecera;
            while (referencia.Siguiente != null){
                referencia = referencia.Siguiente;
                if (referencia.Nombre == pNombre){
                referencia.Imagen = pImagen;
                referencia.Nombre = pNombre;
                referencia.Precio = pPrecio;
                referencia.Color = pColor;
                referencia.Talla = pTalla;
                referencia.Unidades = pUnidades;
                }
            }
        }

        public void Adicionar(string pNombre, int pPrecio, string pColor, string pTalla, int pUnidades, string pImagen){
            referencia = cabecera; 
            while (referencia.Siguiente != null){
                referencia = referencia.Siguiente;
            }

            Nodo nuevoNodo =  new Nodo();
            nuevoNodo.Imagen = pImagen;
            nuevoNodo.Nombre = pNombre;
            nuevoNodo.Precio = pPrecio;
            nuevoNodo.Color = pColor;
            nuevoNodo.Talla = pTalla;
            nuevoNodo.Unidades = pUnidades;
            referencia.Siguiente = nuevoNodo;

        }
        //VACIAMOS LISTA
        public void Vaciar(){
            cabecera.Siguiente = null;
            // Recolector de basura 
        }

        //VALIDAMOS SI LA LISTA ESTÁ VACÍA
        public bool EstaVacia(){
            if (cabecera.Siguiente == null){
                return true;
            } else {
                return false;
            }
        }

        public Nodo Buscar(string pNombre){
            if (EstaVacia() == true) {
                return null;
            }
            referencia2 = cabecera;
            //Buscar un dato??, si se encuentra???
            while (referencia2.Siguiente != null){
                referencia2 = referencia2.Siguiente;
                //Lo buscamos por cada iteración
                //si lo encontramos lo retornamos
                if (referencia2.Nombre == pNombre){
                    Console.WriteLine("EL PRODUCTO SI ESTÁ EN EL INVENTARIO");
                    return referencia2;
                }
            }
            Console.WriteLine("NO SE HA ENCONTRADO EL PRODUCTO");
            return null;
        }
        
        public producto[] Search(string pNombre){
            referencia = cabecera;
            producto[] detail = new producto[1];
            while(referencia.Siguiente != null){
                referencia = referencia.Siguiente;
                if(referencia.Nombre == pNombre){
                    detail[0].tmpimagen = referencia.Imagen;
                    detail[0].tmpnombre = referencia.Nombre;
                    detail[0].tmpprecio = referencia.Precio;
                    detail[0].tmpcolor = referencia.Color;
                    detail[0].tmptalla = referencia.Talla;
                    detail[0].tmpunidades = referencia.Unidades;
                }
            }
            return detail;
        }


        public int BuscarIndice(string pNombre){
            int indice = -1; // 0 tomaría un valor indice en vector
            referencia = cabecera;
            while (referencia.Siguiente != null){
                referencia = referencia.Siguiente;
                indice++;
                if (referencia.Nombre == pNombre){
                return indice;
                }
            }
            return -1;
        }

        public Nodo BuscarAnterior(string pNombre){
            referencia2 = cabecera;
            while (referencia2.Siguiente != null && referencia2.Siguiente.Nombre != pNombre){
                referencia2 = referencia2.Siguiente;
            }
            return referencia2;
        }

        //BORRAR 
        public void Borrar(string pNombre){
            if (EstaVacia() == true){
                return;
            }
            Nodo anterior = BuscarAnterior(pNombre);
            Nodo encontrado = Buscar(pNombre);

            if (encontrado == null){
            return;
            }
            anterior.Siguiente = encontrado.Siguiente;
            encontrado.Siguiente = null;
        }

        //Insertar 
        //Cual es el nodo despues
        //Cual es el dato del nodo

        public void Insertar(string pDonde, string pNuevoNombre, int pNuevoPrecio, string pNuevoColor, string pNuevaTalla, int pNuevasUnidades){
            referencia = Buscar(pDonde);
            if (referencia == null){
                return;
            }

            Nodo tmp = new Nodo();
            tmp.Nombre = pNuevoNombre;
            tmp.Precio = pNuevoPrecio;
            tmp.Color = pNuevoColor;
            tmp.Talla = pNuevaTalla;
            tmp.Unidades = pNuevasUnidades;

            tmp.Siguiente = referencia.Siguiente;

            referencia.Siguiente = tmp;
        }
    
        public void InsertarInicio(string pNombre, int pPrecio, string pColor, string pTalla, int pUnidades){ 
            Nodo tmp = new Nodo();
            tmp.Nombre = pNombre;
            tmp.Precio = pPrecio;
            tmp.Color = pColor;
            tmp.Talla = pTalla;
            tmp.Unidades = pUnidades;
            tmp.Siguiente = cabecera.Siguiente;
            cabecera.Siguiente = tmp;
        }

        public Nodo ObtenerPorIndice(int pIndice){
            Nodo referencia3 = null;
            int indice = -1;
            referencia = cabecera;
            while(referencia.Siguiente != null){
                referencia = referencia.Siguiente;
                indice++;
                if(indice == pIndice){
                    referencia3 = referencia;
                }
            }
            return referencia3;
        }

        public Nodo this[int pIndice]{
            get{
                referencia = ObtenerPorIndice(pIndice);
                return referencia;
            }
            set{
                referencia = ObtenerPorIndice(pIndice);
                if (referencia != null){
                    referencia = value;
                }
            }
        }

        public int Cantidad(){
            referencia = cabecera;
            int contador = 0;
            while (referencia.Siguiente != null)
            {
                referencia = referencia.Siguiente;
                contador++;
            }
            return contador;
        }

        public void Intercambio(int indice1, int indice2, ListaEnlazada lista){
            Nodo tmp = new Nodo();
            tmp.Nombre = lista[indice1].Nombre;
            tmp.Color = lista[indice1].Color;
            tmp.Talla = lista[indice1].Talla;
            tmp.Unidades = lista[indice1].Unidades;
            tmp.Precio = lista[indice1].Precio;
            tmp.Imagen = lista[indice1].Imagen;

            lista[indice1].Nombre = lista[indice2].Nombre;
            lista[indice1].Color = lista[indice2].Color;
            lista[indice1].Talla = lista[indice2].Talla;
            lista[indice1].Unidades = lista[indice2].Unidades;
            lista[indice1].Precio = lista[indice2].Precio;
            lista[indice1].Imagen = lista[indice2].Imagen;

            lista[indice2].Nombre = tmp.Nombre;
            lista[indice2].Color = tmp.Color;
            lista[indice2].Talla = tmp.Talla;
            lista[indice2].Unidades = tmp.Unidades;
            lista[indice2].Precio = tmp.Precio;
            lista[indice2].Imagen = tmp.Imagen;
        }

        public void Burbuja(ListaEnlazada lista){
            int limite = 0; 
            int indice = 0;
            int cantidad = lista.Cantidad();
            int contadora = 0;
            //BURBUJA
            for (limite = 1; limite < cantidad; limite++) {
                for (indice = 0; indice < cantidad - limite; indice++){
                    if (String.CompareOrdinal(lista[indice+1].Nombre, lista[indice].Nombre) < 0){
                        Intercambio(indice, indice+1, lista);
                        contadora++;
                    }
                }
            }
            Console.WriteLine("CONTADORA ES: " + contadora);
        } 

        public void BurbujaPrecio(ListaEnlazada lista){
            int limite = 0; 
            int indice = 0;
            int cantidad = lista.Cantidad();
            int contadora = 0;
            //BURBUJA
            for (limite = 1; limite < cantidad; limite++) {
                for (indice = 0; indice < cantidad - limite; indice++){
                    if (lista[indice+1].Precio < lista[indice].Precio){
                        Intercambio(indice, indice+1, lista);
                        contadora++;
                    }
                }
            }
            Console.WriteLine("CONTADORA ES: " + contadora);
        }

        public void BurbujaUnidades(ListaEnlazada lista){
            int limite = 0; 
            int indice = 0;
            int cantidad = lista.Cantidad();
            int contadora = 0;
            //BURBUJA
            for (limite = 1; limite < cantidad; limite++) {
                for (indice = 0; indice < cantidad - limite; indice++){
                    if (lista[indice+1].Unidades < lista[indice].Unidades){
                        Intercambio(indice, indice+1, lista);
                        contadora++;
                    }
                }
            }
            Console.WriteLine("CONTADORA ES: " + contadora);
        }

        public void Insercion(ListaEnlazada lista){ 
            int indice = 0;
            int cantidad = lista.Cantidad();
            int posEspacio = 0;
            Nodo dato = new Nodo();
            // MÉTODO POR INSERCIÓN
                for(indice = 1; indice < cantidad; indice++){
                    //Obtener el dato
                    dato.Nombre = lista[indice].Nombre;
                    dato.Precio = lista[indice].Precio;
                    dato.Color = lista[indice].Color;
                    dato.Talla = lista[indice].Talla;
                    dato.Unidades = lista[indice].Unidades;
                    dato.Imagen = lista[indice].Imagen;

                    //Posición del espacio
                    posEspacio = indice;
                    //El while hace recorrido hasta la pos
                    while(posEspacio > 0 && String.CompareOrdinal(dato.Nombre, lista[posEspacio - 1].Nombre) < 0){
                        lista[posEspacio].Nombre = lista[posEspacio -1].Nombre;
                        lista[posEspacio].Precio = lista[posEspacio -1].Precio;
                        lista[posEspacio].Color = lista[posEspacio -1].Color;
                        lista[posEspacio].Talla = lista[posEspacio -1].Talla;
                        lista[posEspacio].Unidades = lista[posEspacio -1].Unidades;
                        lista[posEspacio].Imagen = lista[posEspacio -1].Imagen;
                        posEspacio--;
                    }
                    lista[posEspacio].Nombre = dato.Nombre;
                    lista[posEspacio].Precio = dato.Precio;
                    lista[posEspacio].Color = dato.Color;
                    lista[posEspacio].Talla = dato.Talla;
                    lista[posEspacio].Unidades = dato.Unidades;
                    lista[posEspacio].Imagen = dato.Imagen;
                }
        }
/*    
        public ListaEnlazada Merge(ListaEnlazada listaIzquierda, ListaEnlazada listaDerecha){
            //Para que Merge funcione, las dos listas deben estár ordenadas
            ListaEnlazada listaUnida = new ListaEnlazada();
            int indiceIzquierda = 0;
            int indiceDerecha = 0;
            int cantidadIzquierda = 0;
            int cantidadDerecha = 0;

            cantidadIzquierda = listaIzquierda.Cantidad();
            cantidadDerecha = listaDerecha.Cantidad();

            while (indiceIzquierda < cantidadIzquierda && indiceDerecha < cantidadDerecha){
                //Si el izquierdo es menor
                if (String.CompareOrdinal(listaIzquierda[indiceIzquierda], listaDerecha[indiceDerecha]) < 0){
                    listaUnida.Adicionar(listaIzquierda[indiceIzquierda]);
                    indiceIzquierda++;
                } else{
                    //Si el derecho es menor
                    listaUnida.Adicionar(listaDerecha[indiceDerecha]);
                    indiceDerecha++;
                }
            }
            //Si sobran elementos en lista izquierda
            while(indiceIzquierda < cantidadIzquierda){
                listaUnida.Adicionar(listaIzquierda[indiceIzquierda]);
                indiceIzquierda++;
            }
            //Si sobran elementos en la lista derecha
            while(indiceDerecha < cantidadDerecha){
                listaUnida.Adicionar(listaDerecha[indiceDerecha]);
                indiceDerecha++;
            }
            return listaUnida;
        }

        public ListaEnlazada MergeSort(ListaEnlazada pLista){
            int cantidad = pLista.Cantidad();
            int n = 0;

            //Caso Base
            if (cantidad < 2){
                return pLista;
            }
            
            int mitad = cantidad / 2;
            ListaEnlazada izquierda = new ListaEnlazada();
            ListaEnlazada derecha = new ListaEnlazada();
            
            for (n=0; n < mitad; n++){
                izquierda.Adicionar(pLista[n]);
            }

            for (n = mitad; n < cantidad; n++){
                derecha.Adicionar(pLista[n]);
            }

            //CasoInductivo
            ListaEnlazada tmpIzquierda = MergeSort(izquierda);
            ListaEnlazada tmpDerecha = MergeSort(derecha);

            ListaEnlazada ordenada = Merge(tmpIzquierda, tmpDerecha);

            return ordenada;
        }

        */

        public int Particion(int pInicio, int pFin, ListaEnlazada lista){
        Nodo pivote;
        int indicePivote = 0;
        int indiceComparacion = 0;

        pivote = lista[pFin];
        indicePivote = pInicio;
        for (indiceComparacion = pInicio; indiceComparacion < pFin; indiceComparacion++){
            if(String.CompareOrdinal(lista[indiceComparacion].Nombre, pivote.Nombre) < 0){
                Intercambio(indiceComparacion, indicePivote, lista);
                indicePivote++;
            }
        }

        Intercambio(indicePivote, indiceComparacion, lista);
        return indicePivote;
        }

        public void QuickSort(int pInicio, int pFin, ListaEnlazada lista){
        int indicePivote = 0;
        //Caso Base
        if (pInicio >= pFin){
            return;
        }

        indicePivote = Particion(pInicio, pFin, lista);
        //Caso Inductivo
        QuickSort(pInicio, indicePivote - 1, lista);
        QuickSort(indicePivote + 1, pFin, lista);
        }
    }
}