namespace Dice_Roller
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a dice rolling game");
           
            
            bool keepGoing = true;
            while (keepGoing)
            {
        
                int sides = GetSidesCount();
                int result1 = RollDice1(sides);
                int result2 = RollDice2(sides);
                int sum = result1 + result2;

                if (sides >= 7)
                {
                    Console.WriteLine($"You rolled a {result1} and a {result2} ({sum} total) ");
                }
                else
                {
                    Console.WriteLine($"You rolled a {result1} and a {result2} ({sum} total) ");
                    Console.WriteLine(DiceCombos1(result1, result2));
                    Console.WriteLine(DiceCombos2(result1, result2));
                }
 
                keepGoing = GoAgain();
            }

        }
        public static int GetSidesCount()
        {
            Console.WriteLine("\nPlease enter the number of sides for your dice");
            string sideSelection = Console.ReadLine();
            int sidesCount = int.Parse(sideSelection);

            if (sidesCount < 1 || sidesCount > 20)
            {
              Console.WriteLine("Your input was not a valid number between 1 and 20");
              return GetSidesCount();
            }
            return sidesCount;
        }
        public static int RollDice1(int sides)
        {
            Random r = new Random();
            int roll1 = r.Next(1, sides + 1);
            return roll1;
        }
        public static int RollDice2(int sides)
        {
            Random r = new Random();
            int roll2 = r.Next(1, sides + 1);
            return roll2;
        }

        public static string DiceCombos1(int result1, int result2)
        {
            if (result1 + result2 == 2 || result1 + result2 == 3 || result1 + result2 == 12)
            {
                return "Craps";
            }
            else if (result1 + result2 == 7 || result1 + result2 == 11)
            {
                return "You Win";
            }
            return "";
        }
        public static string DiceCombos2(int result1 , int result2)
        {
            if(result1 == 1 && result2 == 1)
            {
                return "Snake Eyes";
            }
            else if(result1 == 1 && result2 == 2)
            {
                return "Ace Deuce";
            }
            else if( result1 == 6 && result2 == 6)
            {
                return "Box cars";
            }
            else
            {
                return "";
            }
        }
        public static bool GoAgain()
        {
            Console.WriteLine("\nWould you like to play again? Please enter Yes or No");
            string userInput = Console.ReadLine().ToLower().Trim();

            if (userInput == "yes" || userInput == "y")
            {

                return true;
            }
            else if (userInput == "no" || userInput == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please enter Yes or No");
                return GoAgain();
            }
        }
    }
}