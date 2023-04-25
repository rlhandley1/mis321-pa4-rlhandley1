using mis321_pa4_rlhandley1.Interfaces;

namespace mis321_pa4_rlhandley1.Weapons
{
    public class Cannon : IAttack
    {
        public void Attack()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write("\nDavy Jones has shot a cannonball! ARGGGGG");
        }
    }
}