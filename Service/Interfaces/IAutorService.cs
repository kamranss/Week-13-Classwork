using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IAutorService
    {
        public void AddAutortoList(Autor autor);
        public void FindAutor(int age);
    }
}
