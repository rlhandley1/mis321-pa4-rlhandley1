using mis321_pa4_rlhandley1.Interfaces;

namespace mis321_pa4_rlhandley1.Weapons
{
    public class Distract : IAttack
    {
        public void Attack()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write("\nJack Sparrow has used distract!");;
        }
    }
}