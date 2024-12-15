namespace Program_calculates_average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"The program calculates the average
of the numbers. To finish entering
numbers, press ENTER.
To start a newcalculation, press any button
");

            while (true)
            {
                List<double> listNumbers = new List<double>();
                Console.WriteLine("======================================================Average===========================================================");

                while (true)
                {
                    Console.Write("Enter the following number:");
                    var valueFromConsole = Console.ReadLine();
                    if (valueFromConsole == "") break;

                    if (!double.TryParse(valueFromConsole, out double Number))
                    {
                        Console.WriteLine("The entered value is not a number\n");
                        continue;
                    }
                    listNumbers.Add(Number);

                    Console.WriteLine("List: {0}", string.Join(", ", listNumbers));
                }

                var average = listNumbers.Sum() / listNumbers.Count;

                Console.WriteLine("Results: {0}\n", average);
                Console.ReadKey();
            }
        }
    }
}