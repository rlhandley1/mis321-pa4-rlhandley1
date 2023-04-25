using mis321_pa4_rlhandley1.Interfaces;

namespace mis321_pa4_rlhandley1.Characters
{
public class Character
    {
        public string UserName {get;set;}
        public string CharacterName {get;set;}
        public int MaxPower {get;set;}
        public double Health {get;set;}
        public int AttackStrength {get;set;}
        public int DefensivePower {get;set;}
        public IAttack attackBehavior {get;set;}
        public IDefend defendBehavior {get;set;}

        public Character()
        {

        }

        public void SetAttackBehavior(IAttack attackBehavior)
        {
            this.attackBehavior = attackBehavior;
        }

        public void SetDefendBehavior(IDefend defendBehavior)
        {
            this.defendBehavior = defendBehavior;
        }

        public static int GetMaxPower()
        {
            Random randomNum = new Random();
            int mPower = randomNum.Next(1,101);
            return mPower;
        }

        public static int GetAttackStrength(int MaxPower)
        {
            Random randomNum = new Random();
            int aStrength = randomNum.Next(1, MaxPower);
            return aStrength;
        }

        public static int GetDefensivePower(int MaxPower)
        {
            Random randomNum = new Random();
            int dPower = randomNum.Next(1, MaxPower);
            return dPower;
        }

    }
}
