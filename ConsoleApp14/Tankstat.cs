using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp14
{
    class Tankstat
    {
        private string name { get; set; }
        private int ammunition { get; set; }
        private int armor { get; set; }
        private int maneuver { get; set; }

        private int ammunitionMinus { get; set; }
        private int armorMinus { get; set; }
        private int maneuverMinus { get; set; }
        private static int countPantera { get; set; }
        private static int countT34 { get; set; }
        public Tankstat(string name, int ammunition, int armor, int maneuver)
        {
            this.name = name;
            this.ammunition = ammunition;
            this.armor = armor;
            this.maneuver = maneuver;
        }
        public override string ToString()
        {
            return $"The name of the tank is {name} the amount of ammunition left is {ammunition} the strength of armor is {armor} the maneuver level is {maneuver}";
        }

        public static Tankstat operator *(Tankstat tank1, Tankstat tank2)
        {
            return tank1 * tank2;
        }

        public static Tankstat operator ^(Tankstat tank1, Tankstat tank2)
        {
            return tank1 ^ tank2;
        }
        public Tankstat() { }
        public void Tankcreate()
        {
            Random rand = new Random();
            //Tankstat[] pantera = new Tankstat[5];
            pantera[0] = new Tankstat("Pantera(1)", rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100));
            pantera[1] = new Tankstat("Pantera(2)", rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100));
            pantera[2] = new Tankstat("Pantera(3)", rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100));
            pantera[3] = new Tankstat("Pantera(4)", rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100));
            pantera[4] = new Tankstat("Pantera(5)", rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100));

            //Tankstat[] T34 = new Tankstat[5];
            T34[0] = new Tankstat("T-34(1)", rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100));
            T34[1] = new Tankstat("T-34(2)", rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100));
            T34[2] = new Tankstat("T-34(3)", rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100));
            T34[3] = new Tankstat("T-34(4)", rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100));
            T34[4] = new Tankstat("T-34(5)", rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100));
            foreach (Tankstat panteras in pantera)
            {
                Console.WriteLine(panteras);
            }
            foreach (Tankstat T34S in T34)
            {
                Console.WriteLine(T34S);
            }

        }
        Tankstat[] pantera = new Tankstat[5];
        Tankstat[] T34 = new Tankstat[5];
        public void attack()
        {
            for (int i = 0; i < pantera.Length; i++)
            {
                while (pantera[i].ammunition > 0 && pantera[i].armor > 0 && pantera[i].maneuver > 0)
                {
                    Console.WriteLine("Initializer is going to attack the tank");
                    Random rambo = new Random();
                    ammunitionMinus = rambo.Next(1, 20);
                    pantera[i].ammunition = pantera[i].ammunition - ammunitionMinus;
                    armorMinus = rambo.Next(1, 10);
                    pantera[i].armor = pantera[i].armor - armorMinus;
                    maneuverMinus = rambo.Next(2, 15);
                    pantera[i].maneuver = pantera[i].maneuver - maneuverMinus;
                    Console.WriteLine($"The name of the tank {pantera[i].name} has {pantera[i].ammunition} ammunition left the armor is {pantera[i].armor} and the manuever is {pantera[i].maneuver}, wait for 1 seconds for next move");
                    countPantera++;
                    
                    Thread.Sleep(1000);
                }
                
            }
            Console.WriteLine($"The total number of hits it took to take down Pantera tanks is {countPantera} hits");
            for (int i = 0; i < T34.Length; i++)
            {
                while (T34[i].ammunition > 0 && T34[i].armor > 0 && T34[i].maneuver > 0)
                {
                    Console.WriteLine("Initializer is going to attack the tank");
                    Random rambo = new Random();
                    ammunitionMinus = rambo.Next(1, 20);
                    T34[i].ammunition = T34[i].ammunition - ammunitionMinus;
                    armorMinus = rambo.Next(1, 10);
                    T34[i].armor = T34[i].armor - armorMinus;
                    maneuverMinus = rambo.Next(2, 15);
                    T34[i].maneuver = T34[i].maneuver - maneuverMinus;
                    Console.WriteLine($"The name of the tank {T34[i].name} has {T34[i].ammunition} ammunition left the armor is {T34[i].armor} and the manuever is {T34[i].maneuver}, wait for 1 seconds for next move");
                    countT34++;

                    Thread.Sleep(1000);
                }

            }
            Console.WriteLine($"The total number of hits it took to take down T34 tanks is {countT34} hits");
        }
        public void winner()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine($"The total number of hits it took to take down Pantera tanks is {countPantera} hits");
            Console.WriteLine($"The total number of hits it took to take down T34 tanks is {countT34} hits");
            if(countPantera > countT34)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("PANTERA WINS THE TANK BATTLE!!!!!!!!!!!");
            }
            else if (countPantera == countT34)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("IT IS A TIE");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("T34 WINS THE TANK BATTLE!!!!!!!!!!!!!!!!!!!");
            }
        }
    }
}