using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_LAB_2.Adapter;
using OOP_LAB_2.Composite;
using OOP_LAB_2.Decorator;

namespace OOP_LAB_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IUsb firstCard = new CardReader(new MicroSDCard());
            IUsb secondCard = new CardReader(new SDCard());
            firstCard.ConnectWithUsbCable();
            secondCard.ConnectWithUsbCable();

            School schoolBoy = new SchoolBoy();
            Decorator.Decorator bag = new Bag();
            Decorator.Decorator books = new Books();
            bag.School = schoolBoy;
            books.School = bag;
            bag.GoToSchool();

            var district = new Map();
            district.AddComponent(new MapComponent() { Title = "Mineeva street" });
            district.AddComponent(new MapComponent() { Title = "Yanischic street" });
            district.AddComponent(new MapComponent() { Title = "Solnechnaya street" });
            district.Draw();

            var city = new Map(){Title = "Pinsk"};
            city.AddComponent(district);
            city.Draw();
            Console.WriteLine(city.Find("Mineeva street"));




        }
    }
}
