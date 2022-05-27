namespace DOTNET_POO.SRC.Entities
{
    public class Wizard
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
 public string Name;

        public int Level;

        public string HeroType;

        
        public override string ToString()

        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }
        
        public string Attack()
        {
            return this.Name + "Lançou Magia";
        
        }


        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                 return this.Name + "Lançou Magia super efetiva com bonus de ataque de " + Bonus;
            }
            
            else
            {
            return this.Name + "Lançou Magia com froça fraca " + Bonus;
            }
        }
                
    }
}