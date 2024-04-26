using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Web.Ej4;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {
        static List<Character> characterList = [];
        static Enemy enemy;
        static IFight hero;

        [HttpGet("[action]")]
        public void GetForceCharacter([FromQuery] string name, float agility, float magic)
        {
            var character = new ForceCharacter(name, agility, magic);
            characterList.Add(character);
        }

        [HttpGet("[action]")]
        public void GetAgilityCharacter([FromQuery] string name, float force,  float agility, float magic)
        {
            var character = new AgilityCharacter(name, force, agility, magic);
            characterList.Add(character);
            hero = character;
        }

        

        [HttpGet("[action]")]
        public void GetMagicCharacter([FromQuery] string name, float force, float agility, float magic)
        {
            var character = new MagicCharacter(name, force, agility, magic);
            characterList.Add(character);
        }

        [HttpGet("[action]")]
        public void GetEnemy([FromQuery] int level)
        {
            enemy = new Enemy(level);
        }

        [HttpGet("[action]")]
        public void SimulateFight()
        {
            Turn.GroupAtack(characterList, enemy);

            Turn.FightMoves(hero);
        }
    }
}
