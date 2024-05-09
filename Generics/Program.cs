using Generics.Generics;
using Generics.Models;

var newPerson = new Person
{
    Name = "Henrique",
    Age = 12
};

var intStore = new BaseGeneric<int>(12);
Console.WriteLine(intStore.GetItem());

var stringStore = new BaseGeneric<string>("Henrique");
Console.WriteLine(intStore.GetItem());

var personStore = new BaseGeneric<Person>(newPerson);
Console.WriteLine(personStore.GetItem().Name);

var method = ClassGeneric<Person>.GetMethodByName("GetAge");
var age = method?.Invoke(newPerson, null);
Console.WriteLine(age);

// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");