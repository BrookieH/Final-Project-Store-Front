using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Store_Front.Properties
{
    class Flower
    {
        public string rose, tulip, lily;
        public string type;
        public int amount;

        public Flower (string _type, int _amount)
        {
            type = _type;
            amount = _amount;
        }

        public Flower (string _rose, string _tulip, string _lily)
        {
            rose = _rose;
            tulip = _tulip;
            lily = _lily;

        }

    }
}
