using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea9
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
*//*
	Tarea Corta 1
	Estudiante: [Jose David Alvarez Vega]	
	Enunciado:
	Rotacion de palabras en un string: Al recibir un string, se debe retornar un nuevo string en el que se roten sus palabras.
	Ejemplo:
	"the sky is blue" -> "blue is sky the"	
*/
    //Your code starts here
    class Program
    {
        public string rotacion(string [] array)// metodo
        {
            string aux = array[0];            //variable auxiliar
            Console.WriteLine("====================================================");//impresion
            Console.WriteLine("Impresion Normal");  			//impresion
            foreach (string palabras in array) //lectura e impresion, ciclo foreach para recorrer todas las palabras en el array
            {
                Console.WriteLine(palabras);  //impresion
            }
            // Impresion.
            Console.WriteLine("===================================================="); //impresion
            Console.WriteLine("Impresion Reverso");

            Array.Reverse(array); // Reverso.  // llama el reverso del arreglo
            foreach (string palabras in array) //  Lectura de las palabras e Impresion invertida
            {
                Console.WriteLine(palabras); ////impresion
            }
            return aux; //retorno de la variable auxiliar declarar al inicio
        }
        
        static void Main(string[] args)
        {
            Program Arr = new Program();
            Console.WriteLine(".-Rotacion de palabras");              
            string[] arreglo= { "the", "sky", "is" ,"blue" }; //arreglo ingresado
            string val = Arr.rotacion(arreglo);
            Console.ReadKey();
        }
    }
}
