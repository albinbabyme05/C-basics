using System;
using System.Collections.Generic;

class Program{
//     struct Person
//     {
//         public string name;
//         public int age;
//     }
//     static void Main()
//     {
//         Person person = ReturnPerson();
//         Console.WriteLine($"{person.name} - {person.age}");
//     }

//     static Person ReturnPerson(){
//         Console.WriteLine("Enter your name: ");
//         string? name = Console.ReadLine();

//         Console.WriteLine("Enter your age: ");
//         int age = Convert.ToInt32(Console.ReadLine()??"");

//         Person person;
//         person.name = name;
//         person.age = age;

//         return person;

//     }

        /*can be be written with creating constructor*/
    struct Person
    {
        public string name;
        public int age;
        public int birthMonth;

        public Person(string name, int age, int birthMonth){
            this.name = name;
            this.age = age;
            this.birthMonth = birthMonth;
        }
    }
    static void Main()
    {
        Person person = ReturnPerson();
        Console.WriteLine($"{person.name} - {person.age}--> {person.birthMonth}");
    }

    static Person ReturnPerson(){
        Console.WriteLine("Enter your name: ");
        string? name = Console.ReadLine();

        Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine()??"");

        Console.WriteLine("Enter your Birth Month: ");
        int birthMonth = Convert.ToInt32(Console.ReadLine()??"");

        

        return new Person(name, age, birthMonth);

    }
}
