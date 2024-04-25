namespace Web.Ej4
{
    public class Enemy
    {
        public float HealthPoints { get; set; }
        public int Level { get; set; }

        public Enemy(int level = 1, float healPoints = 400)
        {          
            Level = level;
            HealthPoints = healPoints * level;
        }
    }
}
