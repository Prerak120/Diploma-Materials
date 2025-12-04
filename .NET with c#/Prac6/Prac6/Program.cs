namespace Prac6
{
    internal class Program
    {
        static void Main()
        {
            // Define a 2x2 matrix using a 2D array
            int[,] matrix = new int[2, 2] {
            { 1, 2 },
            { 3, 4 }
        };

            // Display the matrix
            Console.WriteLine("2x2 Matrix:");
            for (int i = 0; i < 2; i++) // Loop through rows
            {
                for (int j = 0; j < 2; j++) // Loop through columns
                {
                    Console.Write(matrix[i, j] + " "); // Print each element
                }
                Console.WriteLine(); // New line after each row
            }
        }
    }
}
