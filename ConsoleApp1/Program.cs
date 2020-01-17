using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public delegate string MetodoDelegate(int numero);
        public delegate void botaoacao(object pareametro);
        
        static void Main(string[] args)
        {

            // 1ª forma de instanciar um delegate
            MetodoDelegate oMD = RetornoValor;
            //botaoacao seila = RetornoValor;
            Console.WriteLine("1ª forma, valor: {0}", oMD(1));

            // 2ª forma de instanciar um delegate
            MetodoDelegate oMD2 = new MetodoDelegate(RetornoValor);
            Console.WriteLine("2ª forma, valor: {0}", oMD2(2));

            // 3ª forma de instanciar um delegate - Método anônimo
            MetodoDelegate oMD3 = delegate (int numero)
            {
                return numero.ToString();
            };
            Console.WriteLine("3ª forma, valor: {0}", oMD3(3));

            // 4ª forma de instanciar um delegate - expressão lambda
            MetodoDelegate oMD4 = d => d.ToString();
            Console.WriteLine("4ª forma, valor: {0}", oMD4(4));
            // 5ª forma de instanciar um delegate -Invoke
            Console.WriteLine("Numero: " + oMD.Invoke(7));
            Console.ReadKey();
        }

        static string RetornoValor(int numero)
        {
            return numero.ToString();
        }
    }
}
