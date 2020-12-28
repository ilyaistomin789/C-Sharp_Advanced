using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    interface ICommand
    {
        void Jump();
        void FireGun();
    }

    class Command
    {
        public void Space()
        {
            Console.WriteLine("Jump !");
        }

        public void Enter()
        {
            Console.WriteLine("Fire !");
        }
    }

    class OnCommand : ICommand
    {
        Command command;

        public OnCommand(Command com)
        {
            command = com;
        }

        public void Jump()
        {
            command.Space();
        }

        public void FireGun()
        {
            command.Enter();
        }

    }

    class Invoker
    {
        ICommand command;

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void PressSpace()
        {
            command.Jump();
        }

        public void PressEnter()
        {
            command.FireGun();
        }

    }


}
