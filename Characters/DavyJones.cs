using mis321_pa4_rlhandley1.Weapons;

namespace mis321_pa4_rlhandley1.Characters
{
    public class DavyJones : Character
    {
        public DavyJones()
        {
            attackBehavior = new Cannon();
        }
    }
}