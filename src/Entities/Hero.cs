using static System.Console;

namespace D_and_O.src.Entities
{
    public class Hero
    {
        public string Name;
        public int Level;
        public string HeroType;

        public Hero( string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string ToString()
        {
            WriteLine($@" 
            Name: {this.Name}
            Level: {this.Level}
            Type: {this.HeroType}
            ");
            return "";
        }

        public virtual string Attack()
        {
            return this.Name + " cast a spell";
        }

        public string Attack(int Bonus)
        {
            return this.Name + "cast a spell with bonus " + Bonus;
        }

    }
}