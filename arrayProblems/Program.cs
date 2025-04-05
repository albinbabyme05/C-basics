using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter size of the Array: ");
        int n = int.Parse(Console.ReadLine()??"");

        int[] newArray = new int[n];
        
        for(int i=0; i<n; i++){
            Console.WriteLine($"{i+1} number :  ");

            while(true){
                string? inputNumbers = Console.ReadLine();
                if(int.TryParse(inputNumbers, out  newArray[i])){
                    // valid entry accpeted
                    break;
                }else{
                    Console.WriteLine("Invalid Entry");
                }
            }
        }
        // to display the array
        foreach(int iteam in newArray){
            Console.Write(iteam);
        }

        //-------index of array element-----
        int[] numbersArray = new int[]{90, 99, 22, 50, 30};

        Console.WriteLine("Enter the number to search: ");
        int? number = Convert.ToInt32(Console.ReadLine());
        int? index = -1;

        for(int i=0; i< numbersArray.Length; i++){
            if(numbersArray[i] == number)
            {
                Console.WriteLine($"Position of {number} is {index=i}");
                break;
            }
        }
        
    }
}
