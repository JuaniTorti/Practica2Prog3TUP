namespace Web.Ej4
{
    public abstract class Character 
    {
        public string Name { get; set; }
        public float Force { get; set; }
        public float Agility { get; set; }
        public float Magic { get; set; }

        public abstract float CalculateDamage();
        public string Atack()
        {
            return $"{Name} hizo {CalculateDamage()} de daño";
        }
        
    }
}
