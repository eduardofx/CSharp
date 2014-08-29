using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Olá " +nome);
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("Digite o Sobrenome:");
            string sobrenome = Console.ReadLine();
            Console.WriteLine(nome + " " + sobrenome);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Digite a Idade:");
            int idade = int.Parse(Console.ReadLine() );

           while (idade < 0)
            {
                Console.WriteLine("Idade Incorreto");
                idade = int.Parse(Console.ReadLine());
            }
            
            
            
            Console.WriteLine("Sua Idade é: "+idade);
            Console.WriteLine("Nome: {0} ,Sobrenome: {1}  ,Idade: {2}",nome,sobrenome,idade);




            Console.ReadKey();
        }
    }
}
