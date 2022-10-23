using System;
namespace TiendaOnline.Models{
    public struct producto3
    {
        public int tmpdato;
        public string tmpimagen;
        public string tmpnombre;
        public int tmpprecio;
        public string tmpcolor;
        public string tmptalla;
        public int tmpunidades;
    }
    
    public class Arbol{
    
    private NodoArbol raiz;
    private NodoArbol referencia;

    private NodoArbol hoja;
    private int i = 0;
    private int j = 0;
    private int contador = 0;
    private int contador2 = 0;
    public Arbol(){
        raiz = new NodoArbol();
        hoja = new NodoArbol();
        hoja = Insertar("RAIZ", 1000, "RAIZ", "RAIZ",  1000, "RAIZ", null);
        
        Insertar("Tapabocas Hombre", 40000, "Blanco", "Estandar", 50, "https://i.ibb.co/KGVTxCf/Tapabocas-Hombre.jpg", hoja);
        Insertar("Tapabocas Mujer", 40000, "Blanco", "Estandar", 40, "https://i.ibb.co/3MJyxtd/Tapabocas-Mujer.jpg", hoja);
        Insertar("Tapabocas Niños", 35000, "Blanco", "Estandar", 35, "https://i.ibb.co/dbTwRs1/Tapabocas-Ni-os.jpg", hoja);
        Insertar("Tapabocas Unisex", 30000, "Blanco", "Estandar", 20, "https://i.ibb.co/vhPQ4xQ/Tapabocas-Unisex.jpg", hoja);
    }

    public NodoArbol Insertar(string pNombre, int pPrecio, string pColor, string pTalla, int pUnidades, string pImagen, NodoArbol pNodo){
        if(pNombre == "RAIZ" &&(contador!=0)){
            return raiz;
        }
        // Si no hay un nodo dónde insertar, hagalo en la raiz
        if (pNodo == null){
            raiz = new NodoArbol();
            raiz.Imagen = pImagen;
            raiz.Nombre = pNombre;
            raiz.Precio = pPrecio;
            raiz.Color = pColor;
            raiz.Talla = pTalla;
            raiz.Unidades = pUnidades;
            raiz.Hijo = null;
            raiz.Hermano = null;
            contador++;
            return raiz;
        }

        //Si tiene hijo
        if (pNodo.Hijo == null){
            NodoArbol tmp = new NodoArbol();
            tmp.Imagen = pImagen;
            tmp.Nombre = pNombre;
            tmp.Precio = pPrecio;
            tmp.Color = pColor;
            tmp.Talla = pTalla;
            tmp.Unidades = pUnidades;
            pNodo.Hijo = tmp;
            return tmp;
        } else {
            // Como un hermano
            referencia = pNodo.Hijo;
            while(referencia.Hermano != null){
                referencia = referencia.Hermano;
            } 
            NodoArbol tmp = new NodoArbol();
            tmp.Imagen = pImagen;
            tmp.Nombre = pNombre;
            tmp.Precio = pPrecio;
            tmp.Color = pColor;
            tmp.Talla = pTalla;
            tmp.Unidades = pUnidades;
            referencia.Hermano = tmp;

            return tmp;
        }
    }

    //Transversa preorder
    /*
    ** DE ARRIBA HACIA ABAJO
    */
    
    public producto3[] ApuntadorPreOrden(NodoArbol pNodo, producto3[] apuntador){
        j++;
        
        Console.WriteLine("J INICIAL = "+ j);
            apuntador[j].tmpnombre = pNodo.Nombre;
            Console.WriteLine("MUESTRA HIJO" + apuntador[j].tmpnombre);
            apuntador[j].tmpimagen = pNodo.Imagen;
            apuntador[j].tmpprecio = pNodo.Precio;
            apuntador[j].tmpcolor = pNodo.Color;
            apuntador[j].tmptalla = pNodo.Talla;
            apuntador[j].tmpunidades = pNodo.Unidades;
            
            Console.WriteLine("J FINAL = "+ j);
        // Caso Base
        if(pNodo == null){
            
            return apuntador;
        }

        for(int n = 0; n < i; n++){
            Console.Write(" ");
        }

        //RAIZ Y/O NODO PADRE
        
        //HIJOS PROCESEN
        if(pNodo.Hijo != null){
            i++; // INCREMENTO PARA CONOCER PROFUNDIDAD
            
            
            ApuntadorPreOrden(pNodo.Hijo, apuntador);
            i--;
        }

        //SI TENGO HERMANOS
        if(pNodo.Hermano != null){
            

            ApuntadorPreOrden(pNodo.Hermano, apuntador);
        }
        //ACÁ NUNCA VA A LLEGAR
            
        return apuntador;
    }


    //Transversa PostOrder
    /*
    ** DE ABAJO HACIA ARRIBA
    */
    

    /*public NodoArbol Buscar(string pDato, NodoArbol pNodo){
        NodoArbol encontrado = null;
        //Caso Base
            if(pNodo == null){
                return encontrado;
            }
        //Caso Base
            if(pNodo.Dato.CompareTo(pDato) == 0){
                encontrado = pNodo;
                return encontrado;
            }

        //Caso Inductivo Procesar los hijos
            if (pNodo.Hijo != null){
                encontrado = Buscar(pDato, pNodo.Hijo);
                if(encontrado != null){
                    return encontrado;
                }
            }
        
        //Caso Inductivo Procesar los hermanos
        if(pNodo.Hermano != null){
            encontrado = Buscar(pDato, pNodo.Hermano);
            if(encontrado != null){
                return encontrado;
            }
        }
        return encontrado;
    }*/

    public producto3[] Search(string pNombre, producto3[] apuntador){
        producto3[] detail = new producto3[1];
        int u=0;
        while(apuntador[u].tmpnombre != pNombre){
            u++;
            if(u==1000){
        detail[0].tmpimagen = null;
        detail[0].tmpnombre = null;
        detail[0].tmpprecio = 0;
        detail[0].tmpcolor = null;
        detail[0].tmptalla = null;
        detail[0].tmpunidades = 0;
        return detail;
            }
        }
        detail[0].tmpimagen = apuntador[u].tmpimagen;
        detail[0].tmpnombre = apuntador[u].tmpnombre;
        detail[0].tmpprecio = apuntador[u].tmpprecio;
        detail[0].tmpcolor = apuntador[u].tmpcolor;
        detail[0].tmptalla = apuntador[u].tmptalla;
        detail[0].tmpunidades = apuntador[u].tmpunidades;

        return detail;
    }

    /*public producto3[] Edit(string pNombre, int pPrecio, string pColor, string pTalla, int pUnidades, producto3[] apuntador){
        
        int u=0;
        while(apuntador[u].tmpnombre != pNombre){
            u++;
        }
        apuntador[u].tmpprecio = pPrecio;
        apuntador[u].tmpcolor = pColor;
        apuntador[u].tmptalla = pTalla;
        apuntador[u].tmpunidades = pUnidades;
        return apuntador;
    }*/

    public void Edit(string pNombre, int pPrecio, string pColor, string pTalla, int pUnidades, string pImagen, NodoArbol pNodo){
        
        //Caso Base
            if(pNodo == null){
                Console.WriteLine("RAIZ NULL");
                return;
            }
        //Caso Base
            Console.WriteLine("PRODUCTOS QUE PASAN A SER ANALIZADOS " + pNodo.Nombre);
            if(pNodo.Nombre == pNombre){
                pNodo.Precio = pPrecio;
                pNodo.Imagen = pImagen;
                pNodo.Color = pColor;
                pNodo.Talla = pTalla;
                pNodo.Unidades = pUnidades;
            }

        //Caso Inductivo Procesar los hijos
            if (pNodo.Hijo != null){
                Edit(pNombre, pPrecio, pColor, pTalla, pUnidades, pImagen, pNodo.Hijo);
            }
        
        //Caso Inductivo Procesar los hermanos
        if(pNodo.Hermano != null){
            Edit(pNombre, pPrecio, pColor, pTalla, pUnidades, pImagen, pNodo.Hermano);
        }
 
    }
}
}