namespace Web.Ej4
{
    public class MagicCharacter : Character , IFight
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

        public new float Atack(Enemy enemy)
        {
            enemy.HealthPoints = enemy.HealthPoints - CalculateDamage();

            Console.WriteLine($"{Name} hizo {CalculateDamage()} de daño gracias a su magia");

            return CalculateDamage();
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
