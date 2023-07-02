using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    public class clsDPilaS
    {
        //Atributos
        private const int max = 20;// el maximo de mi arreglo
        private const int n = 4; //la cantidad de pilas
        private const int u = max / n; //la cantidad de elementos de cada pila
        private int[] V;   //arreglo de la pila
        private int[] B;   //almacena el inicio y fin de cada pila
        private int[] S;   //el tamanio de cualquier S
        private int[] T;   //almacena el top 

        //Create()-->Pila //Crea una DoblePila
        public clsDPilaS()
        {
            V = new int[max];
            B = new int[n+1];
            S = new int[n];
            T = new int[n];
            for (int j = 0; j < max; j++)
            {
                V[j] = 0;
            }
            int i = 0;
            while (i<n)
            {
                B[i] = (u * i);
                T[i] = (u * i)-1;
                S[i] = (u * i)-1;
                i++;
            }
            B[i] = max;
        }
        //2 Add(i,x)-->Pila //Adiciona el elemento x a la Pila i (10 ptos)
         //                 1       5
        public void Add(int i, int x)
        {
            if (!IsFull(i))// si no esta  llena pila i=1
            {
                T[i]++;
                V[T[i]] = x;

            }
        }
        //3. DelTop(i)-->Pila //Borra el elemento tope de la Pila i (15 ptos)
        public void DelTop(int i)
        {
            if (!IsVacia(i))// si no esta  vacia pila i = 1
            {
                T[i]--;
            }
        }
        //4. DelFon(i)-->Pila //Borra el elemento del fondo de la Pila i (15 ptos)
        public void DelFon(int i)
        {
            if (!IsVacia(i))// si no esta  vacia pila i = 1
            {
                S[i]++;
            }
        }
        //5. IsVacia(i)-->Boolean // Es TRUE si la Pila i esta vacía, de lo contrario es FALSE. (10 ptos)
        public bool IsVacia(int i)
        {
            return S[i] == T[i];
        }


        // 6. IsFull(i)--> Boolean //Es TRUE si la Pila i esta llena, de lo contrario es FALSE. (10 ptos)
       
        
        
        
        public bool IsFull(int i)
        {
            return T[i] == B[i+1];
        }
        //7. LongEle(i) --> N // Cuantos elemento tiene la Pila i (40 pts
        public int LongEle(int i)
        {
            return (T[i]-B[i])-(S[i]-B[i]);
        }


        public string Mostrar()
        {
            string salida = "V: [";
            for (int i = 0; i < n; i++)
            {
                for (int j = S[i] + 1; j <= T[i]; j++)
                {
                    salida = salida + V[j] + "|";
                }
            }
            salida = salida.Substring(0, salida.Length - 1);
            return salida +"]";
        }
    }
}
