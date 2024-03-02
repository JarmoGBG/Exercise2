namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start the main menu
            //
        }

        private void MainMenu()
        {
            //Show main menu header text

            //Handle user input

            //Exit main menu
        }

        private void ShowMainMenuText()
        {
            //Present user with the navigation choises
        }

        private void MenuLoop()
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
                    default:
                        //Not a valid menu item
                        Console.WriteLine("Bad input, not a valid menu item");
                        break;
                }

            } while (continueLoop);
        }

        /// <summary>
        /// Reads user input
        /// </summary>
        /// <returns>
        /// -1 if input was not a number or was negative number, otherwise the positive number from input 
        /// </returns>
        private int ReadUserInput()
        {
            var input = Console.ReadLine();

            //Handle input
            //Try to parse input to int 
            //If input is not an int, i.e is null, parsing fails or is not a positive integer, return -1
            //Else return the parsed int

            //Temp
            return -1;
        }
    }
}
