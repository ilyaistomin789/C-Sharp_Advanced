using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    interface IObserver
    {
        void Update(Object obj);
    }

    interface IObservable
    {
        void RegisterObserver(IObserver observer);

        void RemoveObserver(IObserver observer);

        void NotifyObservers();
    }

    class Game : IObservable
    {
        GameInfo gameInfo;

        List<IObserver> observers;
        public Game()
        {
            observers = new List<IObserver>();

            gameInfo = new GameInfo();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(gameInfo);
            }
        }

        public void LVL()
        {
            Random random = new Random();
            gameInfo.lvl = random.Next(0,11);
            NotifyObservers();
        }
    }

    class GameInfo
    {
        public int lvl { get; set; }
    }

    class Hero : IObserver
    {
        public string Name { get; set; }

        IObservable game;

        public Hero(string name, IObservable observable)
        {
            this.Name = name;
            game = observable;
            game.RegisterObserver(this);
        }

        public void Update(object obj)
        {
            GameInfo gameInfo = (GameInfo)obj;

            if (gameInfo.lvl < 10)
            {
                Console.WriteLine($"The player {this.Name} has {gameInfo.lvl} lvl");
            }
            else
                Console.WriteLine($"The player {this.Name} has max lvl !");
        }
        public void StopPlay()
        {
            game.RemoveObserver(this);
            game = null;
        }
    }

    
    
}