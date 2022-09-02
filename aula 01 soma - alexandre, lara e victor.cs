using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_01_soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero01, numero02, resultado;

            Console.WriteLine("Insira o primeiro numero");
            numero01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o segundo numero");
            numero02 = Convert.ToInt32(Console.ReadLine());

            resultado = numero01 / numero02;

            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
