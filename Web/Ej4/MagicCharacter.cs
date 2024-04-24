namespace Web.Ej4
{
    public class MagicCharacter : Character
    {
        public MagicCharacter(string name, float force, float agility, float magic = 60)
        {
            Name = name;
            Agility = agility;
            Magic = magic;
            Force = force;
        }

        public override float CalculateDamage()
        {
            float damage = Force + Agility + Magic*4;
            return damage;

        }

        public new string Atack()
        {
            return $"{Name} hizo {CalculateDamage()} de daño gracias a su magia";
        }
    }
}
