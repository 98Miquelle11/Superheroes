using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    enum Colors // nadanie poszczególnym bohaterom kolorów
    {
        purple, yellow
    }
    interface ISpecialAttack
    {
        void SpecialAttack(Hero hero);
    }
    abstract class Hero // nie chcemy instancjonować tej klasy, dlatego robimy ją abstrakcyjną
    {
        public string Name { get; } // nazwa tylko do odczytu, ponieważ nie chcę jej zmieniać w trakcie programu
        public int FullHP { get; } // ta właściwość również nie będzie zmieniana w trakcie trwania programu
        private int actualHP;

        // Name i FullHP będziemy ustawiać z konstruktora wewnątrz

        public int ActualHP
        {
            get { return actualHP; }
            set
            {   // będziemy ją zmieniać pod pewnymi warunkami
                if (value < 0)
                {
                    actualHP = 0;
                }
                else if (value > FullHP)
                {
                    actualHP = FullHP;
                }
                else actualHP = value;

            }
        }
        public Colors Color { get; set; } // będziemy je ustawiać z zewnątrz
        
        protected Random rnd = new Random();

        public bool UsedSpecialAttack { get; set; } = false;

        public Hero(string name, int fullhp, Colors color)
        {
            Name = name;
            FullHP = fullhp;
            ActualHP = FullHP;
            Color = color;
        }

        public abstract void DefaultAttack(Hero hero); // obiekt Hero będzie obiektem atakowanym
        public abstract void Heal();
        public override string ToString()
        {
            return $"{Name} - {ActualHP}/{FullHP}";
        }
    }
}
