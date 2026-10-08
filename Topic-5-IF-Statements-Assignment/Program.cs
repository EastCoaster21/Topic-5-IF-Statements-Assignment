using System.ComponentModel.Design;

namespace Topic_5_IF_Statements_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose your activity:");
            Console.WriteLine();
            Console.WriteLine("1-Space Boxing");
            Console.WriteLine("2-Calculator");
            Console.WriteLine("3-Mini Quiz");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                SpaceBoxing();
            }
            else if (choice == 2)
            {
                Calculator();
            }
            else if (choice == 3)
            {
                MiniQuiz();
            }
        }
        public static void SpaceBoxing()
        {
            double weight;
            Console.WriteLine("Welcome To Space Boxing, Earthling!");
            Console.WriteLine("(Press Enter To Continue)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please Input Your Earth Weight");
            Double.TryParse(Console.ReadLine(), out weight);
            Console.Clear();
            Console.WriteLine("Your Earth Weight Is " + weight);

        }
        public static void Calculator()
        {
            Console.WriteLine("Welcome To The Calculator");
        }
        public static void MiniQuiz()
        {
            Console.WriteLine("Welcome To The Mini Quiz");
        }
    }
}