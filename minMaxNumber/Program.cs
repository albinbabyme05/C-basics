using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Number Coma Separted : ");
        string[] userInputs = (Console.ReadLine()??" ").Split(',');

        //create the List
        List<int> numbersList = new List<int>();

        foreach(string num in userInputs){
            if(int.TryParse(num, out int number)){
                numbersList.Add(number);
            }
        }

        Console.WriteLine("original List: " + string.Join(", ", numbersList));

        int highestNumber = 0;
        int lowesrNumber = numbersList[0];
        foreach(int currentNumber in numbersList){
            if(currentNumber > highestNumber){
                highestNumber = currentNumber;
            }
            if(currentNumber < lowesrNumber){
                lowesrNumber= currentNumber;
            }
        }
        Console.WriteLine("The Highest Number is: "+highestNumber);
        Console.WriteLine("The Lowest Number is: "+lowesrNumber);


        //===============Reversing the above list created==================
        numbersList.Reverse();
        Console.WriteLine("Reversed List: " + string.Join(", ", numbersList));

        //===============check duplicate number==================

         List<int> newNumbersList = new List<int>();
        foreach(int num in numbersList){
        // 
        if(!newNumbersList.Contains(num))// if the not in the list it will return true, ! reverse it
        {
            //adding only the number without duplicates
            newNumbersList.Add(num);
        }
        }
        Console.WriteLine("Duplicate removed: " + string.Join(", ", newNumbersList));


        //=======Task3========convert list to string==================
        Console.WriteLine("Enter Number Coma Separted : ");
        string[] texts = (Console.ReadLine()??" ").Split(',');

        Console.WriteLine(string.Join(" ",texts));
        Console.WriteLine(string.Join(" ,",texts));


        
    }
}
