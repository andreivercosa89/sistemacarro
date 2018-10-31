using System;

namespace sistemacarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Console.WriteLine("Informe o nome do carro: ");
            carro.Nome = Console.ReadLine();

            Console.WriteLine("\nInforme a cor do carro: ");
            carro.Cor = Console.ReadLine();

            Console.WriteLine("\nInforme a marca do carro: ");
            carro.Marca = Console.ReadLine();


            Console.WriteLine("\n\nCarro {0} da cor {1} e da Marca {2}", carro.Nome, carro.Cor, carro.Marca);

        }
    }
}
