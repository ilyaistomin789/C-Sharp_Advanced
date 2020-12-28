using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_LAB_1.Abstract_Factory;
using OOP_LAB_1.Abstract_Factory.Warriors;
using OOP_LAB_1.Builder;
using OOP_LAB_1.Singleton;
using OOP_LAB_1.Prototype;

namespace OOP_LAB_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Abstract Factory-----");
            Warrior firstWarrior = new Warrior(new ChainMailAxeWarrior());
            Warrior secondWarrior = new Warrior(new ChainMailKnifeWarrior());
            Warrior thirdWarrior = new Warrior(new MetalAxeWarrior());
            Warrior fourthWarrior = new Warrior(new MetalKnifeWarrior());
            Console.WriteLine("--------------------------");
            Console.WriteLine("-----Singleton-----");
            President mrPresident = President.GetInstance();
            President spyPresident = President.GetInstance();
            Console.WriteLine("-------------------");
            Console.WriteLine("-----Builder-----");
            Builder.Builder builder = new ConcreteBuilder();
            Director director = new Director(builder);
            director.Launch();
            Builder.Builder customBuilder = new ConcreteBuilder();
            Director customDirector = new Director(customBuilder);
            customDirector.CustomLaunch(new JuniorDev(),new SeniorDev());
            Console.WriteLine("-----------------");
            Console.WriteLine("-----Prototype-----");
            Prototype.Prototype generateGame = new Prototype.Prototype();
            Console.WriteLine("////BASE OF GAME////");
            generateGame.Item = "World";
            generateGame.Property = "Base of Game (World)";
            generateGame.GetInfo();
            var landscape = generateGame.Clone() as Prototype.Prototype;
            landscape.Item = "Ground";
            landscape.Property = "Base of Game (Landscape)";
            landscape.GetInfo();
            var human = generateGame.Clone() as Prototype.Prototype;
            human.Item = "Human";
            human.Property = "Base of Game (Human)";
            human.GetInfo();
            Console.WriteLine("////////////////////");
            Console.WriteLine("////GAME ELEMENTS////");
            var earth = landscape.Clone();
            earth.Item = "Earth"; //without property
            earth.Property = "";
            earth.GetInfo();
            Console.WriteLine($"------{landscape.Property}");
            var man = human.Clone();
            man.Item = "Man";
            man.Property = "Person of Game";
            man.GetInfo();
            Console.WriteLine("/////////////////////");
            Console.WriteLine("-------------------");



        }
    }
}
