using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fundamentos.medels
{
    public class Pessoa  
    {
        public string Nome { get; set; } = string.Empty;

        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"ola, meu nome é {Nome}, e tenho {Idade} anos");
            Console.ResetColor();
        }
    }
}