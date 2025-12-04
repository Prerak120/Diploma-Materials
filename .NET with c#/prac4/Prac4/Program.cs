namespace Prac4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables to store marks
        int subject1, subject2, subject3;

        // Input marks for three subjects
        Console.Write("Enter marks for Subject 1: ");
        subject1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Subject 2: ");
        subject2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Subject 3: ");
        subject3 = Convert.ToInt32(Console.ReadLine());

        // Calculate the total and average marks
        int totalMarks = subject1 + subject2 + subject3;
        double averageMarks = totalMarks / 3.0;

        // Display the total and average
        Console.WriteLine("\nTotal Marks: " + totalMarks);
        Console.WriteLine("Average Marks: " + averageMarks);

        // Determine if the student has passed or failed
        if (subject1 >= 35 && subject2 >= 35 && subject3 >= 35)
        {
            Console.WriteLine("Result: Passed");
        }
        else
        {
            Console.WriteLine("Result: Failed");
        }
        }
    }
}
