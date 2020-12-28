using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Human
    {
        private int lives = 10;

        private int speed = 300;

        public void Speedup()
        {
            if (speed <= 500)
            {
                speed += 20;
                Console.WriteLine($"Accelerate. Your speed is : {speed}");
            }
            else
            {
                Console.WriteLine("Your speed can't be more than 500 !");
            }
        }

        public HumanMemento SaveState()
        {
            Console.WriteLine($"Save. The player has {lives} HP and {speed} move speed.");

            return new HumanMemento(lives,speed);
        }

        public void RestoreState(HumanMemento memento)
        {
            this.lives = memento.Lives;

            this.speed = memento.Speed;

            Console.WriteLine($"Recovery. {lives} HP and {speed} speed");
        }

    }
    
    class HumanMemento
    {
        public int Speed { get; set; }

        public int Lives { get; set; }

        public HumanMemento(int lives, int speed)
        {
            this.Lives = lives;

            this.Speed = speed;
        }
    }
    class GameHistory
    {
        public Stack<HumanMemento> history { get; private set; }

        public GameHistory()
        {
            history = new Stack<HumanMemento>();
        }
    }
}
