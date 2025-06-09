using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hero> heroes = new List<Hero>();
            heroes.Add(new Wizard("Wizard", 500, Colors.green));
            heroes.Add(new Wizard("Knight", 700, Colors.red));

            Hero player1;
            Hero player2;

            bool isChosed = false;
            do
            {
                isChosed = ChooseHero(out player1, 1, ref heroes);
            } while (!isChosed);

            do
            {
                isChosed = ChooseHero(out player2, 2, ref heroes);
            } while (!isChosed);

            bool isPlayer1Turn = true;

            do
            {
                Console.Clear();
                switch (player1.Color)
                {
                    case Colors.red:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Colors.green:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Payer 1");
                Console.WriteLine(player1);

                switch (player2.Color)
                {
                    case Colors.red:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Colors.green:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    default:
                        break;
                }
                Console.CursorTop = 0;
                Console.CursorLeft = 25; // gracz 2 będzie po prawej stronie
                Console.WriteLine("Payer 2");
                Console.CursorTop = 1;
                Console.CursorLeft = 25;
                Console.WriteLine(player2);
                Console.ResetColor();

                Hero actualPlayer = isPlayer1Turn ? player2 : player2;
                Hero otherPlayer = isPlayer1Turn ? player2 : player1;

                Console.WriteLine($"\nRuch gracza: {(isPlayer1Turn ? 1 : 2)}");
                Console.WriteLine("Co chcesz zrobić?");
                Console.WriteLine("1. Podstawowy atak");
                Console.WriteLine("2. Ulecz");

                ConsoleKey key;
                do
                {
                    key = Console.ReadKey().Key;

                    switch (key)
                    {
                        case ConsoleKet.D1:
                            actualPlayerPlayer.DefaultAttack(otherPlayer);
                            break;
                        case ConsoleKey.D2:
                            actualPlayer.Heal();
                        default;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Nie ma takiego ruchu.");
                            Console.ResetColor();
                            break;
                    }
                } while (key != ConsoleKey.D1 && key != ConsoleKey.D2);

                if (player1.ActualHP == 0 || player2.ActualHP == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Niestety!");
                    Console.ResetColor();
                }
                else
                {

                }

                    Console.ReadKey();

            } while (player1.ActualHP > 0 && player2.ActualHP > 0); 

            Console.ReadKey();
        }
        static bool ChooseHero(out Hero hero, int player, ref List<Hero> heroes) // zwraca referencję i dba o to, aby zmienna została co najmniej zmieniona albo przypisana po raz pierwszy
        {
            Console.Clear();
            Console.WriteLine($"Gracz {player} wybiera swoją postać:");

            for (int i = 0; i < heroes.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{heroes[i].Name}");
            }

            int num;
            int.TryParse(Console.ReadLine(), out num);

            if (num >= 1 && num <= heroes.Count)
            {
                hero = heroes[num - 1];
                heroes.Remove(hero);
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nie ma takiego bohatera.");
                Console.ResetColor();
                Console.ReadKey();
                hero = null;
                return false;
            }
        }
    }
}