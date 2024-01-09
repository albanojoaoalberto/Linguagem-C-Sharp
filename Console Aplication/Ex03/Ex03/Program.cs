using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONVERSÕES DE TIPOS DE DADOS EM C#

            string nome;
            int anonasc;

            //Entrada de Dados

            Console.Write("Informe o Seu Nome: ");
            nome = Console.ReadLine(); //Nota que o Dado do tipo String Não de Consersão.

            Console.Write("Em que Ano Você Nasceu? :");
            anonasc = Convert.ToInt32(Console.ReadLine());
             
            //Saida de Informações.

            Console.WriteLine("Olá, "+nome+" Você nasceu em "+ anonasc);


                Console.ReadKey();//Permite Fixar a tela de Console.
        }
    }
}
