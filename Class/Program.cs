using System.Reflection.Metadata.Ecma335;
using System;
using System.Collections.Generic;

class Program
{
    class Person
    {
        public string name;
        public int age;

        public Person(string name, int age){
            this.name = name;
            this.age = age;
        }

        public  string returnDetails(){
        
        /*retruns true ot false, !which reverse and if true if block executes*/
    
            return $"Your name is {name} and You are {age} years old.";
         }
    }
    static void Main()
    {
        Console.WriteLine("Enter your name: ");
        string? nameInput = Console.ReadLine();

        Console.WriteLine("Enter your age: ");
        int ageInput = Convert.ToInt32(Console.ReadLine()??"");

        Person person = new Person(nameInput, ageInput);

        if(!string.IsNullOrEmpty(nameInput) && ageInput >-1 ){
            System.Console.WriteLine(person.returnDetails());
        }
 
    }
}

    //********************************************************
    /*****************private class**************************/
    //********************************************************
//     class Person
//     {
//         private string name;
//         private int age;

//         public Person(string name, int age){
//             this.name = name;
//             this.age = age;
//         }

//         public void SetName(string name){
//             if(!string.IsNullOrEmpty(name)){
//                 this.name = name;
//             }else{
//                 this.name = "Invalid Name";
//             }   

//             /*this.name = !string.IsNullOrEmpty(name) ? name : "Invalid Name"*/
//         }
//         public string GetName(){
//             return name;
//         }

//         public void SetAge(int age){
//             if(age >0 && age< 120){
//                 this.age = age;
//             }else{
//                 this.age = -1;
//             }

//             /*this.age = age>0 && age <120 ? age : -1;*/
            
//         }
//         public int GetAge(){
//             return age;
//         }

//         public string returnDetails(){
        
//         /*retruns true ot false, !which reverse and if true if block executes*/
    
//             return $"Your name is {name} and You are {age} years old.";
//          }

        
//     }
//     static void Main()
//     {
//         Console.WriteLine("Enter your name: ");
//         string? nameInput = Console.ReadLine();

//         Console.WriteLine("Enter your age: ");
//         int ageInput = Convert.ToInt32(Console.ReadLine()??"");

//         Person person = new Person(nameInput, ageInput);

//         // person.SetName(nameInput);
//         // person.SetAge(ageInput);

//         if(!string.IsNullOrEmpty(nameInput) && ageInput >-1 ){
//             System.Console.WriteLine(person.returnDetails());
//         }

//         person.SetName("anju");
//         person.SetAge(28);
//         System.Console.WriteLine($"Your name is {person.GetName()} and {person.GetAge()} years old");
 
//     }
    
    
// }
