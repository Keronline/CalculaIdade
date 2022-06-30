using System;

namespace ConsultarIdade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string option = "S";
            while (option.ToUpper() != "N") {

                Console.WriteLine("Qual é o nome de quem você deseja saber a idade? ");
                string name = Console.ReadLine();
                Console.WriteLine("Qual a data de nascimento da pessoa? No formato dd/mm/aaaa");
                string[] birth = Console.ReadLine().Split('/');

                Pessoa p1 = new Pessoa(name, birth);
                p1.ShowAge();

                Console.WriteLine("Deseja realizar um novo cálculo novamente? \nS - SIM\nN - Não");
                option = Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine("Até mais :)\n");
        }
    }
}