namespace D_and_O.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        public override string Attack()
        {
            return this.Name + " attacked with sword!";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " cast a super effective spell with " + Bonus + " bonus";    
            }
            else
            {
                return this.Name + " cast a weak spell with " + Bonus + " bonus";
            }
            
        }
    }
}