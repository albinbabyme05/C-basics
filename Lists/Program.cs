using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number separted by comma ! \n");
        string[] inputs = (Console.ReadLine()??"").Split(',');

        List<int> numbers = new List<int>();

        foreach(string num in inputs){
            if(int.TryParse(num, out int number)){
                numbers.Add(number);
            }
        }
        
        int sum = 0;
        foreach(int num in numbers){
            sum += num;
        }
        Console.WriteLine("The sum of all number in the List is "+sum);

        //====================================================
        List<int> numberList = new List<int>();
        for(int i=0; i<5; i++){
            Console.WriteLine($"Enter number : ");
            int num = Convert.ToInt32(Console.ReadLine()??"");

            numberList.Add(num);
        }

        foreach(int num in numberList){
            Console.Write($"{num} ");
        }

        //=============Problem=====================
        /* create two list with int datatype, one for even and one for odd
        * loop for 0-20
            *if number is even add to even list
            *if number is odd add to odd list
           *print odd and even list 
        */

        List<int> oddList = new List<int>();
        List<int> evenList = new List<int>();

        for(int i=0; i<=20; i++){
            if(i % 2 == 0){
                evenList.Add(i);
            }else{
                oddList.Add(i);
            }
        }
        Console.WriteLine("Evenlist: ");
        foreach(int item in evenList){
            Console.Write($"{item},");
        }
        Console.WriteLine("oddlist: ");
        foreach(int item in oddList){
            Console.Write($"{item},");
        }



    }
}

