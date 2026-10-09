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
            Console.Clear();
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
            bool done;
            double weight;
            int planet;

            done = false;

            Console.WriteLine("Welcome To Space Boxing, Earthling!");
            Console.WriteLine("(Press Enter To Continue)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please Input Your Earth Weight:");
            
            
            while(!Double.TryParse(Console.ReadLine(), out weight) || weight < 0)
            {
                Console.WriteLine("Invalid weight, try again");
            }



            Console.Clear();
            Console.Write("Your Earth Weight Is " + weight);
            Console.WriteLine("lbs");
            //Console.WriteLine("Choose Which Planet You Would Like To Fight On:");
            //Console.WriteLine("1 - Venus");
            //Console.WriteLine("2 - Mars");
            //Console.WriteLine("3 - Jupiter");
            //Console.WriteLine("4 - Saturn");
            //Console.WriteLine("5 - Uranus");
            //Console.WriteLine("6 - Neptune");
            //planet = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            while (!done) 
            {
                Console.WriteLine("Choose Which Planet You Would Like To Fight On:");
                Console.WriteLine("1 - Venus");
                Console.WriteLine("2 - Mars");
                Console.WriteLine("3 - Jupiter");
                Console.WriteLine("4 - Saturn");
                Console.WriteLine("5 - Uranus");
                Console.WriteLine("6 - Neptune");
                Console.WriteLine("7 - Quit");

                planet = Convert.ToInt32(Console.ReadLine());
                
                
                Console.Clear();
                if (planet == 1)
                {
                    Console.WriteLine("You have selected Venus.");
                    Console.WriteLine();
                    Console.Write("Your Weight would be " + Math.Round(weight * 0.78, 2));
                    //double result = Math.Round(weight * 0.78, 2);
                    Console.WriteLine(" on Venus.");
                    Console.WriteLine("Not bad.");
                }
                else if (planet == 2)
                {
                    Console.WriteLine("You have selected Mars.");
                    Console.WriteLine();
                    Console.Write("Your Weight would be " + Math.Round(weight * 0.39, 2));
                    Console.WriteLine(" on Mars.");
                    Console.WriteLine("Good Luck.");
                }
                else if (planet == 3)
                {
                    Console.WriteLine("You have selected Jupiter.");
                    Console.WriteLine();
                    Console.Write("Your Weight would be " + Math.Round(weight * 2.65, 2));
                    Console.WriteLine(" on Jupiter.");
                    Console.WriteLine("You Have a Fair Shot.");
                }
                else if (planet == 4)
                {
                    Console.WriteLine("You have selected Saturn.");
                    Console.WriteLine();
                    Console.Write("Your Weight would be " + Math.Round(weight * 1.17, 2));
                    Console.WriteLine(" on Saturn.");
                    Console.WriteLine("Im Rootin' For Ya.");
                }
                else if (planet == 5)
                {
                    Console.WriteLine("You have selected Uranus.");
                    Console.WriteLine();
                    Console.Write("Your Weight would be " + Math.Round(weight * 1.05, 2));
                    Console.WriteLine(" on Uranus.");
                    Console.WriteLine("Hehe. Uranus.");
                }
                else if (planet == 6)
                {
                    Console.WriteLine("You have selected Neptune.");
                    Console.WriteLine();
                    Console.Write("Your Weight would be " + Math.Round(weight * 1.23, 2));
                    Console.WriteLine(" on Neptune.");
                    Console.WriteLine("Not too shabby.");
                }
                else if (planet == 7)
                    done = true;
                else
                {
                    Console.WriteLine("Invalid planet, press ENTER to continue");
                    Console.ReadLine();

                }

            }


            //if (planet == 1)
            //{
            //    Console.WriteLine("You have selected Venus.");
            //    Console.WriteLine();
            //    Console.Write("Your Weight would be " + Math.Round(weight * 0.78, 2));
            //    //double result = Math.Round(weight * 0.78, 2);
            //    Console.WriteLine(" on Venus.");
            //    Console.WriteLine("Not bad.");
            //}
            //else if (planet == 2)
            //{
            //    Console.WriteLine("You have selected Mars.");
            //    Console.WriteLine();
            //    Console.Write("Your Weight would be " + Math.Round(weight * 0.39, 2));
            //    Console.WriteLine(" on Mars.");
            //    Console.WriteLine("Good Luck.");
            //}
            //else if (planet == 3)
            //{
            //    Console.WriteLine("You have selected Jupiter.");
            //    Console.WriteLine();
            //    Console.Write("Your Weight would be " + Math.Round(weight * 2.65, 2));
            //    Console.WriteLine(" on Jupiter.");
            //    Console.WriteLine("You Have a Fair Shot.");
            //}
            //else if (planet == 4)
            //{
            //    Console.WriteLine("You have selected Saturn.");
            //    Console.WriteLine();
            //    Console.Write("Your Weight would be " + Math.Round(weight * 1.17, 2));
            //    Console.WriteLine(" on Saturn.");
            //    Console.WriteLine("Im Rootin' For Ya.");
            //}
            //else if (planet == 5)
            //{
            //    Console.WriteLine("You have selected Uranus.");
            //    Console.WriteLine();
            //    Console.Write("Your Weight would be " + Math.Round(weight * 1.05, 2));
            //    Console.WriteLine(" on Uranus.");
            //    Console.WriteLine("Hehe. Uranus.");
            //}
            //else if (planet == 6)
            //{
            //    Console.WriteLine("You have selected Neptune.");
            //    Console.WriteLine();
            //    Console.Write("Your Weight would be " + Math.Round(weight * 1.23, 2));
            //    Console.WriteLine(" on Neptune.");
            //    Console.WriteLine("Not too shabby.");
            //}
            //else if (planet >= 7)
            //{
            //    Console.WriteLine("You Have Selected An Invalid Planet.");
            //    Console.WriteLine("Please Select an Actual Planet.");

            //    planets = false;

            //}
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