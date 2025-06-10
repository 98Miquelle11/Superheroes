using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Knight : Hero
    {
        public Knight(string name, int fullhp, Colors color) : base(name, fullhp, color)
        {
        }

        public override void DefaultAttack(Hero hero)
        {
            int hp = rnd.Next(50, 201); // losowa wartość między 100 a 150
            hero.ActualHP -= hp;
            Console.WriteLine($"\nPlayer {Name} hit {hp} damage points to the player {hero.Name}.");
        }

        public override void Heal()
        {
            int hp = rnd.Next(50, 101);
            ActualHP += hp;
            Console.WriteLine($"\nPlayer {Name} healt himself for {hp} hp.");
        }
    }
}
