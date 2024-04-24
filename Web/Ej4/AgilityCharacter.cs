namespace Web.Ej4
{
    public class AgilityCharacter : Character
    {
        public AgilityCharacter(string name,float force, float agility, float magic)
        {
            Name = name;
            Agility = agility;
            Magic = magic;
            Force = force;
        }

        public override float CalculateDamage()
        {
            float damage = (Force/2) * Agility * (Magic/2);
            return damage;

        }
    }
}
