using System.Net.WebSockets;

namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start the main menu
            MainMenu();
            //
        }

        private static void MainMenu()
        {
            //Show main menu header text
            ShowMainMenuText();

            //Handle user input
            HandleUserInput();

        }

        private static void ShowMainMenuText()
        {
            //Present user with the navigation choices
            Console.WriteLine("Detta är huvudmenyn. Använd siffror enligt nedan för att navigera:");
            Console.WriteLine("0: Stäng ner programmet");
            Console.WriteLine("1: Visa biopris");
            Console.WriteLine("2: Visa biopris för ett sällskap");
            Console.WriteLine("3: Upprepa 10 gånger");
            Console.WriteLine("4: Det tredje ordet");
        }

        private static void HandleUserInput()
        {
            bool continueLoop = true;

            do
            {
                int input = ReadUserInput();
                
                //Act on user input
                switch (input)
                {
                    //Exit program
                    case 0:
                        continueLoop = false;
                        break;
                    //Handle all the valid input cases
                    case 1:
                        int age = AskAge();
                        ShowPrice(age);
                        break;
                    case 2:
                        ManyMovieVisitors();
                        break;
                    case 3:
                        RepeatTenTimes();
                        break;
                    case 4:
                        TheThirdWord();
                        break;
                    default:
                        //Not a valid menu item
                        Console.WriteLine("Bad input, not a valid menu item");
                        break;
                }

            } while (continueLoop);
        }

        private static int AskAge()
        {
            Console.WriteLine("Ange ålder:");

            var input = Console.ReadLine();
            return ParseInput(input);
        }

        private static int ParseInput(string? input)
        {
            int age = 0;
            var didParse = int.TryParse(input, out age);
            
            if (didParse)
            {
                return age;
            }

            //Handle case when input is not a int
            return age;
        }

        private static void ShowPrice(int age)
        {
            if (age < 20) {
                Console.WriteLine("Ungdomspris: 80kr");
            }else if(age>64)
            {
                Console.WriteLine("Pensionärspris: 90kr");
            }else
            {
                Console.WriteLine("Standardpris: 120kr");
            }                            
        }

        private static void ManyMovieVisitors()
        {
            Console.WriteLine("Hur många ska gå på bio?");
            var input = Console.ReadLine();

            int numberOfMovieVisitors = ParseInput(input);

            List<int> ages = new List<int>();

            for (int i= 0; i<numberOfMovieVisitors; i++)
            {
                ages.Add(AskAge());
            }

            int totalCost = CalculateCost(numberOfMovieVisitors, ages);

            Console.WriteLine($"Antal personer : {numberOfMovieVisitors}");
            Console.WriteLine($"Totalkostnad : {totalCost}");
        }

        private static int CalculateCost(int numberOfVisiors, List<int> ages)
        {
            int totalCost = 0;

            for(int i =0;i<numberOfVisiors; i++)
            {
                if (ages[i] < 20)
                {
                    totalCost += 80;
                }
                else if (ages[i] > 64)
                {
                    totalCost += 90;
                }
                else
                {
                    totalCost += 120;
                }
            }

            return totalCost;   
        }

        private static void RepeatTenTimes()
        {
            Console.WriteLine("Ange text som ska upprepas");
            var input = Console.ReadLine();

            for (int i = 0; i< 10; i++)
            {
                Console.Write($"{i}. {input}, ");
            }
        }

        private static void TheThirdWord()
        {
            Console.WriteLine("Ange en mening med minst 3 ord");
            var input = Console.ReadLine();

            var inputStrings = input.Split(' ');
            Console.WriteLine($"Det tredje ordet är : {inputStrings[2]}");

        }

        /// <summary>
        /// Reads user input
        /// </summary>
        /// <returns>
        /// -1 if input was not a number, otherwise the number from input 
        /// </returns>
        private static int ReadUserInput()
        {
            var input = Console.ReadLine();
            int inputNumber;

            //Handle input
            //Try to parse input to int 
            //If input is not an int, i.e is null, parsing fails, return -1
            //Else return the parsed int
            var didParse = int.TryParse(input, out inputNumber); 
            
            if(didParse)
            {
                return inputNumber;
            }

            return -1; 
        }
    }
}
