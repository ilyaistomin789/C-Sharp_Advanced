using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();        //Command

            Command command = new Command();

            invoker.SetCommand(new OnCommand(command));

            invoker.PressEnter();

            invoker.PressSpace();

            Console.WriteLine("-------------");

            //-------------------------------------

            Player player = new Player(new PlayerIsInFlight());

            player.Come();
            player.Flight();
            player.Stand();
            player.Stand();

            Console.WriteLine("----------------------");

            //-------------------------------------

            Human human = new Human();

            human.Speedup();

            GameHistory game = new GameHistory();

            game.history.Push(human.SaveState());


            human.Speedup();

            human.RestoreState(game.history.Pop());

            human.Speedup();

            Console.WriteLine("-----------------------");

            //---------------------------------------

            Game Game = new Game();

            Hero hero = new Hero("Ilya", Game);

            Game.LVL();

            hero.StopPlay();

            Game.LVL();

               
            Console.ReadKey();
        }
    }
}
