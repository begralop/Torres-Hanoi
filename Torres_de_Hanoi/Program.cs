using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("¿Qué algoritmo es el que quiere utilizar? Pulse 1 para utilizar el iterativo o 2 para utilizar el recursivo"); // Preguntamos al usuario
            int tipoAlgtm = Convert.ToInt32(Console.ReadLine()); // Almacenamos en una variable tipo int la respuesta del usuario
            Console.WriteLine(" "); // Espacio vacío para que el código se vea más claro y no todo junto

            if(tipoAlgtm <= 0 || tipoAlgtm >= 3) { // Si el valor de tipoalg es menor o igual a cero o mayor o igual a 0
                Console.WriteLine("No has introducido ni 1 ni 2, lo siento, adiós."); // Mandamos mensaje
                Console.WriteLine("Press enter to close"); 
                Console.ReadLine(); // Cerramos el programa
            }

            else // si es 1 o 2 entonces
            {
            int numDiscos; // Variable tipo int para almacenar el numero de discos

            do // Bucle hasta que sea mayor que 0
            {
                Console.WriteLine("¿Cuántos discos quieres insertar?"); // Preguntamos al usuario
           
                numDiscos = Convert.ToInt32(Console.ReadLine()); // Almacenamos en la variable la respuesta del usuario
                Console.WriteLine(" "); // Espacio vacío para que el código se vea más claro y no todo junto

                if (numDiscos == 0) // Si el numero de discos es 0
                {
                    Console.WriteLine("¿Realmente quisiste escribir 0? Es imposible repartir algo inexistente. Vuelva a intentarlo.");
                    Console.WriteLine(" "); // Espacio vacío para que el código se vea más claro y no todo junto

                }

                if (numDiscos < 0) // Si el numero de discos es menor que 0
                {
                    Console.WriteLine("¿Realmente quiso escribir un número negativo? Si ya es imposible repartir algo inexistente, imagíneses algo negativo, vuelva a intentarlo.");
                    Console.WriteLine(" "); // Espacio vacío para que el código se vea más claro y no todo junto

                }

            } while (numDiscos <= 0); // Mientras el numero de discos sea 0 o menor

            Disco[] discosTotales = new Disco[numDiscos]; // Inicializamos un nuevo array de discos pasándole el int que ha introducido el usuario anteriormente

            if(numDiscos > 0) // Si el número de discos es mayor que 0
            {
                for (int i = 0; i < numDiscos; i++) // bucle que recorre todas las posiciones de 0 al valor que ha introducido el usuario
                { 
                    discosTotales[i] = new Disco(i); // por cada casilla creará un nuevo disco
                }

                Pila pila1 = new Pila(); // Nuevo objeto pila
                pila1.nombre = "Pila inicial"; // Le asignamos el nombre de pila inicial
                Pila pila2 = new Pila(); // Nuevo objeto pila
                pila2.nombre = "Pila auxiliar"; // Le asignamos el nombre de pila aux
                Pila pila3 = new Pila(); // Nuevo objeto pila
                pila3.nombre = "Pila final"; // Le asignamos el nombre de pila final

                for (int i = discosTotales.Length; i > 0; i--) // Bucle que recorre el tamaño de discos totales hacia atrás
                { 
                    pila1.push(discosTotales[i - 1]); // Método push de la clase pila para añadir todos los discos a la pila 1
                }

                Hanoi torres_hanoi = new Hanoi(); // Nuevo objeto Hanoi

                if (tipoAlgtm == 1) // Si la respuesta del usuario al principio es uno
                {

                    int sol_it = torres_hanoi.iterativo(numDiscos, pila1, pila3, pila2); // Llamamos al metodo iterativo y le pasamos los parámetros
                    Console.WriteLine(" "); // Espacio vacío para que el código se vea más claro y no todo junto
                    Console.WriteLine("Se hizo en: " + sol_it + " movimientos"); // Muestra por pantalla 
                }

                if (tipoAlgtm == 2) // Si la respuesta del usuario al principio es dos
                {
                    int sol_res = torres_hanoi.recursivo(numDiscos, pila1, pila3, pila2); // Llamamos al metodo recursivo y le pasamos los parámetros
                    Console.WriteLine(" "); // Espacio vacío para que el código se vea más claro y no todo junto
                    Console.WriteLine("Se hizo en: " + sol_res + " movimientos"); // Muestra por pantalla  
                }


            }
            }
        }
    }
}
