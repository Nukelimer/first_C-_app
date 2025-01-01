namespace ConsoleApp.RetirementAgeCalculator;

class Program
{
    static void Main(string[] args)
    {
        string userName = String.Empty;
        int age = 0;
        int retirementAge = 70;
        
        
        Console.WriteLine("Hello, What is your name?");
        userName = Console.ReadLine();
        
        Console.WriteLine($"{userName}, how old are you currently?");
        age = Convert.ToInt32(Console.ReadLine());

        int ageLeft = retirementAge - age;
        
        Console.WriteLine($"Hey {userName}, you have {ageLeft} years left to be a Justice before retirement from the Supreme Court of Nigeria.");

    }
}