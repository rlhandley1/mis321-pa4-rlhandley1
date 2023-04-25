using mis321_pa4_rlhandley1.Interfaces;

namespace mis321_pa4_rlhandley1.Weapons
{
    public class Sword : IAttack
    {
        public void Attack()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write("\nWill Turner has used his sword");;
        }
    }
}