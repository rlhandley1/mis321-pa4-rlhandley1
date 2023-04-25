using mis321_pa4_rlhandley1.Weapons;

namespace mis321_pa4_rlhandley1.Characters
{
    public class JackSparrow : Character
    {
        public JackSparrow()
        {
            attackBehavior = new Distract();
        }
    }
}