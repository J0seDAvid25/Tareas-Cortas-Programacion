using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
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
        Tarea Corta 4
        Estudiante: [Jose David Alvarez Vega]

        Enunciado:
        Haga una funcion que identifique si una cadena de caracteres es un palindromo. 
        La funcion debe recibir un string con la palabra y retornar un booleano que indique si es un palindromo o no
        Palindromo: https://es.wikipedia.org/wiki/Pal%C3%ADndromo
    */

    //
    class Program

    {
        //public static bool EsPalidromo(string frase)
        //{
        //    if (frase.Length == 0|| frase.Length == 1)
        //    {
        //        string resultado = frase.Substring(1, frase.Length - 2);
        //    }
        //    return frase[0] == frase[frase.Length - 1] && EsPalidromo(resultado);
        //}
        ////usa eso para invetir y si son iguales es palindromo

        public static void Main(string[] args)
        {
            Console.WriteLine("====================================================");
           Console.WriteLine(".-Palindromo");
            Console.Write("Ingrese una frase: ");
            string cadena = Console.ReadLine(); //lectura
            cadena = cadena.Trim(); // borrado 
            Palindrome p = new Palindrome(cadena); 
            Console.WriteLine("La cadena invertida es '" + p.Invertir() + "'"); //impresion 
            p.esPalindrome(); // llamado de metodo
            Console.ReadLine();// pausa
         
        }
    }
    class Palindrome
    {
        string Texto = ""; //variable auxiliar
        public Palindrome(string texto)
        {
            this.Texto = texto;
        }
        public string Invertir()
        {
            string aux = "";
            //Recorremos el string en orden inverso 
            for (int i = Texto.Length - 1; i >= 0; i--)
            {
                aux += Texto[i];
            }
            //retornamos la nueva cadena 
            return aux;
        }

        public string Invertir(string palabra)
        {
            string aux = "";
            //Recorremos el string en orden inverso 
            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                aux += palabra[i];
            }
            //retornamos la nueva cadena 
            return aux;
        }

        public void esPalindrome() //impresion
        {
            if (Texto != Invertir())
            {
                Console.WriteLine("La frase invertida No es palindrome");
            }
            else
            {
                Console.WriteLine("La frase invertida Si es palindrome");
            }
        }


    }
}

