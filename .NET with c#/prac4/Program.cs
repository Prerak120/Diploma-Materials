namespace prac4
{
    internal class Program
    {
     using System;

class Program
    {
        static void Main(string[] args)
        {
            int m1, m2, m3, result;
            double per;

            // Input marks for three subjects
            Console.WriteLine("Enter marks for Subject 1:");
            m1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter marks for Subject 2:");
            m2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter marks for Subject 3:");
            m3 = int.Parse(Console.ReadLine());

            // Calculate total marks
            result = m1 + m2 + m3;
            Console.WriteLine($"Total Marks: {result}");

            // Calculate percentage
            per = (result * 100.0) / 300.0;
            Console.WriteLine($"Percentage: {per:F2}%");

            // Determine and display grade
            if (per > 80)
            {
                Console.WriteLine("Class: A");
            }
            else if (per >= 50)
            {
                Console.WriteLine("Class: B");
            }
            else
            {
                Console.WriteLine("Class: C");
            }
        }
    }

}
