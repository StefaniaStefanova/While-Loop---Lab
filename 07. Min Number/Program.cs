namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue; // Initialize with the maximum possible integer value
            string input = Console.ReadLine();

            while (input != "Stop")
            {
                int n = int.Parse(input);
                if (n < minNumber) // Check if the entered number is smaller than the current minimum
                {
                    minNumber = n; // Update the minimum number
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber); // Output the smallest number found
        }
    }
}