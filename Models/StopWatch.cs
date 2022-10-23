using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TiendaOnline.Models
{
    
    public class StopWatch
    {
        public string aleatorio()
        {
            
        Random obj = new Random();
        string sCadena = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        int longitud = sCadena.Length;
        char cletra;
        int nlongitud = 26;
        string sNuevacadena = string.Empty;
        
        for (int i = 0; i < nlongitud; i++)
        {
            cletra = sCadena[obj.Next(nlongitud)];
            sNuevacadena += cletra.ToString();
        }
        return sNuevacadena;
        }

        public string[] vectorrandompro(){
            string[] vectorrandom = new string[26];
            for(int i=0; i<26;i++){
                vectorrandom[i] = aleatorio();
            }
            return vectorrandom;
        }

        public string[] vectorrandomord(){
            string[] vectorrandom_ord = new string[26];
            for(int i=0; i<26;i++){
                vectorrandom_ord[i] = aleatorio();
            }
            Burbuja(vectorrandom_ord);
            return vectorrandom_ord;
        }

        public string[] vectoriguales(){
            string[] vectoriguales = new string[26];
            for(int i=0; i<26;i++){
                vectoriguales[i] = "café";
            }

            return vectoriguales;
        }

        public float[] resultados(string pPalabra){
            Stopwatch time = new Stopwatch();
            float[] resultados = new float[10];
            int contador=0;
            string[] vector_ordenado = new string[26];
            vector_ordenado = vectorrandomord();
            string[] vector_random = new string[26];
            vector_random = vectorrandompro();
            string[] vector_iguales = new string[26];
            vector_iguales = vectoriguales();
            //Busqueda lineal
                //VECTOR ORDENADO
            time.Start();
            for(int i=0; i<26;i++){
                if(vector_ordenado[i] == pPalabra){
                    time.Stop();
                    resultados[contador] = time.ElapsedTicks;
                    contador++;
                    break;
                }
            }
            time.Stop();
            resultados[contador] = time.ElapsedTicks;
            contador++;    
            time.Reset();
            //VECTOR RANDOM
            time.Start();
            for(int i=0; i<26;i++){
                if(vector_random[i] == pPalabra){
                    time.Stop();
                    resultados[contador] = time.ElapsedTicks;
                    contador++;
                    break;
                }
            }
            time.Stop();
            resultados[contador] = time.ElapsedTicks;
            contador++;
            time.Reset();

            //VECTOR IGUALES
            time.Start();
            for(int i=0; i<26;i++){
                if(vector_iguales[i] == pPalabra){
                    time.Stop();
                    resultados[contador] = time.ElapsedTicks;
                    contador++;
                    break;
                }
            }
            time.Stop();
            resultados[contador] = time.ElapsedTicks;
            contador++;



            return resultados;
        }

        public void Intercambio(int indice1, int indice2, string[] vector){
            string tmp = vector[indice1];
            vector[indice1] = vector[indice2];
            vector[indice2] = tmp;
        }

        public void Burbuja(string[] vector){
            int limite = 0; 
            int indice = 0;
            int cantidad = 26;

            //BURBUJA
            for (limite = 1; limite < cantidad; limite++) {
                for (indice = 0; indice < cantidad - limite; indice++){
                    if (String.CompareOrdinal(vector[indice+1], vector[indice]) < 0){
                        Intercambio(indice, indice+1, vector);
                    }
                }
            }
        }

        
                 
    }
}
