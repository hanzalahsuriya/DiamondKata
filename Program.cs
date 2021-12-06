using System;
using System.Linq;

namespace DiamondKata
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (!args.Any())
            {
                return;
            }

            var inputChar = args.First().ToCharArray().First();

            Console.WriteLine("--------------------OUTPUT--------------------");
            IDiamondkata diamondKata = new DiamondKata();
            Console.WriteLine(diamondKata.CreateDiamondKata(inputChar));
        }
    }
}
