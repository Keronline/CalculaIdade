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
        public int Age { get; set; }        
        public DateTime BirthDate { get; set; }         
        public DateTime today = DateTime.Now;

        public Pessoa(string name, string[] birthDate)
        {
            Name = name;
            BirthDate = DateTime.Parse($"{birthDate[1]}/{birthDate[0]}/{birthDate[2]}");
            CalcAge();
        }

        public int CalcAge()
        {    
            Age = today.Year - BirthDate.Year;

            if (BirthDate.AddYears(Age) > today)
            {
                Age -= 1;
            }

            return Age;
        }

        public void ShowAge() // 12/08/1985
        {            
            Console.Clear();

            if(BirthDate.Month == today.Month && BirthDate.Day == today.Day)
            {
                Console.WriteLine($"Hoje é aniversário de {Name}! Parábens!");
            }                       
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"{Name} possui {Age} anos de idade!");
            Console.WriteLine("-----------------------------\n");
        }
    }
}
