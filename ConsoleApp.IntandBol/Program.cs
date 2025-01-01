namespace ConsoleApp.IntandBol;

class Program
{
    static void Main(string[] args)
    {
        int price_of_garri_per_basin = 2000;

        int salary = 300000;
        
        int subtract_garri_price_from_salary = salary - price_of_garri_per_basin;
        
        Console.WriteLine($"Amount left: #{subtract_garri_price_from_salary}" );



        bool isEvening = true;
            
            Console.WriteLine(isEvening);
        
        
    }
}