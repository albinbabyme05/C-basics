using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<String,long> phoneBook = new Dictionary<string, long>();

        //add key-value to Dicitionary
        phoneBook.Add("Albin", 9744004873);
        phoneBook["Unni"] = 8281619237;


        //check the ley in the Dicitionary
        if(phoneBook.ContainsKey("Unni")){
            Console.WriteLine("Unni number is "+phoneBook["Unni"]);
        }

        // find teh count in dictionary
        Console.WriteLine(phoneBook.Count);

    }
}
