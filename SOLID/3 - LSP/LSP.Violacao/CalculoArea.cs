using System;

namespace SOLID.LSP.Violacao
{
    public class CalculoArea
    {
        #region Anotaçoes
        /*
         * Sempre que utilizamos a herança eu posso substituir a classe filha pela classe Pai.
         * No exemplo abaixo foi instanciado um objeto do tipo de Quadrado que herda de Retangulo
         * ou seja eu poderia ir no ObterAreaRetangulo e passar o quadrado e o calculo da area TEM que dar certo.
         * - aaaa mais e se não der certo?
         * - TEM QUE DAR CERTO. Se não der certo quer diser que minha abstração não está correta
         * - No exemplo abaixo não ira dar certo pois no Objeto quadrado ele joga os valores da altura e da largura para o campo altura,
         * e isto é uma regra do objeto quadrado. porem fazendo isto ao utilizar o metodo "Area" da classe mãe o calculo não da certo.
         * 
         * Ou seja se um quadrado NUNCA podera ser substituido por um retangulo quer diser que ele nunca deveria ter sido 
         * herdado de um retangulo. Uma herança sempre quer diser "É um"
         */
        #endregion

        private static void ObterAreaRetangulo(Retangulo ret)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Retangulo");
            Console.WriteLine();
            Console.WriteLine(ret.Altura + " * " + ret.Largura);
            Console.WriteLine();
            Console.WriteLine(ret.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            var quad = new Quadrado()
            {
                Altura = 10,
                Largura = 5
            };

            ObterAreaRetangulo(quad);
        }
    }
}