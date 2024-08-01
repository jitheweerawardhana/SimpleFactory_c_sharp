using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class BurgerFactory
    {
        public Burger CreatBurger(String type)
        {
            Burger burger = null;
            if (type == "Beef")
            {
                burger = new BeefBurger();
            }
            else if (type == "Veggi")
            {
                burger = new VeggiBurger();
            }

            else if (type == "Chiken")
            {
                burger = new ChikenBurger();
            }

            return burger;

        }
    }
}
