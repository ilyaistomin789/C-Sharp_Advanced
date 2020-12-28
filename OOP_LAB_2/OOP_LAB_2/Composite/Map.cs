using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_2.Composite
{
    public class Map : IComponent
    {
        private readonly List<IComponent> _map = new List<IComponent>();
        public string Title { get; set; }
        public void Draw()
        {
            Console.WriteLine(Title);
            foreach (var maps in _map)
            {
                maps.Draw();
            }
        }

        public IComponent Find(string title)
        {
            if (Title == title)
            {
                return this;
            }

            foreach (var maps in _map)
            {
                var found = maps.Find(title);
                if (found != null)
                {
                    return found;
                }
            }

            return null;
        }

        public void AddComponent(IComponent component)
        {
            _map.Add(component);
        }

        public void DeleteComponent(IComponent component)
        {
            _map.Remove(component);
        }

    }
}
