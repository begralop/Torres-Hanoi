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

        public void mover_disco(Pila a, Pila b) // Método mover_disco para comprobar de que pila a pila hacer el movimiento
        {
            if (a.Top < b.Top) // Si la pila a es menor que la b el movimiento se hace de b a a
            {
                Disco d = a.pop();
                b.push(d); // Aquí se hace el movimiento con los métodos push y pop de la clase pila
                Console.WriteLine("El disco " + d.valor + " se mueve de la " + a.nombre + " a la " + b.nombre);
            }
            else // En caso de que b sea menor que a, el movimiento se hace de la pila a a la pila b
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
                    mover_disco(ini, aux); // El primer movimiento es de la pila ini a la aux
                    movimientos = movimientos + 1; // Los movimientos valdrán este más uno
                    if (fin.Size == n) // Si el contador llega al cálculo de movimientos mínimos
                    {
                        break; // Hacemos que el método pare
                    }
                    mover_disco(ini, fin); // El segundo movimiento es de la pila ini a la fin
                    movimientos = movimientos + 1; // Los movimientos valdrán este más uno
                    if (fin.Size == n) // Si el contador llega al cálculo de movimientos mínimos
                    {
                        break; // Hacemos que el método pare
                    }
                    mover_disco(fin, aux); // El tercer movimiento es de la pila fin a la aux
                    movimientos = movimientos + 1; // Los movimientos valdrán este más uno
                    if (fin.Size == n) // Si el contador llega al cálculo de movimientos mínimos
                    {
                        break; // Hacemos que el método pare
                    }
                }
            }
            else // Si no
            {
                while (fin.Size != n) // Hacemos los siguientes movimientos hasta que la pila fin tenga el nº de discos iniciales
                {
                    mover_disco(ini, fin); // El primer movimiento es de la pila ini a la fin
                    movimientos = movimientos + 1; // Los movimientos valdrán este más uno
                    if (fin.Size == n) // Si el contador llega al cálculo de movimientos mínimos
                    {
                        break;
                    }
                    mover_disco(ini, aux); // El segundo movimiento es de la pila ini a la aux
                    movimientos = movimientos + 1; // Los movimientos valdrán este más uno
                    if (fin.Size == n) // Si el contador llega al cálculo de movimientos mínimos
                    {
                        break; // Hacemos que el método pare
                    }
                    mover_disco(aux, fin); // El tercer movimiento es de la pila aux a la fin
                    movimientos = movimientos + 1; // Los movimientos valdrán este más uno
                    if (fin.Size == n) // Si el contador llega al cálculo de movimientos mínimos
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
