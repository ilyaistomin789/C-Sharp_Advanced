using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    interface IStatePlayer
    {
        void Flight(Player player);     // летит

        void Come(Player player);        // двигается

        void Stand(Player player);      // стоит
    }
    class PlayerIsInFlight : IStatePlayer
    {
        public void Flight(Player player)
        {
            Console.WriteLine("The player continues to fly !");
        }

        public void Come(Player player)
        {
            Console.WriteLine("Player began to move");
            player.State = new PlayerIs();
        }

        public void Stand(Player player)
        {
            Console.WriteLine("Player has stopped !");
            player.State = new PlayerStands();
        }

    }

    class PlayerIs : IStatePlayer
    {
        public void Flight(Player player)
        {
            Console.WriteLine("The player begins to fly !");
            player.State = new PlayerIsInFlight();
        }

        public void Come(Player player)
        {
            Console.WriteLine("The player keeps going");
            
        }

        public void Stand(Player player)
        {
            Console.WriteLine("The player stops !");
            player.State = new PlayerStands();
        }

    }

    class PlayerStands : IStatePlayer
    {
        public void Flight(Player player)
        {
            Console.WriteLine("The player began to fly !");
            player.State = new PlayerIsInFlight();
        }

        public void Come(Player player)
        {
            Console.WriteLine("The player starts walking");
            player.State = new PlayerIs();
        }

        public void Stand(Player player)
        {
            Console.WriteLine("The player still standing !");
        }

    }

    class Player
    {
        public IStatePlayer State { get; set; }

        public Player(IStatePlayer sp)
        {
            this.State = sp;
        }

        public void Flight()
        {
            State.Flight(this);
        }

        public void Come()
        {
            State.Come(this);
        }

        public void Stand()
        {
            State.Stand(this);
        }
    }
    

}
