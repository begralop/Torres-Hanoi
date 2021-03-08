using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {
        public int valor { get; set; } // Definimos parámetro valor (he elegido representarlo con enteros) con get y set

        public Disco(int num) // Constructor 
        {
            this.valor = num; // Asignamos el valor num del constructor al parámetro valor
        }
    }
}
