namespace ConsoleApp.RetirementAgeCalculator;

class Program
{
    static void Main(string[] args)
    {
        string userName = String.Empty;
        int age = 0;
        int retirementAge = 70;
        char gender = Char.MinValue;
        decimal salary = 0;
        bool workinStatus;
        
        Console.WriteLine("Hello, What is your name?");
        userName = Console.ReadLine();
        
        Console.WriteLine($"{userName}, how old are you currently?");
        age = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"{userName}, What is your gender? ('M' or 'F')");
        gender = Convert.ToChar(Console.ReadLine());
        
        
        Console.WriteLine($"{userName}, are you working currently? (true or false)");
        workinStatus = Convert.ToBoolean(Console.ReadLine());
        
        Console.WriteLine($"{userName}, how much are you earning currently?");
        salary = Convert.ToDecimal(Console.ReadLine());

        
        int ageLeft = retirementAge - age;
        
        Console.WriteLine($"Hey {userName}, you are {age} years old {gender} with a working status of {workinStatus} with {salary} salary, youR have {ageLeft} years left to be a Justice before retirement from the Supreme Court of Nigeria.");

    }
}