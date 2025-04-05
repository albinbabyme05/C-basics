using System;
using System.Collections.Generic;

/*problem : create list
    * user enter item 
        - if it is in the list remove
        - else add to list
*/
class Program
{
    static void Main()
    {
        List<string> shoppingList = new List<string>{ "apple", "banana", "milk"};

        string userInput;

       
        while (shoppingList.Count !=0)// keep 'true' to make infinite loop
        {
            System.Console.WriteLine("This is your list items: ");
            foreach (var item in shoppingList)
            {
                System.Console.WriteLine($"{item}, ");
            }
            
            System.Console.WriteLine("Enter the item : ");
            userInput  = Console.ReadLine()??"";
            
            System.Console.WriteLine("Do you want to add more? : ");
            string choise = Console.ReadLine()??"";
            
           
            //if the user enter item in the list it should remove
            if(shoppingList.Contains(userInput.ToLower())){
                shoppingList.Remove(userInput.ToLower());
            }else{
                shoppingList.Add(userInput.ToLower());
                
            }
            
            foreach (var item in shoppingList)
            {
                System.Console.WriteLine($"{item}, ");
            }
            Console.Clear();
        }
    }
}
