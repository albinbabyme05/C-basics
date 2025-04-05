using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // problem1:  age checking
        // write condition age between 18 and 25 
        // condition2 age greater than 25
        //  condition3 age less than zero

        Console.WriteLine("Enter your name : ");
        string? name = Console.ReadLine();

        Console.WriteLine("Enter your age: ");
        string? ageInput = Console.ReadLine();
        int age = Convert.ToInt32(ageInput);

        Console.WriteLine($"Hi {name}, Your age is {age}");

        if(age >= 18 && age <=25){
            Console.WriteLine("your age in between 18 and 25");
        }else if(age >=25){
            Console.WriteLine("Your age is above 25");
        }else if(age==0 || age<0){
            Console.WriteLine("Invalid Age");
        }else{
            Console.WriteLine("Something went Wrong!");
        }

        //====================Switch Statement===========================
        // problem2 
        // the entered number between 1-7 should output a day
        
        Console.WriteLine("Enter the day of the week: ");
        string? dayInput = Console.ReadLine();
        int day = Convert.ToInt32(dayInput);

        switch (day)
        {
            case 1:
            Console.WriteLine("Today is Sunday!!");
            break;

            case 2:
            Console.WriteLine("Today is Monday!!");
            break;

            case 3:
            Console.WriteLine("Today is Tuesday!!");
            break;

            case 4:
            Console.WriteLine("Today is Wednesday!!");
            break;

            case 5:
            Console.WriteLine("Today is Thursday!!");
            break;

            case 6:
            Console.WriteLine("Today is Friday!!");
            break;

            case 7:
            Console.WriteLine("Today is Saturday!!");
            break;

            default:
            Console.WriteLine("Invalid Entry !!");
            break;
        }

    }
}
