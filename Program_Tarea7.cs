using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea7
{/*
Tarea Corta
Las tareas cortas consisten de resolver simples problemas de programacion, para buscar que los estudiantes 
desarrollen su logica de programacion y logica matematica.
Cada tarea tendra un id, el metodo de entrega sera el siguiente:
1. Los estudiantes deben crear un proyecto en github, al que subiran todas las tareas que deseen sean evaluadas.
2. Los estudiantes van a crear un board en waffle, las tareas que esten en waffle seran revisadas por el profesor.
3. Las tareas serán asignadas al profesron una vez que el código sea terminado por el estudiante, en ese momento el profesor procederá a revisarlas y asignarles una calificación
4. Las tareas son simples, por lo que se requerirá que el entregable sea un solo archivo .cs, en dicho archivo debe estar el presente encabezado
5. El estudiante debe rellenar el encabezado posterior al presente con sus datos personales.\\
6. Junto con el codigo, en comentarios de la documentacion interna debe haber una explicacion de porque escogieron esa solucion, y porque creen que esa es la solucion optima
7. De existir otras soluciones, especificar porque no se utilizaron.
8. Pueden utilizar cualquier funcion que las librerias de .Net ofrezcan, pero deben especificar porque la utilizacion de esas librerias mejoran el rendimiento de su solucion.
*/

    /*
        Tarea Corta 7
        Estudiante: [Jose David Alvarez Vega]

        Enunciado:
        Dado un arreglo de longitud N, retornar un arreglo que contenga los K caracteres mas frecuentes.
        Ejemplo:
        [1,2,3,4,3,2,5], 2 -> Queremos los dos caracteres mas frecuentes del arrelgo
        Resultado -> [2,3] 
    */

    //Your code starts here
    class Program
    {
        static void Main(string[] args)
        {
            int elemento1 = 0;// variable1
            int elemento2 = 0;//variable2
            int num = 0; //variable de apoyo
            Console.WriteLine("Cuantos numeros va ingresar");//impresion en pantalla
            int numeros = int.Parse(Console.ReadLine());//lectura por teclado
            for (int i = 0; i < numeros; i++)// ciclo que recorre ls numeros ingresados
            {
                Console.WriteLine("Digite un numero: ");//impresion en pantalla
                num = int.Parse(Console.ReadLine());//ciclo que analiza los caracteres  repetidos

                if (i == 0) //condicion 1
                {
                    elemento1 = num;//
                    elemento2 = num;//
                }
                else if (num > elemento1)//condicion 2
                {
                    elemento1 = num;
                }
                else if (num < elemento2)//condicion 3
                {
                    elemento2 = num;
                }
                num = 0;
            }
            Console.WriteLine("[" + elemento1 + " , " + elemento2 + "]");//imprsion de los dos elementos
            Console.ReadKey();//espera el llamdo de cualquier tecla para salir
        }
    }
}
        