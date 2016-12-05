﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{/* 
Tarea Corta
Las tareas cortas consisten de resolver simples problemas de programacion, para buscar que los estudiantes
desarrollen su logica de programacion y logica matematica.
Cada tarea tendra un id, el metodo de entrega sera el siguiente:
1. Los estudiantes deben crear un proyecto en github, al que subiran todas las tareas que deseen sean evaluadas.
2. Los estudiantes van a crear un board en waffle, las tareas que esten en waffle seran revisadas por el profesor.
3. Las tareas serán asignadas al profesron una vez que el código sea terminado por el estudiante, en ese momento el profesor procederá a revisarlas y asignarles una calificación
4. Las tareas son simples, por lo que se requerirá que el entregable sea un solo archivo.cs, en dicho archivo debe estar el presente encabezado
5. El estudiante debe rellenar el encabezado posterior al presente con sus datos personales.\\
6. Junto con el codigo, en comentarios de la documentacion interna debe haber una explicacion de porque escogieron esa solucion, y porque creen que esa es la solucion optima
7. De existir otras soluciones, especificar porque no se utilizaron.
8. Pueden utilizar cualquier funcion que las librerias de .Net ofrezcan, pero deben especificar porque la utilizacion de esas librerias mejoran el rendimiento de su solucion.
    Tarea Corta 3
	Estudiante: [Jose David Alvarez Vega]
	
	Enunciado:
	Cree una funcion que identifique si un elemento existe en una lista, debe retornar la cantidad de veces que el elemento aparece en la lista, retornara 0 si no aparece.
*/

    //Your code starts here
    public class Program
    {
        public static bool Pertenece(int numero, int[] array)
        {
            
            // Recorremos todas las posiciones del array desde
            // 0 hasta "array.Lenght", que nos da la longitud.
            for (int i = 0; i < array.Length; i++)
            {
                int cont = 0;
                // Preguntamos si el elemento en la posición i del array es igual al número que buscamos.
                if (array[i] == numero)// En caso de que encontremos el número devolvemos true.
                    cont++;

                Console.WriteLine("Numeros de veces repetidos: {0}", cont);
                return true;
            

            }
            
            // Retornamos false si no está el número
            Console.WriteLine("El numero no está");
            return false;
        }         

        static void Main(string[] args)
        {
            Program registro = new Program();
            int[] numeros = {6,10,4,20,97,4,14,6 };
            bool dime = Pertenece(7,numeros);
            Console.WriteLine(dime);
            Console.ReadKey();

        }
    }
}
