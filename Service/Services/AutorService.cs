using Domain.Models;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AutorService:IAutorService
    {

        List<Autor> autors = new List<Autor>();

        public void AddAutortoList(Autor autor)
        {
            autors.Add(autor);
        }

        public void FindAutor(int age)
        {
            foreach (var item in autors)
            {
                if (item.Age > 20)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.Surname);
                    Console.WriteLine(item.Age);
                }
            }
        }
    }
}
