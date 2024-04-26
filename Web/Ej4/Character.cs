namespace Web.Ej4
{
    public abstract class Character
    {
        public string Name { get; set; }
        public float Force { get; set; }
        public float Agility { get; set; }
        public float Magic { get; set; }

        public abstract float CalculateDamage();
        public float Atack(Enemy enemy)
        {
            enemy.HealthPoints = enemy.HealthPoints - CalculateDamage();

            Console.WriteLine($"{Name} hizo {CalculateDamage()} de daño al enemigo");

            return CalculateDamage();
        }
        
    }
}
