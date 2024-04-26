using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Web.Ej4
{
    public class ForceCharacter : Character , IFight
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

        public string Heal()
        {
            return $"El Personaje {Name} se ah curado";
        }
        public string Defense()
        {
            return $"El personaje {Name} activo su defensa";
        }
    }
}
