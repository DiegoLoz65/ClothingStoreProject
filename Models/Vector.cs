using System;
namespace TiendaOnline.Models{
    public struct producto2{
            public int tmpdato;
            public string tmpimagen;
            public string tmpnombre;
            public int tmpprecio;
            public string tmpcolor;
            public string tmptalla;
            public int tmpunidades;
        }

    public class Vector{
        
        
        public int posicion=0;
        public int contador=0;
        
        public producto2[] vector = new producto2[100];
        public Vector(){
            Adicionar("Buso", 70000, "Rosado", "S,M,L,XL", 15, "https://i.ibb.co/zs8PWfQ/Buso.jpg");
            Adicionar("Camiseta", 35000, "Negro", "S,M,L", 25, "https://i.ibb.co/TBdLgZH/Camiseta.jpg");
            Adicionar("Chaqueta", 90000, "Azul", "M,L", 19, "https://i.ibb.co/zN8SCsW/Chaqueta.jpg");
            Adicionar("Falda", 45000, "Blanca", "26,28", 30, "https://i.ibb.co/ZxN4S83/Falda.jpg");


        }
        public void Adicionar(string pNombre, int pPrecio, string pColor, string pTalla, int pUnidades, string pImagen){
            vector[posicion].tmpimagen = pImagen;
            vector[posicion].tmpnombre = pNombre;
            vector[posicion].tmpprecio = pPrecio;
            vector[posicion].tmpcolor = pColor;
            vector[posicion].tmptalla = pTalla;
            vector[posicion].tmpunidades = pUnidades;
            posicion++;
            contador++;
        }

        public producto2[] Apuntador(){
            return vector;
        }

        public producto2[] Detail(string pNombre){
            producto2[] vectortmp = new producto2[5];
            int i =0;
            while(i<5){
                if(vector[i].tmpnombre == pNombre){
                    vectortmp[0].tmpimagen = vector[i].tmpimagen;
                    vectortmp[0].tmpnombre = vector[i].tmpnombre;
                    vectortmp[0].tmpprecio = vector[i].tmpprecio;
                    vectortmp[0].tmpcolor = vector[i].tmpcolor;
                    vectortmp[0].tmptalla = vector[i].tmptalla;
                    vectortmp[0].tmpunidades = vector[i].tmpunidades;
                }
                i++;
            }
            return vectortmp;
        }

        public void Editar(string pNombre, int pPrecio, string pColor, string pTalla, int pUnidades, string pImagen){
            int i =0;
            while(i<5){
                if(vector[i].tmpnombre == pNombre){
                    vector[i].tmpnombre = pNombre; 
                    vector[i].tmpprecio = pPrecio;
                    vector[i].tmpcolor = pColor;
                    vector[i].tmptalla = pTalla;
                    vector[i].tmpunidades = pUnidades;
                    vector[i].tmpimagen = pImagen;
                }
                i++;
            }
        }

        public void Eliminar(string pNombre){
            int aBorrar=-1;
            int i = 0;
            for (i=0; i<50; i++){
                if (vector[i].tmpnombre == pNombre){
                    aBorrar = i;
                    break;
                }
            }

            if(aBorrar < 0){
                //NO hay elemento
                return;
            }
            else{
                for(i=aBorrar+1; i<50; i++){
                    vector[i-1] = vector[i];
                }
            }
        }

        public producto2[] Search(string pNombre){
            producto2[] vectortmp = new producto2[5];
            int i =0;
            while(i<5){
                if(vector[i].tmpnombre == pNombre){
                    vectortmp[0].tmpimagen = vector[i].tmpimagen;
                    vectortmp[0].tmpnombre = vector[i].tmpnombre;
                    vectortmp[0].tmpprecio = vector[i].tmpprecio;
                    vectortmp[0].tmpcolor = vector[i].tmpcolor;
                    vectortmp[0].tmptalla = vector[i].tmptalla;
                    vectortmp[0].tmpunidades = vector[i].tmpunidades;
                }
                i++;
            }
            return vectortmp;
        }
    }
}
