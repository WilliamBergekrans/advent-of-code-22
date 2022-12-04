namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Day[] days = new Day[25];

            // Add new days here
            days[1] = new Day1();

            // Check if input arguments were supplied.
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter the day you wish to run.");
            }

            // Try to convert the input arguments to numbers. This will throw
            // an exception if the argument is not a number.
            // num = int.Parse(args[0]);
            int day;
            bool testInput = int.TryParse(args[0], out day);
            if (!testInput)
            {
                Console.WriteLine("Please enter a numeric argument, 1, 2, 3, etc.");
            }

            string input1 = System.IO.File.ReadAllText(Path.Combine(Environment.CurrentDirectory, $"inputs/day{day}part{1}.txt"));
            string input2 = System.IO.File.ReadAllText(Path.Combine(Environment.CurrentDirectory, $"inputs/day{day}part{2}.txt"));

            string resultPart1 = days[day].SolutionPart1(input1);
            string resultPart2 = days[day].SolutionPart1(input2);
            Console.WriteLine(resultPart1);
        }
    }
}