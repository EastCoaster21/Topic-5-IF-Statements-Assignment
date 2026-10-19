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

            Console.WriteLine("-Welcome To Space Boxing, Earthling!-");
            Console.WriteLine("(Press Enter To Continue)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please Input Your Earth Weight:");


            while (!Double.TryParse(Console.ReadLine(), out weight) || weight < 0)
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

                if (Int32.TryParse(Console.ReadLine(), out planet))
                {




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
                else
                {

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
        
        }
        public static void Calculator()
        {
            Console.WriteLine("Welcome To The Calculator");
        }
        public static void MiniQuiz()
        {
            double score = 0;
            int answer;
            string textAnswer;
            Console.WriteLine("-Welcome To The Mini Quiz-");
            Console.WriteLine();
            Console.WriteLine("These questions will be on the topic of Star Wars.");
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue:");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Question #1: When did the first Star Wars movie 'A New Hope' release?");
            Console.WriteLine();
            Console.WriteLine("1.1967");
            Console.WriteLine("2.1977");
            Console.WriteLine("3.1973");
            Console.WriteLine("4.1980");
            //Console.WriteLine("Please input the number of the response as your answer.");
            //score = Convert.ToInt32(Console.ReadLine());
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1977 || answer == 2)
            {
                score++;
                Console.WriteLine();
                Console.WriteLine("Correct! I'm surprised you knew that one.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Not Quite. Good Try though.");
            }
            Console.WriteLine("Press Enter to continue:");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Question #2: What is the name of Boba Fett's ship?");
            Console.WriteLine("The Millenium Falcon");
            Console.WriteLine("X-Wing");
            Console.WriteLine("The Slave 1");
            Console.WriteLine("Tie Fighter");
            textAnswer = Console.ReadLine();
            if (textAnswer.ToUpper() == "THE SLAVE 1" || textAnswer.ToUpper() == "SLAVE 1" || textAnswer.ToUpper() == "SLAVE1" || textAnswer.ToUpper() == "THESLAVE1")
            {
                score++;
                Console.WriteLine();
                Console.WriteLine("Correct! I'm Impressed.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Incorrect. Maybe you'll get the next one?");
            }
            Console.WriteLine("Press Enter to continue:");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Question #3: Who is the creator of the Star Wars Franchise?");
            textAnswer = Console.ReadLine();
            if (textAnswer.ToUpper() == "GEORGE LUCAS" || textAnswer.ToUpper() == "GEORGELUCAS")
            {
                score++;
                Console.WriteLine();
                Console.WriteLine("Correct, but that was an easy one.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("How did you mess that one up?");
            }
            Console.WriteLine("Press Enter to continue:");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Question #4: True or False:");
            Console.WriteLine("There are 8 Star Wars Films in the Skywalker Saga. (Mainline Films)");
            textAnswer = Console.ReadLine();
            if (textAnswer.ToUpper() == "FALSE" || textAnswer.ToUpper() == "F")
            {
                score++;
                Console.WriteLine();
                Console.WriteLine("Correct, Good Job.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Yikes.");
            }
            Console.WriteLine("Press Enter to continue:");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Congratulations on completing the quiz! Your final score is " + score);
            Console.WriteLine("/4");
            Console.Write("That's " + (Math.Round(score/4 * 100, 2)));
            Console.Write("%,");
            if (score == 0)
            {
                Console.WriteLine(" Maybe brush up on your Star Wars knowledge, bud.");
            }
            else if (score == 1)
            {
                Console.WriteLine(" Kind of a one trick aren't ya?");
            }
            else if (score == 2 || score == 3)
            {
                Console.WriteLine(" You did good. May the force be with you.");
            }
            else if (score == 4)
            { 
                Console.WriteLine(" You are a true Jedi. Congratulations.");
            }
        }           }
}
