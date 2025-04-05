using System;
using System.ComponentModel;

/*
0--> Rock
1--> paper
2--> scissors
*/

class Program
{
    public static int RandomNumber(){
        Random  randomNumber = new Random();
        return randomNumber.Next(3);
    }
    static void Main()
    {
        
        System.Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        System.Console.WriteLine($"Welcome {name} to RPS Game");

        //track score
        int userScore = 0;
        int ComputerScore = 0;
        bool isGameOver = true;
        while (isGameOver)
        {
            
            string[] item = {"Rock", "Paper", "Scissors"};

            int systemInput = RandomNumber();
            System.Console.WriteLine($"System choice:{item[systemInput]}");

            Console.WriteLine("Enter your choice (0 = Rock, 1 = Paper, 2 = Scissors): ");
        
            //checking the userinput is valid
            bool isvalid = int.TryParse(Console.ReadLine(), out int userinput);
            if(!isvalid || userinput<0 || userinput>2){
                System.Console.WriteLine("Invalid input! Enter 0 or 1 or 2");
                return;
            }

            System.Console.WriteLine($"User choice:{item[userinput]}");

            if(userinput==0 && systemInput==2 ){
                System.Console.WriteLine($"{name} Won!");
                userScore++;
            }else if(userinput==1 && systemInput==0){
                System.Console.WriteLine($"{name} Won!");
                userScore++;
            }else if(userinput==2 && systemInput==1){
                System.Console.WriteLine($"{name} Won!");
                userScore++;
            }
            else if(userinput == systemInput){
                System.Console.WriteLine("Tie");
            }else{
                System.Console.WriteLine("Computer Won");
                ComputerScore++;
            }
            System.Console.WriteLine("==========================");
            System.Console.WriteLine("Would like to continue?: ");
            string choice = Console.ReadLine();
            
            if(choice=="y"){
                System.Console.WriteLine("==========================");
                System.Console.WriteLine("==========================");
            }
            else{
                isGameOver = false;
            }
        }
        System.Console.WriteLine($"{name} score : {userScore}");
        System.Console.WriteLine($"Computer Score: {ComputerScore}");

        
        
        
        
    }
}
