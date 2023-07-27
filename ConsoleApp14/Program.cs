using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Tankstat aTank = new Tankstat();
            aTank.Tankcreate();
            aTank.attack();
            aTank.winner();
        }
        
    }
}
