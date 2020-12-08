using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Делегаты_на_кубиках
{
    class Dice
    {
        int a;
        int b;

        static Random rand = new Random();
        DelegateShow Show;

        public Dice(DelegateShow show)
        {
            this.Show = show;
        }

        public void Go()
        {
            a = rand.Next(1, 7);
            b = rand.Next(1, 7);
            Show(a, b);
        }
    }
}
