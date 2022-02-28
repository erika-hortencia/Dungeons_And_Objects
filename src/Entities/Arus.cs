namespace D_and_O.src.Entities
{
    public class Arus
    {
        public string Name;
        public int Level;
        public string HeroType;

        public Arus( string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

    }
}