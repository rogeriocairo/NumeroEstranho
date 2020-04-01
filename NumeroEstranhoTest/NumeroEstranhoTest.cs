using NumeroEstranho;
using Xunit;

namespace NumeroEstranhoTest
{
    public class NumeroEstranhoTest
    {
        [Theory]
        [InlineData(1, 70)]
        [InlineData(2, 836)]
        [InlineData(3, 4030)]
        [InlineData(4, 5830)]
        [InlineData(5, 7192)]
        [InlineData(6, 7912)]
        [InlineData(7, 9272)]
        [InlineData(8, 10430)]       
        public void ValidadaNumeroEstranho(int numero, int numeroExperado)
        {
            //arrange
            var w = Matematica.Classificador(17_000);
            int max = numero;
            int count = 0;
            int soma = 0;

            //act
            for (int n = 2; count < max; n += 2)
            {
                if (!w[n])
                {
                    soma = n;
                    count++;
                }
            }

            //result
            Assert.Equal(numeroExperado, soma);
        }
    }
}
