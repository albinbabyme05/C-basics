using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Number Checking Project");

        Console.WriteLine("===================================\n");

        Console.WriteLine("Enter a number: ");
        int? number = Convert.ToInt32(Console.ReadLine());

        if(number > 0){
            Console.WriteLine($"{number} is Postive.");
        }else if(number < 0){
            Console.WriteLine($"{number} is Negtive.");
        }else{
            Console.WriteLine($"{number} is Zero");
        }

    }
}
