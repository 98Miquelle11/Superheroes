using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Wizard : Hero, ISpecialAttack
    {
        public Wizard(string name, int fullhp, Colors color) : base(name, fullhp, color)
        {
        }

        public override void DefaultAttack(Hero hero)
        {
            int hp = rnd.Next(100,151); // losowa wartość między 100 a 150
            hero.ActualHP -= hp;
            Console.WriteLine($"\nPlayer {Name} hit {hp} damage points to the player {hero.Name}.");
        }

        public override void Heal()
        {
            int hp = rnd.Next(100, 201);
            ActualHP += hp;
            Console.WriteLine($"\nPlayer {Name} healt himself for {hp} hp.");
        }

        public void SpecialAttack(Hero hero)
        {
            int hp = rnd.Next(150, 251); // losowa wartość między 100 a 150
            hero.ActualHP -= hp;
            Console.WriteLine($"\nSpecial Attack: Player {Name} hit {hp} damage points to the player {hero.Name}.");
        }
    }
}
