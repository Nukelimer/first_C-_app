// namespace ConsoleApp.Loops;
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("How many times do you want to print greetings to a user in the console?, type actual numbers");
//         string input = Console.ReadLine();
//         long inputConverted = Convert.ToInt64(input);
//
//
//         for (int i = 0; i < inputConverted; i = i + 1)
//         {
//             Console.WriteLine($"Good afternoon {i+1}");
//             
//             
//         }
//     }
// }

int sum = 0;
int enteredNumber = 0;

while (enteredNumber != -1)
{
    Console.WriteLine("Enter a number:");
    enteredNumber = Convert.ToInt32(Console.ReadLine());
    if (enteredNumber != -1)
    {
        
       sum += enteredNumber; 
    }
}
Console.WriteLine("Sum is {0}", sum);




