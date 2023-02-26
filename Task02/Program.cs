Console.WriteLine("Input first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber>secondNumber){
    Console.WriteLine("First number is bigger");
} else if (secondNumber>firstNumber){
    Console.WriteLine("Second number is bigger");
} else {
    Console.WriteLine("There is no number that is bigger than anothe one");
};