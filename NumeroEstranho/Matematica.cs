using System.Collections.Generic;
using System.Linq;

namespace NumeroEstranho
{
    /// <summary>
    /// Classe que representa as operações matemáticas
    /// </summary>
    public class Matematica
    {
        static List<int> Divisor(int numero)
        {
            List<int> listaDivisor = new List<int> { 1 };
            List<int> listaDivisor2 = new List<int>();

            for (int contador = 2; contador * contador <= numero; contador++)
            {
                if (numero % contador == 0)
                {
                    int j = numero / contador;
                    listaDivisor.Add(contador);

                    if (contador != j)
                    {
                        listaDivisor2.Add(j);
                    }
                }
            }

            listaDivisor.Reverse();
            listaDivisor2.AddRange(listaDivisor);

            return listaDivisor2;
        }

        static bool EAbundante(int numero, List<int> lista)
        {
            return lista.Sum() > numero;
        }

        static bool SemiPerfeito(int n, List<int> lista)
        {
            if (lista.Count > 0)
            {
                var h = lista[0];
                var t = lista.Skip(1).ToList();
                if (n < h)
                {
                    return SemiPerfeito(n, t);
                }
                else
                {
                    return n == h || SemiPerfeito(n - h, t) || SemiPerfeito(n, t);
                }
            }
            else
            {
                return false;
            }
        }

        public static List<bool> Classificador(ushort limite)
        {           
            bool[] lista = new bool[limite];

            for (int i = 2; i < limite; i += 2)
            {
                if (lista[i])
                {
                    continue;
                }

                var divs = Divisor(i);

                if (!EAbundante(i, divs))
                {
                    lista[i] = true;
                }
                else if (SemiPerfeito(i, divs))
                {
                    for (int j = i; j < limite; j += i)
                    {
                        lista[j] = true;
                    }
                }
            }

            return lista.ToList();
        }
    }
}
