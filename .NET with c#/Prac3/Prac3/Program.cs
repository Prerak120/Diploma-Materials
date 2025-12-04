namespace Prac3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for the two numbers
            int num1, num2, sum, divisionResult;

            // Ask the user for the first number
            Console.Write("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user for the second number
            Console.Write("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Calculate the sum of the two numbers
            sum = num1 + num2;

            // Check if num2 is zero to avoid division by zero
            if (num2 != 0)
            {
                // Calculate the division result
                divisionResult = num1 / num2;
                Console.WriteLine($"The division result of {num1} / {num2} is: {divisionResult}");
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }

            // Display the sum
            Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
        }
    }
}
