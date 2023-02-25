Console.WriteLine("Input first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (secondNumber*secondNumber == firstNumber) {
    Console.WriteLine("Second number squared equals first number");
} else {
    Console.WriteLine("Connection between these numbers is not found");
};