using Web.Ej1;

namespace Web.Ej4
{
    public class Turn
    {
        public static void GroupAtack(IList<Character> characters, Enemy enemy)
        {
            var hero1= characters[0];
            var hero3 = characters[2];

            hero3.Atack(enemy);
            Console.WriteLine($"El enemigo quedo con {enemy.HealthPoints} puntos de vida");

            hero1.Atack(enemy);
            Console.WriteLine($"El enemigo quedo con {enemy.HealthPoints} puntos de vida");
        }
        public static void FightMoves(IFight hero)
        {
            hero.Defense();
        }

    }
}
