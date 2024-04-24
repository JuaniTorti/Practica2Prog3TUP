using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Web.Ej4
{
    public class ForceCharacter : Character
    {
        public ForceCharacter(string name,float agility, float magic) 
        {
            Name = name;
            Agility = agility;
            Magic = magic;
            Force = 100;
        }

        public override float CalculateDamage()
        {
            float damage = (Force*2 - Agility) * Magic;
            return damage;

        }
    }
}
