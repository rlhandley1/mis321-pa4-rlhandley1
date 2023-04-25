namespace mis321_pa4_rlhandley1.Menu
{
    public class Menu
    {
        public int GetSelectedCharacter()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("\nPlease select a character to join the fight:");
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("\n1. Jack Sparrow\n2. Davy Jones\n3. Will Turner");
            int selectedCharacter = int.Parse(Console.ReadLine()); 
            while ((selectedCharacter != 1) && (selectedCharacter != 2) && (selectedCharacter != 3))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Invalid selection. Please try again.");
                Console.ForegroundColor = ConsoleColor.White;
                selectedCharacter = int.Parse(Console.ReadLine()); // update read
            }
            return selectedCharacter;
        }

    }
}