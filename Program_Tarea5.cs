using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5
{
    /*
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
        Tarea Corta 1
        Estudiante: [Jose David Alvarez Vega]

        Enunciado:
        Haga una funcion que compare versiones, retornando -1 si el primer numero es mayor, 1 si el segundo numero es mayor y 0 y son iguales.
        Pueden asumir que los strings solo contienen numeros y el caracter '.'
        No hay un limite para la cantidad de subversiones que se pueden enviar: 1.1.1.1.1.1.1.1.1.1 es valido.
        0.1 < 1.0 < 1.0.1

    */

    //Your code starts here
    class Program
    {
        public int ComparaVers()
        {
            Console.WriteLine("***Comparación de versiones***"); //titulo
            string vers1 = "1.0.2.7";//array 1
            String vers2 = "1.0.2.2";//array 2
            var version1 = new Version(vers1); //instnacia del array 1
            var version2 = new Version(vers2);   //         instancia del array2
            var Comparacion = vers1.CompareTo(vers2);// metodo para comparar ambos array 
            if (Comparacion > 0)// condicion
            {
                Console.WriteLine(".-La version 1 es mayor que la version 2");//impresion de la primera condicion
            }
            else if (Comparacion < 0)
            {
                Console.WriteLine(".-La version 2 es mayor que la version 1");//impresion de la segunda condicion
            }
            else
                Console.WriteLine(".-Las dos versiones son diferentes o iguales");//impresion de la tercera y ultima condicion

            return Comparacion;
        }
        static void Main(string[] args)
        {
            Program Cversiones = new Program();
            int val = Cversiones.ComparaVers();
            Console.ReadLine();

        }

    }
}
