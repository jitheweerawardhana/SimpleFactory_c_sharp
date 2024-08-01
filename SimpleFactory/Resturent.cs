using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Resturent
    {
        public Burger OrderBurger(String type)
        {
            BurgerFactory burgerFactory = new BurgerFactory();
            Burger burger = burgerFactory.CreatBurger(type);
            burger.Prepare();

            return burger;
        }
    }
}
