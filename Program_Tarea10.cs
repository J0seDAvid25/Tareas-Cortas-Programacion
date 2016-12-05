using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
	Tarea Corta 10
	Estudiante: [Jose David Alvarez Vega]
	
	Enunciado:
	Inversion de un string: Al recibir un string S, retornar un string cuyas letras estan invertidas, sin invertir el orden de las palabras.
	"The Sky is Blue" -> "ehT ykS si eulB"
*/

//Your code starts here
namespace Tarea10
{
    class InversionLetras
    {
        public string inversion(string cad)//
        {
            string auxiliar = "";
        int mensaje = cad.Length; //variable "externa" 
        string[] split = cad.Split(new Char[] { ' ' }); //split para cada espacio
        for (int i = mensaje - 2; i >= 0; i--) // ciclo for para leer la variable mensaje 
            {
                auxiliar = auxiliar + cad.Substring(i, 1); //variable auxiliar se le agrega el valor de auxiliar mas posicion en i 
            }
    Console.WriteLine("La palabra invertida es:\n" + auxiliar); //impresion
            return cad;
            //Sinceramente no supé como darle vuelta a cada letra 
        }

static void Main(string[] args)
        {
            InversionLetras inv = new InversionLetras();
            String cad = "The Sky is Blue";
            string val = inv.inversion(cad);
            Console.ReadLine();            
        }
    }
}

