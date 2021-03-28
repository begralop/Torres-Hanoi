using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {

        int movimientos = 0; // Variable global movimientos inicializada en 0 que almacena la cantidad de movimientos que se realiza

        public void mover_disco(Pila a, Pila b) // Método mover_disco que se le pasan dos pilas que es a las que se va a hacer el movimiento
        {
            if (a.Top < b.Top) // Si el disco superior de la pila a es menor que el de la b el movimiento se hace de a a b
            {
                Disco d = a.pop();
                b.push(d); // Aquí se hace el movimiento con los métodos push y pop de la clase pila
                Console.WriteLine("El disco " + d.valor + " se mueve de la " + a.nombre + " a la " + b.nombre);
            }
            else // En caso de que el disco superior de b sea menor que el de a, el movimiento se hace de la pila a b la pila a
            {
                Disco d = b.pop();
                a.push(d); // Aquí se hace el movimiento con los métodos push y pop de la clase pila
                Console.WriteLine("El disco " + d.valor + " se mueve de la " + b.nombre + " a la " + a.nombre);
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux) // Método iterativo, recibe un nº de discos y las 3 pilas
        {
            if (n % 2 == 0) // Si el número de discos entre 2 es 0 (es decir par)
            {
                while (fin.Size != n) // Hacemos los siguientes movimientos hasta que la pila fin tenga el nº de discos iniciales
                {
                    mover_disco(ini, aux); // El primer movimiento es de la pila ini a la aux, llamamos al metodo pasandole esas pilas
                    movimientos = movimientos + 1; // Los movimientos valdrán este más uno
                    if (fin.Size == n) // Si el tamaño de la pila fin es el mismo que el número de discos que se le ha pasado
                    {
                        break; // Hacemos que el método pare
                    }
                    mover_disco(ini, fin); // El segundo movimiento es de la pila ini a la fin, llamamos al metodo pasandole esas pilas
                    movimientos = movimientos + 1; // Los movimientos valdrán este más uno
                    if (fin.Size == n) // Si el tamaño de la pila fin es el mismo que el número de discos que se le ha pasado
                    {
                        break; // Hacemos que el método pare
                    }
                    mover_disco(fin, aux); // El tercer movimiento es de la pila fin a la aux, llamamos al metodo pasandole esas pilas
                    movimientos = movimientos + 1; // Los movimientos valdrán este más uno
                    if (fin.Size == n) // Si el tamaño de la pila fin es el mismo que el número de discos que se le ha pasado
                    {
                        break; // Hacemos que el método pare
                    }
                }
                Console.WriteLine("Se hizo en: " + movimientos + " movimientos"); // Muestra por pantalla en cuantos movimientos se hizo
            }
            else // Si no es par
            {
                while (fin.Size != n) // Hacemos los siguientes movimientos hasta que la pila fin tenga el nº de discos iniciales
                {
                    mover_disco(ini, fin); // El primer movimiento es de la pila ini a la fin, llamamos al metodo pasandole esas pilas
                    movimientos = movimientos + 1; // Los movimientos valdrán este más uno
                    if (fin.Size == n) // Si el tamaño de la pila fin es el mismo que el número de discos que se le ha pasado
                    {
                        break;
                    }
                    mover_disco(ini, aux); // El segundo movimiento es de la pila ini a la aux, llamamos al metodo pasandole esas pilas
                    movimientos = movimientos + 1; // Los movimientos valdrán este más uno
                    if (fin.Size == n) // Si el tamaño de la pila fin es el mismo que el número de discos que se le ha pasado
                    {
                        break; // Hacemos que el método pare
                    }
                    mover_disco(aux, fin); // El tercer movimiento es de la pila aux a la fin, llamamos al metodo pasandole esas pilas
                    movimientos = movimientos + 1; // Los movimientos valdrán este más uno
                    if (fin.Size == n) // Si el tamaño de la pila fin es el mismo que el número de discos que se le ha pasado
                    {
                        break; // Hacemos que el método pare
                    }
                }
                Console.WriteLine("Se hizo en: " + movimientos + " movimientos"); // Muestra por pantalla en cuantos movimientos se hizo
            }
            return movimientos; // Devuelve el número de movimientos utilizados
           
        }

    }
}
