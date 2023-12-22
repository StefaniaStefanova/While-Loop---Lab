namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            string input = Console.ReadLine();  //четеш инпут
            while (input != "Stop")
            {
                int n = int.Parse(input); //парсваш към инт
                if (n > maxNumber)
                {
                    maxNumber = n;
                }
                input = Console.ReadLine(); // четеш следваш инпут
            }
            Console.WriteLine(maxNumber);
        }
    }
}