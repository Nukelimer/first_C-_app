// See https://aka.ms/new-console-template for more information

Console.WriteLine("Choose the calculation, type +, -, *, %, or / ");

string input = Console.ReadLine();
int result = 0;

if (input == "-")
{
    Console.WriteLine("gotcha, you want to do a subtraction calculation, enter the two figures below");
} else if (input == "+")
{
    Console.WriteLine("gotcha, you want to do an addition calculation, enter the two figures below");
} else if (input == "*")
{
    
    Console.WriteLine("gotcha, you want to do a multiplication calculation, enter the two figures below");

} else if (input == "%")
{
    
    Console.WriteLine("gotcha, you want to do a remainder calculation, enter the two figures below");
} else if (input == "/")

{
    
    Console.WriteLine("gotcha, you want to do a division calculation, enter the two figures below");
}
else
{
    
    Console.WriteLine("Oops, this is not a mathematical calculation");
    
}

string firstInput = Console.ReadLine();
string secondInput = Console.ReadLine();

int firstInputInt = Convert.ToInt32(firstInput);
int secondInputInt = Convert.ToInt32(secondInput);


if (firstInput  == " " || secondInput == "")
{
    Console.WriteLine("Oops, one or more arguments are invalid");
}


if (input == "-")
{
    result = firstInputInt - secondInputInt;
    Console.WriteLine($"Result: {result}");

}
else if(input == "+")
{
    result = firstInputInt + secondInputInt;
    Console.WriteLine($"Result: {result}");
}
else if(input == "*")
{
    result = firstInputInt * secondInputInt;
    Console.WriteLine($"Result: {result}");
}

else if(input == "/")
{
    result = firstInputInt / secondInputInt;
    Console.WriteLine($"Result: {result}");
}

else if(input == "%")
{
    result = firstInputInt % secondInputInt;
    Console.WriteLine($"Result: {result}");
}




