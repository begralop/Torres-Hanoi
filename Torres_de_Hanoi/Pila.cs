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

    }
}
