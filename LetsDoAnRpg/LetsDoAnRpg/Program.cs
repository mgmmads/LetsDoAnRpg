using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsDoAnRpg
{
    class Program
    {
        static void Main(string[] args) //Escaping the static main class.
        {
            Program Escape = new Program();
            Escape.Run();
        }

        /// <summary>
        /// The main run method, used to initiate the program.
        /// </summary>
        public void Run()
        {
            MainMenu();

            Console.ReadKey();
        }

        public string MainMenu()
        {
            string menuChoice = "";
            bool RightInput = false;

            while (RightInput == false)
            {
                Console.Clear();
                Console.WriteLine("     #### Welcome to Ldar RPG ####\n     -_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n\n");
                Console.WriteLine("             1) Continue");
                Console.WriteLine("             2) New Game");
                Console.WriteLine("             3) Options\n");

                menuChoice = Console.ReadLine().ToUpper().Trim();

                switch (menuChoice)
                {
                    case "1":
                    case "CONTINUE":
                        MenuChoiceContinue();
                        break;

                    case "2":
                    case "NEWGAME":
                        MenuChoiceNewGame();
                        break;

                    case "3":
                    case "OPTIONS":
                        MenuChoiceOptions();
                        break;
                    default:
                        Console.WriteLine("Invalid Input!");
                        Console.ReadKey();
                        break;
                }
            }
            return menuChoice;
        }

        public void MenuChoiceContinue()
        {
            bool keepGoing = true;
            bool readFile = false;
            //Code to read from textfile, and then change ReadFile Boolean to True:

            while (keepGoing == true)
            {
                Console.Clear();
                Console.WriteLine("          #### Continue ####\n          -_-_-_-_-_-_-_-_-\n\n");
                
                if (readFile == true)
                {
                    //Load game
                }
                else if (readFile == false)
                {
                    Console.WriteLine("    No saved game found!\n    Would you like to create a new game?");
                    Console.Write("\n\n    (Yes / No) : ");
                    string ContinueFailChoice = Console.ReadLine().ToUpper();

                    switch (ContinueFailChoice)
                    {
                        case "Y":
                        case "YES":
                            keepGoing = false;
                            MenuChoiceNewGame();
                            break;

                        case "N":
                        case "NO":
                            keepGoing = false;
                            MainMenu();
                            break;

                        default:
                            Console.WriteLine("Invalit input!");
                            Console.ReadKey();
                            break;
                    }

                }
            }

        }

        public void MenuChoiceNewGame()
        {
            //Create character method!
        }

        public void MenuChoiceOptions()
        {
            Console.Clear();
            Console.WriteLine("          #### Options ####\n          -_-_-_-_-_-_-_-_-\n\n");
            Console.WriteLine("    What options did you expect in a console game?\n");
            Console.Write("    Press any key to get back to main menu.");
            Console.ReadKey();

            MainMenu();
        }
    }
}
