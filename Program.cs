using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eendenvijver
{
    class Program
    {
        public static void Main(string[] args)
        {
            // declare variables
            List<Duck> ducks = new List<Duck>();
            List<Frog> frogs = new List<Frog>();
            Program program = new Program();
            Pond pond = new Pond();
            Duck duck = new Duck(Gender.prefer_not_to_say);
            Frog frog = new Frog(Gender.prefer_not_to_say);
            Ooievaar ooievaar = new Ooievaar(Gender.man);
            bool vraag = true;
            int eaten = 0;
            int j = 0;
            string geslacht = " ";
            //vul de pond

            for (int i = 0; i < 26; i++)
            {
                int random = program.randomgenerator(2);
                switch (random)
                {
                    case 0:
                        duck = new Duck(Gender.man);
                        break;

                    case 1:
                        duck = new Duck(Gender.vrouw);
                        break;
                }
                ducks.Add(duck);
            }

            for (int i = 0; i < 40; i++)
            {
                int random = program.randomgenerator(3);
                switch (random)
                {
                    case 0:
                        frog = new Frog(Gender.vrouw);
                        break;

                    case 1:
                        frog = new Frog(Gender.man);
                        break;
                    case 2:
                        frog = new Frog(Gender.prefer_not_to_say);
                        break;
                }
                frogs.Add(frog);
            }
            pond.ducks = ducks;
            pond.frogs = frogs;

            //vraag welk geslacht een eend is
            while (vraag == true)
            {
                Console.WriteLine("26 eenden, van welke wil je het geslacht vragen");


                string choice = Console.ReadLine();
                if (choice == "n")
                {
                    vraag = false;
                }
                try
                {
                    int choiceduck = Convert.ToInt32(choice);
                    geslacht = pond.ducks[choiceduck - 1].ToString();
                }
                catch { geslacht = " ";}

                Console.WriteLine(geslacht);
                Console.WriteLine();
            }
            while (eaten < 10)
            {
                Console.WriteLine("de ooievaar zoekt een kikker om te eten");
                Console.WriteLine("de ooievaar wil alleen kikkers met hetzelfde geslacht eten");
                Console.WriteLine("er zitten nog " + pond.frogs.Count + " kikkers in de vijver");
                Console.WriteLine("welke van de kikkers zal de ooievaar eten?");
                try
                {
                    int frognumber = Convert.ToInt32(Console.ReadLine());
                    if (pond.frogs[frognumber].gender == ooievaar.gender)
                    {
                        Console.WriteLine(pond.frogs[frognumber] + " deeld hetzelfde geslacht als de ooievaar");
                        Console.WriteLine("de ooievaar eet de kikker");
                        ooievaar.eatfrog(pond.frogs[frognumber]);
                        pond.frogs.Remove(pond.frogs[frognumber]);
                        eaten++;
                    }
                    else
                    {
                        Console.WriteLine(pond.frogs[frognumber] + " deeld niet hetzelfde geslacht als de ooievaar");
                        Console.WriteLine("de ooievaar zoekt verder");
                    }
                }
                catch { Console.WriteLine("kies een nummer"); }
                Console.WriteLine();
                Console.WriteLine();
            }
            foreach (Frog Frog in pond.frogs)
            {
                Console.WriteLine(pond.frogs[j]);
                j++;
            }
            while (true)
            {

            }
        }

        public int randomgenerator(int max)
        {
            Random random = new Random();
            int randomnum = random.Next(0, max);
            return randomnum;
        }

    }
}