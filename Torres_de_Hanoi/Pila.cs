using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; } // Representa la cantidad de discos que hay en la pila

        public int Top { get; set; } // Representa el disco que está en la parte superior de una pila

        public Disco[] Elementos { get; set; } // Representa el conjunto de discos que hay en esa pila.

        public string nombre { get; set; } // Asigna un nombre a las pilas

        public Pila() // Constructor
        { 
            Elementos = new Disco[100]; // Crea un nuevo disco 
            Size = 0; // Asignamos los valores pasados al constructor a los parámetros de la clase
            Top = 100; // Asignamos 100 al valor del disco superior para pilas vacías
        }

        public void push(Disco d) // Permite colocar un disco en la pila de discos
        { 
            Elementos[Size] = d; // Añadimos a la pila el disco que le pasamos
            Size = Size + 1; // El tamaño de la pila será igual al tamaño más uno (porque hemos añadido 1)
            Top = d.valor; // Asignamos a top el valor del disco colocado
        }

        public Disco pop() // Permite extraer el disco de la parte superior de la pila.
        {
            if (isEmpty() == true) // Si el metod está vació vale true
            {
                return null; // Devuelve null
            }
            else // Si no
            {
                Disco aux = Elementos[Size - 1]; // Asignamos a un disco aux el que está en la parte superior de la pila
                Size = Size - 1; // El tamaño será el tamaño menos uno (por el que vamos a extraer)
                if (isEmpty() == true) // Si el metodo devuelve true
                {
                    Top = 100; // El valor del disco superior será 100
                }
                else // Si no
                {
                    Top = Elementos[Size - 1].valor; // Top valdrá el valor del disco superior de la pila
                }
                return aux; // Devuelve el disco aux
            }
        }

        public bool isEmpty() // Informa si la pila está vacía o no
        {
            if (Size == 0) // Si el tamaño es 0
            {
                return true; // Devuelve true
            }
            return false; // Si no devuelve false
        }

    }
}
