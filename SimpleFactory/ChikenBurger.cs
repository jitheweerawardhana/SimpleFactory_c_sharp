using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class ChikenBurger : Burger
    {
        public override void Prepare()
        {
            Console.WriteLine("I'm Preparing a Chiken Burger");
        }
    }
}


