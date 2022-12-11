// See https://aka.ms/new-console-template for more information

using Domain.Models;
using Service.Services;

Autor autor1 = new("Kamran", "Suleyman", 20);
Autor autor2 = new("Kamil", "Huseyn", 30);

AutorObjectsSample AddObjectToList = new();
AddObjectToList.AddAutortoList(autor1);
AddObjectToList.AddAutortoList(autor2);

AddObjectToList.FindAutor(40);

