using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declarando variaveis em C# 

            string pessoa;
           

            //MEtodos de Saida e Entrada

            Console.Write("Qual é o seu Nome? :");//esté é p metodo de saida.
            pessoa = Console.ReadLine(); //este é o metodo de entrada

            //

            Console.WriteLine("Olá é um Prazer " + pessoa+". ");



            Console.ReadKey();//esté comando permite fixaxr a tela de Execução.
        }
    }
}
