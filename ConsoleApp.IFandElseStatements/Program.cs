// // See https://aka.ms/new-console-template for more information
//
// Console.WriteLine("Hello, World!");



namespace ConsoleApp.IFandElseStatements;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, what is your Name?");
        string UserName = Console.ReadLine();
        
        Console.WriteLine($"{UserName}, what is the time in your region(In 24h format, i.e, 12, 1, 23)?");

        string timeGreeting = Console.ReadLine();
            
            
        int convertedTimeNum =    Convert.ToInt32(timeGreeting);
        
        
        if(convertedTimeNum < 12){
        Console.WriteLine($"Good Morning {UserName}!!");
        } else if (convertedTimeNum < 14)
        {
            
            Console.WriteLine($"Good Afternoon {UserName}!!");  
        }
        else if (convertedTimeNum < 23)
        {
            Console.WriteLine($"Good Evening {UserName}!");
        }
        else
        {
            Console.WriteLine($"Good Day {UserName}!");
        }

    }
}