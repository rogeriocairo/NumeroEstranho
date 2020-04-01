using System;

namespace NumeroEstranho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas interações?");
            int interacao = int.Parse(Console.ReadLine().ToString());           

            var listaClassificada = Matematica.Classificador(ushort.MaxValue);
            int contador = 0;

            Console.WriteLine(string.Format("Lista dos {0} primeiros números estranhos.", interacao));

            for (int n = 2; contador < interacao; n += 2)
            {
                if (!listaClassificada[n])
                {
                    Console.Write("{0} ", n);
                    contador++;
                }
            }
            Console.WriteLine();
        }
    }
}
