using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Autor
    {

        private static int count = 0;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Autor(string name, string surname, int age)
        {
            count++;
            Id = count;

            Name = name;
            Surname = surname;
            Age = age;

        }
    }
}
