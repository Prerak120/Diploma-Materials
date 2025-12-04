namespace Prac7
{
    internal class Program
    {
        static void Main()
        {
            //a Read a string from the user
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            // Call the method to count words in the string
            int wordCount = CountWords(input);

            // Display the word count
            Console.WriteLine("Total number of words: " + wordCount);
        }

        // Method to count the number of words in a string
        static int CountWords(string str)
        {
            // Trim any leading or trailing spaces and split the string by spaces
            string[] words = str.Trim().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            // Return the number of words
            return words.Length;
        }
    }
}
