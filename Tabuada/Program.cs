using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada {
    class Program {
        static void Main(string[] args) {

            int n, i, resultado;

            Console.Write("Deseja a tabuada para qual valor? ");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= 10; i++) {
                resultado = n * i;
                Console.WriteLine(n + " x " + i + " = " + resultado);
            }
        }
    }
}
