

/* Method 1 to Create a Array*/
//decimal[] weeklyCalories = {2000, 2500, 3000};

// Console.WriteLine("Calorie for Day 1: ");
// weeklyCalories[0] = decimal.Parse(Console.ReadLine());

// Console.WriteLine("Calorie for Day 2: ");
// weeklyCalories[1] = decimal.Parse(Console.ReadLine());

//===============================================================

/* Method 2 to Create a Array*/
decimal[] weeklyCalories = new decimal[7];

for(int i=0; i< weeklyCalories.Length; i++){
    System.Console.WriteLine($"Calories for Day {i+1}; ");
    weeklyCalories[i] = decimal.Parse(Console.ReadLine()); 
}

decimal total = 0;
foreach (var item in weeklyCalories)
{
    System.Console.Write($"{item}, ");
    total+=item;
    
}
decimal recommandedKcalIntake = 2500;
System.Console.WriteLine($" Average Cal intakae : {total/7}");

