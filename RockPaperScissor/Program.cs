using Microsoft.Win32;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Xml.Schema;

namespace RockPaperScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            while (playAgain)
            {
                Random random = new Random();
                int computerChoice = random.Next(1, 4);
                Menu();

                int userChoice = GetValidChoice("Enter your choice: ");

                Console.WriteLine("You choose: " + GetChoice(userChoice));
                Console.WriteLine("Computer choose: " + GetChoice(computerChoice));

                DetermineWinner(computerChoice, userChoice);
                playAgain = AskToPlay();
            }

        }
        static bool AskToPlay()
        {
            while (true)
            {
                Console.Write("Do you want to play again(yes or no): ");
                string ans = Console.ReadLine().Trim().ToLower();
                if (ans == "yes")
                    return true;
                else if (ans == "no")
                    return false;
                else
                    Console.WriteLine("Please say yes or no only!");
                
            }
        }
        static void DetermineWinner(int computerChoice, int userChoice)
        {
            if(computerChoice == userChoice)
            {
                Console.WriteLine("Its a tie!");
            }
            else if((computerChoice==1 && userChoice==3)||(computerChoice==2 && userChoice == 1)||(computerChoice == 3 && userChoice == 2))
            {
                Console.WriteLine("Computer wins!");
            }
            else
            {
                Console.WriteLine("You win!");
            }
        }
        static string GetChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    return "Rock";
                case 2:
                    return "Paper";
                case 3:
                    return "Scissors";
                default:
                    throw new Exception("Invalid choice!");
            }
        }
        static double GetValidNum(string propmt)
        {
            while (true)
            {
                Console.Write(propmt);
                if(double.TryParse(Console.ReadLine(),out double n))
                {
                    return n;
                }
                else
                {
                    Console.WriteLine("Please enter valid number!");
                }
            }
        }
        static int GetValidChoice(string propmt)
        {
            while (true)
            {
                Console.Write(propmt);
                if (int.TryParse(Console.ReadLine(), out int n) && n>=1 && n<=3)
                {
                    return n;
                }
                else
                {
                    Console.WriteLine("Please enter valid integer choice between 1 to 4!");
                }
            }
        }
        static void Menu()
        {
            Console.WriteLine("Choose Rock, Paper, or Scissors: ");
            Console.WriteLine("1.Rock");
            Console.WriteLine("2.Paper");
            Console.WriteLine("3.Scissors");
        }
    }
}

/*Choose Rock, Paper, or Scissors:
1. Rock
2. Paper
3. Scissors
Enter your choice: 1
You chose: Rock
Computer chose: Scissors
You win!

*/
/*static void Main(string[] args)
        {
            Random random = new Random();
            int randomGuess = random.Next(1, 101);
            int userGuess;
            int attempt = 0;
            while (true)
            {
                userGuess = GetValidGuess("Guess a number between 1 and 100: ",1,100);
                attempt++;
                if (userGuess < randomGuess)
                {
                    Console.WriteLine("Too low.");
                }    
                else if (userGuess > randomGuess)
                {
                    Console.WriteLine("Too high.");
                }   
                else
                {
                    Console.WriteLine("Congratulations! You found it!");
                    Console.WriteLine($"Attempts: {attempt}");
                    break;
                }
            }
            

        }
        static int GetValidGuess(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    if (n >= min && n <= max)
                    {
                        return n;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter a number between {min} and {max}.");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid integer!");
                }
            }
        }*/
/*enum Price
        {
            High = 1000,
            Medium = 500,
            Low = 100
        }
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

        
        static void Main(string[] args)
        {
            //Vehicle v = new Vehicle();
            Car c = new Car();
            Bike b = new Bike();
            Plane p = new Plane();
            Price n = Price.Medium;
            int s = (int)Price.Medium;
            Console.WriteLine((int)n);
            //v.tire();
            c.tire();
            b.tire();
            p.tire();
            c.fuel();
            b.fuel();
            p.fuel();
            //c.fuel();
            checkAge(20);
            int[] ary = { 1, 2, 3 };
            try 
            {
                Console.WriteLine(ary[10]);

            } 
            catch(Exception e)
            {
                Console.WriteLine("Something Wring!!!!!");
            }
            finally
            {
                Console.WriteLine("None");
            }
            
            string f1 = "hello World";
            File.WriteAllText("test.txt","Heythere");
            string f = File.ReadAllText("test.txt");
            Console.WriteLine(File.ReadAllText("test.txt"));
            File.Replace("test.txt", "test2.txt");
            

        }
        interface IVehicle 
        {
            void tire();
            //void fuel();
        }
        interface IFuel
        {
            void fuel();
        }
        class Car : IVehicle, IFuel
        {
            public void tire()
            {
                Console.WriteLine("Car has four tires");
            }
            public void fuel()
            {
                Console.WriteLine("Needs fuel");
            }
        }
        class Bike : IVehicle, IFuel
        {
            public void tire()
            {
                Console.WriteLine("Bike has two tires");
            }
            public void fuel()
            {
                Console.WriteLine("Needs fuel");
            }
        }
        class Plane : IVehicle, IFuel
        {
            public void tire()
            {
                Console.WriteLine("Plane has three tires");
            }
            public void fuel()
            {
                Console.WriteLine("Needs fuel");
            }
        }*/