// See https://aka.ms/new-console-template for more information


Console.WriteLine($"Enter a number between 1 and 7:");
int currentDay = Convert.ToInt32(Console.ReadLine());

// if (currentDay == 1)
// {
//     Console.WriteLine("Monday");
// } else if (currentDay == 2)
// {
//     Console.WriteLine("Tuesday");
// }
// else if (currentDay == 3)
// {
//     Console.WriteLine("Wednesday");
// }
// else if (currentDay == 4)
//     {
//         Console.WriteLine("Thursday");
//     }   
// else if (currentDay == 5)
//     {
//         Console.WriteLine("Friday");
//     }    
// else if (currentDay == 6)
// {
//     Console.WriteLine("Saturday");
// }  
// else if (currentDay == 7)
// {
//     Console.WriteLine("Sunday");
// }
// else
// {
//     Console.WriteLine("Invalid day");
// }      

switch (currentDay)

{
  case  1:
    Console.WriteLine("Monday");
      break;
  
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    
    
    break;
  
  default:
    Console.WriteLine("Invalid day");
    break;
}