using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarIdade
{
    internal class Pessoa
    {
        public string Name { get; set; }
        
        public string BirthDate { get; set; }

        public int Age { get; set; }

        public Pessoa(string name, string birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public void ShowAge() // 12/08/1985
        {
            int dayBirth = int.Parse(BirthDate.Substring(0,2));
            int monthBirth = int.Parse(BirthDate.Substring(3,2));            
            int yearBirth = int.Parse(BirthDate.Substring(6,4));

            var today = DateTime.Now;

            Age = today.Year - yearBirth;

            if (monthBirth > today.Month || monthBirth == today.Month && dayBirth > today.Day)
            {
                Age -= 1;
            }
            
            Console.Clear();
            if(monthBirth == today.Month && dayBirth == today.Day)
            {
                Console.WriteLine($"Hoje é aniversário de {Name}! Parábens!");
            }                       
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"{Name} possui {Age} anos de idade!");
            Console.WriteLine("-----------------------------\n");
        }
    }
}
