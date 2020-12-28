using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_2.Adapter
{
    class CardReader : IUsb
    {
        private ICards _cards;

        public CardReader(ICards cards)
        {
            _cards = cards;
        }
        public void ConnectWithUsbCable()
        {
            _cards.Insert();
            _cards.GetResult();
        }
    }
}
