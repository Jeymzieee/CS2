using System;
internal class Program
{
        static void Main()
{   Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\nGood Day World, Welcome to my limited shop...");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("What do you want to buy?");
    Console.ResetColor();
    
   while(true) 
    try
{   Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("1. Apple\n2. Avocado\n3. Mango\n4. Banana\n");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("Input the number of your desired item: ");
    Console.ResetColor();
    int item = Convert.ToInt32(Console.ReadLine());
    
    if (item == 1)
    {   Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Enter the number of Apples: ");
        Console.ResetColor();
        int appleCount = Convert.ToInt32(Console.ReadLine());
        
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Enter the total price of " + appleCount + " Apple(s): ");
        Console.ResetColor();
        double price = Convert.ToDouble(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("The original of price Apple is " + price);
        int convertedPrice = (int)price;
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("The converted of price Apple is " + convertedPrice);
        Console.ResetColor();
        
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Press any key to Exit");
        Console.ResetColor();
        Console.ReadKey(); 
        break;
    }
    else if(item == 2) 
    {   
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Enter the number of Avocado: ");
        Console.ResetColor();
        int avocadoCount = Convert.ToInt32(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Enter the total price of " + avocadoCount + " Avocado(s): ");
        Console.ResetColor();
        double price = Convert.ToDouble(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("The original of price is  of Avocado is " + price);
        Console.ResetColor();
        int convertedPrice = (int)price;

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("The converted of price of Avocado is " + convertedPrice);
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Press any key to exit...");
        Console.ResetColor();
        Console.ReadKey();   
        break;
    }
    else if(item == 3) 
    {  
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Enter the number of Mango: ");
        Console.ResetColor();
        int MangoCount = Convert.ToInt32(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Enter the total price of " + MangoCount + " Mango(s): ");
        Console.ResetColor();
        double price = Convert.ToDouble(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("The original of price Mango is " + price);
        Console.ResetColor();
        int convertedPrice = (int)price;

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("The converted of price Mango is " + convertedPrice);
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Press any key to exit...");
        Console.ResetColor();
        Console.ReadKey();  
        break;
    }
    else if(item == 4) 
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Enter the number of Banana: ");
        Console.ResetColor();
        int BananaCount = Convert.ToInt32(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Enter the total price of " + BananaCount + " Banana(s): ");
        Console.ResetColor();
        double price = Convert.ToDouble(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("The original of price Banana is " + price);
        Console.ResetColor();
        int convertedPrice = (int)price;
        
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("The converted of price Banana is " + convertedPrice);
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Press any key to exit...");
        Console.ResetColor();
        Console.ReadKey();
        break;
    }
    else{
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Sorry, this Shop is limited. Try other items");
        Console.ResetColor();
    }
}
catch(FormatException){
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\nWe don't understand that input, please try again");
        Console.ResetColor();
    }}}