using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Harry
{
    internal class Player
    {
        public string name = "fahad";
        private int health = 56;
        public int getHealth()
        {
            return health;
        }
        public void setHealth(int h)
        {
            health = h;
        }
    }
}
