using System;

namespace Genshin_Artifacts_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // A little scuffed newbie project I made outta boredom based off Genshin Impact Artifacts Rolling
            // Terminologies used: Methods, Random, While, For loop, Arrays, Switch, If else

            Console.WriteLine("**  GENSHIN IMPACT ARTIFACTS GENERATOR  **");
            Console.WriteLine("*  Press Enter key to generate artifacts *");
            Console.WriteLine("");
            Console.WriteLine("Resin: 160");
            Console.ReadLine();
            StartScreen();
        }

        static void StartScreen()
        {
            int resinCount = 140;
            string Enter;
            bool ranOut = false;

            while (ranOut == false)
            {
                Console.Clear();
                Console.WriteLine("**  GENSHIN IMPACT ARTIFACTS GENERATOR  **");
                Console.WriteLine("*  Press Enter key to generate artifacts *");
                Console.WriteLine("");
                Console.WriteLine("Resin: {0}", resinCount); // Indicates the amount of resin
                Artifacts();

                Enter = Convert.ToString(Console.ReadLine());
                if (Enter == "") // This condition will reduce the amount of resin by 20 when generating artifacts
                {
                    resinCount -= 20;
                }

                if (resinCount < -1) // Once the resin runs out, the program will end and displays a message that the player runs out of resin
                {
                    Console.WriteLine("You ran out of resin!");
                    ranOut = true;
                }
            }
        }

        static void Artifacts()
        {
            Random rnd = new Random();
            string[] Artifacts = { "Flower of Life", "Plume of Death", "Sands of Eon", "Goblet of Eonothem", "Circlet of Logos" }; // Name of the artifacts
            int rndArtif = rnd.Next(Artifacts.Length); // Selects a random artifact

            Console.WriteLine("-------------------");
            Console.WriteLine(Artifacts[rndArtif]);
           
            switch (rndArtif)
            {
                case 0:
                    Flower();
                    break;
                case 1:
                    Feather();
                    break;
                case 2:
                    Sands();
                    break;
                case 3:
                    Goblet();
                    break;
                case 4:
                    Circlet();
                    break;
            }
        }

        static void Flower() // Generate substats for Flower of Life artifact
        {
            Console.WriteLine("___________________");
            Console.WriteLine("MAIN STAT: HP");
            Console.WriteLine("___________________");
            Console.WriteLine("SUBSTATS:");
            Random rnd = new Random();

            for (int a = 1; a <= 4; a++)
            {
                int rndSub = rnd.Next(1, 101);

                if (rndSub <= 16) // 16% chance to get either of these substats
                {
                    string[] subCrit = { "CRIT Rate%", "CRIT DMG%" };
                    int numCrit = rnd.Next(subCrit.Length);
                    Console.WriteLine(subCrit[numCrit]);
                }
                else if (rndSub <= 53) // 37% chance to get either of these substats
                {
                    string[] subOthers = { "HP%", "ATK%", "DEF%", "Energy Recharge%", "Elementary Mastery" };
                    int numOthers = rnd.Next(subOthers.Length);
                    Console.WriteLine(subOthers[numOthers]);
                }
                else if (rndSub <= 100) // 47% chance to get either of these subtats
                {
                    string[] subOthers2 = { "ATK", "DEF" };
                    int numOthers2 = rnd.Next(subOthers2.Length);
                    Console.WriteLine(subOthers2[numOthers2]);
                }
            }          
        }

        static void Feather() // Generate substats for Plume of Death artifact
        {
            Console.WriteLine("___________________");
            Console.WriteLine("MAIN STAT: ATK");
            Console.WriteLine("___________________");
            Console.WriteLine("SUBSTATS:");
            Random rnd = new Random();

            for (int a = 1; a <= 4; a++)
            {
                int rndSub = rnd.Next(1, 101);

                if (rndSub <= 16) // 16% chance to get either of these substats
                {
                    string[] subCrit = { "CRIT Rate%", "CRIT DMG%" };
                    int numCrit = rnd.Next(subCrit.Length);
                    Console.WriteLine(subCrit[numCrit]);
                }
                else if (rndSub <= 53) // 37% chance to get either of these substats
                {
                    string[] subOthers = { "HP%", "ATK%", "DEF%", "Energy Recharge%", "Elementary Mastery" };
                    int numOthers = rnd.Next(subOthers.Length);
                    Console.WriteLine(subOthers[numOthers]);
                }
                else if (rndSub <= 100) // 47% chance to get either of these subtats
                {
                    string[] subOthers2 = { "HP", "DEF" };
                    int numOthers2 = rnd.Next(subOthers2.Length);
                    Console.WriteLine(subOthers2[numOthers2]);
                }
            }
        }

        static void Sands() // Generate substats for Sands of Eon artifact
        {
            Console.WriteLine("___________________");
            Random rnd = new Random();

            int rndStat = rnd.Next(1, 101);

            if (rndStat <= 81)
            {
                string[] mainStat = { "HP%", "ATK%", "DEF%" };
                int numStat = rnd.Next(mainStat.Length);
                Console.WriteLine("MAIN STAT: {0}", mainStat[numStat]);
                Console.WriteLine("___________________");
                Console.WriteLine("SUBSTATS:");

                for (int i = 1; i <= 4; i++)
                {
                    int rndSubStat = rnd.Next(1, 101);

                    switch (numStat)
                    {
                        case 0:
                            {                      
                                if (rndSubStat <= 55)
                                {
                                    string[] subOthers1 = { "ATK%", "DEF%", "Energy Recharge%", "Elementary Mastery" };
                                    int numOthers1 = rnd.Next(subOthers1.Length);
                                    Console.WriteLine(subOthers1[numOthers1]);
                                }
                                else if (rndSubStat <= 15)
                                {
                                    string[] subCrit = { "CRIT Rate%", "CRIT DMG%" };
                                    int numCrit = rnd.Next(subCrit.Length);
                                    Console.WriteLine(subCrit[numCrit]);
                                }
                                else if (rndSubStat <= 100)
                                {
                                    string[] subOthers = { "HP", "ATK", "DEF" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                            }
                            break;
                        case 1:
                            {
                                if (rndSubStat <= 55)
                                {
                                    string[] subOthers = { "HP%", "DEF%", "Energy Recharge%", "Elementary Mastery" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                                else if (rndSubStat <= 15)
                                {
                                    string[] subCrit = { "CRIT Rate%", "CRIT DMG%" };
                                    int numCrit = rnd.Next(subCrit.Length);
                                    Console.WriteLine(subCrit[numCrit]);
                                }
                                else if (rndSubStat <= 100)
                                {
                                    string[] subOthers = { "HP", "ATK", "DEF" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                            }
                            break;
                        case 2:
                            {
                                if (rndSubStat <= 55)
                                {
                                    string[] subOthers = { "HP%", "ATK%", "Energy Recharge%", "Elementary Mastery" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                                else if (rndSubStat <= 15)
                                {
                                    string[] subCrit = { "CRIT Rate%", "CRIT DMG%" };
                                    int numCrit = rnd.Next(subCrit.Length);
                                    Console.WriteLine(subCrit[numCrit]);
                                }
                                else if (rndSubStat <= 100)
                                {
                                    string[] subOthers = { "HP", "ATK", "DEF" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                            }
                            break;
                    }
                }
            }
            else if (rndStat <= 100)
            {
                string[] mainStat = { "Energy Recharge%", "Elementary Mastery" };
                int numStat = rnd.Next(mainStat.Length);
                Console.WriteLine("MAIN STAT: {0}", mainStat[numStat]);
                Console.WriteLine("___________________");
                Console.WriteLine("SUBSTATS:");

                for (int i = 1; i <= 4; i++)
                {
                    int rndSubStat = rnd.Next(1, 101);

                    switch (numStat)
                    {
                        case 0:
                            {
                                if (rndSubStat <= 55)
                                {
                                    string[] subOthers1 = { "ATK%", "DEF%", "HP%", "Elementary Mastery" };
                                    int numOthers1 = rnd.Next(subOthers1.Length);
                                    Console.WriteLine(subOthers1[numOthers1]);
                                }
                                else if (rndSubStat <= 15)
                                {
                                    string[] subCrit = { "CRIT Rate%", "CRIT DMG%" };
                                    int numCrit = rnd.Next(subCrit.Length);
                                    Console.WriteLine(subCrit[numCrit]);
                                }
                                else if (rndSubStat <= 100)
                                {
                                    string[] subOthers = { "HP", "ATK", "DEF" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                            }
                            break;
                        case 1:
                            {
                                if (rndSubStat <= 55)
                                {
                                    string[] subOthers = { "HP%", "DEF%", "Energy Recharge%", "ATK%" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                                else if (rndSubStat <= 15)
                                {
                                    string[] subCrit = { "CRIT Rate%", "CRIT DMG%" };
                                    int numCrit = rnd.Next(subCrit.Length);
                                    Console.WriteLine(subCrit[numCrit]);
                                }
                                else if (rndSubStat <= 100)
                                {
                                    string[] subOthers = { "HP", "ATK", "DEF" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                            }
                            break;
                    }
                }
            }        
        }

        static void Goblet() // Generate substats for Goblet of Eonothem artifact
        {
            Console.WriteLine("___________________");
            Random rnd = new Random();

            int rndStat = rnd.Next(1, 101);

            if (rndStat <= 37)
            {
                string[] mainStat = { "Elementary Mastery", "Pyro DMG Bonus%", "Cryo DMG Bonus%", "Electro DMG Bonus%", "Anemo DMG Bonus%", "Physical DMG Bonus%", "Hydro DMG Bonus%", "Geo DMG Bonus%" };
                int numStat = rnd.Next(mainStat.Length);
                Console.WriteLine("MAIN STAT: {0}", mainStat[numStat]);
                Console.WriteLine("___________________");
                Console.WriteLine("SUBSTATS:");

                for (int i = 1; i <= 4; i++)
                {
                    int rndSubStat = rnd.Next(1, 101);

                    switch (numStat)
                    {
                        case 0:
                            {
                                if (rndSubStat <= 55)
                                {
                                    string[] subOthers = { "HP%", "DEF%", "Energy Recharge%", "ATK%" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                                else if (rndSubStat <= 15)
                                {
                                    string[] subCrit = { "CRIT Rate%", "CRIT DMG%" };
                                    int numCrit = rnd.Next(subCrit.Length);
                                    Console.WriteLine(subCrit[numCrit]);
                                }
                                else if (rndSubStat <= 100)
                                {
                                    string[] subOthers = { "HP", "ATK", "DEF" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                            }
                            break;
                        default:
                            {
                                if (rndSubStat <= 55)
                                {
                                    string[] subOthers = { "HP%", "DEF%", "Energy Recharge%", "ATK%", "Elementary Mastery" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                                else if (rndSubStat <= 15)
                                {
                                    string[] subCrit = { "CRIT Rate%", "CRIT DMG%" };
                                    int numCrit = rnd.Next(subCrit.Length);
                                    Console.WriteLine(subCrit[numCrit]);
                                }
                                else if (rndSubStat <= 100)
                                {
                                    string[] subOthers = { "HP", "ATK", "DEF" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                            }
                            break;
                    }
                }
            }
            else if (rndStat <= 100)
            {
                string[] mainStat = { "HP%", "ATK%", "DEF%" };
                int numStat = rnd.Next(mainStat.Length);
                Console.WriteLine("MAIN STAT: {0}", mainStat[numStat]);
                Console.WriteLine("___________________");
                Console.WriteLine("SUBSTATS:");

                for (int i = 1; i <= 4; i++)
                {
                    int rndSubStat = rnd.Next(1, 101);

                    switch (numStat)
                    {
                        case 0:
                            {
                                if (rndSubStat <= 55)
                                {
                                    string[] subOthers1 = { "ATK%", "DEF%", "Energy Recharge%", "Elementary Mastery" };
                                    int numOthers1 = rnd.Next(subOthers1.Length);
                                    Console.WriteLine(subOthers1[numOthers1]);
                                }
                                else if (rndSubStat <= 15)
                                {
                                    string[] subCrit = { "CRIT Rate%", "CRIT DMG%" };
                                    int numCrit = rnd.Next(subCrit.Length);
                                    Console.WriteLine(subCrit[numCrit]);
                                }
                                else if (rndSubStat <= 100)
                                {
                                    string[] subOthers = { "HP", "ATK", "DEF" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                            }
                            break;
                        case 1:
                            {
                                if (rndSubStat <= 55)
                                {
                                    string[] subOthers = { "HP%", "DEF%", "Energy Recharge%", "Elementary Mastery" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                                else if (rndSubStat <= 15)
                                {
                                    string[] subCrit = { "CRIT Rate%", "CRIT DMG%" };
                                    int numCrit = rnd.Next(subCrit.Length);
                                    Console.WriteLine(subCrit[numCrit]);
                                }
                                else if (rndSubStat <= 100)
                                {
                                    string[] subOthers = { "HP", "ATK", "DEF" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                            }
                            break;
                        case 2:
                            {
                                if (rndSubStat <= 55)
                                {
                                    string[] subOthers = { "HP%", "ATK%", "Energy Recharge%", "Elementary Mastery" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                                else if (rndSubStat <= 15)
                                {
                                    string[] subCrit = { "CRIT Rate%", "CRIT DMG%" };
                                    int numCrit = rnd.Next(subCrit.Length);
                                    Console.WriteLine(subCrit[numCrit]);
                                }
                                else if (rndSubStat <= 100)
                                {
                                    string[] subOthers = { "HP", "ATK", "DEF" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                            }
                            break;
                    }
                }
            }
        }

        static void Circlet()
        {
            Console.WriteLine("___________________");
            Random rnd = new Random();

            int rndStat = rnd.Next(1, 101);

            if (rndStat <= 4)
            {
                Console.WriteLine("MAIN STAT: Elementary Mastery");
                Console.WriteLine("___________________");
                Console.WriteLine("SUBSTATS:");

                for (int i = 1; i <= 4; i++)
                {
                    int rndSubStat = rnd.Next(1, 101);

                    if (rndSubStat <= 55)
                    {
                        string[] subOthers = { "HP%", "DEF%", "Energy Recharge%", "ATK%" };
                        int numOthers = rnd.Next(subOthers.Length);
                        Console.WriteLine(subOthers[numOthers]);
                    }
                    else if (rndSubStat <= 15)
                    {
                        string[] subCrit = { "CRIT Rate%", "CRIT DMG%" };
                        int numCrit = rnd.Next(subCrit.Length);
                        Console.WriteLine(subCrit[numCrit]);
                    }
                    else if (rndSubStat <= 100)
                    {
                        string[] subOthers = { "HP", "ATK", "DEF" };
                        int numOthers = rnd.Next(subOthers.Length);
                        Console.WriteLine(subOthers[numOthers]);
                    }
                }
            }
            else if (rndStat <= 34)
            {
                string[] mainStat = { "CRIT Rate%", "CRIT DMG%", "Healing Bonus%" };
                int numStat = rnd.Next(mainStat.Length);
                Console.WriteLine("MAIN STAT: {0}", mainStat[numStat]);
                Console.WriteLine("___________________");
                Console.WriteLine("SUBSTATS:");

                for (int i = 1; i <= 4; i++)
                {
                    int rndSubStat = rnd.Next(1, 101);

                    switch (numStat)
                    {
                        case 0:
                            {
                                if (rndSubStat <= 50)
                                {
                                    string[] subOthers1 = { "ATK%", "DEF%", "Energy Recharge%", "Elementary Mastery", "HP%" };
                                    int numOthers1 = rnd.Next(subOthers1.Length);
                                    Console.WriteLine(subOthers1[numOthers1]);
                                }
                                else if (rndSubStat <= 7)
                                {
                                    string[] subCrit = { "CRIT DMG%" };
                                    int numCrit = rnd.Next(subCrit.Length);
                                    Console.WriteLine(subCrit[numCrit]);
                                }
                                else if (rndSubStat <= 100)
                                {
                                    string[] subOthers = { "HP", "ATK", "DEF" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                            }
                            break;
                        case 1:
                            {
                                if (rndSubStat <= 50)
                                {
                                    string[] subOthers1 = { "ATK%", "DEF%", "Energy Recharge%", "Elementary Mastery", "HP%" };
                                    int numOthers1 = rnd.Next(subOthers1.Length);
                                    Console.WriteLine(subOthers1[numOthers1]);
                                }
                                else if (rndSubStat <= 7)
                                {
                                    string[] subCrit = { "CRIT Rate%" };
                                    int numCrit = rnd.Next(subCrit.Length);
                                    Console.WriteLine(subCrit[numCrit]);
                                }
                                else if (rndSubStat <= 100)
                                {
                                    string[] subOthers = { "HP", "ATK", "DEF" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                            }
                            break;
                        case 2:
                            {
                                if (rndSubStat <= 45)
                                {
                                    string[] subOthers = { "HP%", "ATK%", "Energy Recharge%", "Elementary Mastery", "DEF%" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                                else if (rndSubStat <= 14)
                                {
                                    string[] subCrit = { "CRIT Rate%", "CRIT DMG%" };
                                    int numCrit = rnd.Next(subCrit.Length);
                                    Console.WriteLine(subCrit[numCrit]);
                                }
                                else if (rndSubStat <= 100)
                                {
                                    string[] subOthers = { "HP", "ATK", "DEF" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                            }
                            break;
                    }
                }
            }
            else if (rndStat <= 100)
            {
                string[] mainStat = { "HP%", "ATK%", "DEF%" };
                int numStat = rnd.Next(mainStat.Length);
                Console.WriteLine("MAIN STAT: {0}", mainStat[numStat]);
                Console.WriteLine("___________________");
                Console.WriteLine("SUBSTATS:");

                for (int i = 1; i <= 4; i++)
                {
                    int rndSubStat = rnd.Next(1, 101);

                    switch (numStat)
                    {
                        case 0:
                            {
                                if (rndSubStat <= 55)
                                {
                                    string[] subOthers1 = { "ATK%", "DEF%", "Energy Recharge%", "Elementary Mastery" };
                                    int numOthers1 = rnd.Next(subOthers1.Length);
                                    Console.WriteLine(subOthers1[numOthers1]);
                                }
                                else if (rndSubStat <= 15)
                                {
                                    string[] subCrit = { "CRIT Rate%", "CRIT DMG%" };
                                    int numCrit = rnd.Next(subCrit.Length);
                                    Console.WriteLine(subCrit[numCrit]);
                                }
                                else if (rndSubStat <= 100)
                                {
                                    string[] subOthers = { "HP", "ATK", "DEF" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                            }
                            break;
                        case 1:
                            {
                                if (rndSubStat <= 55)
                                {
                                    string[] subOthers = { "HP%", "DEF%", "Energy Recharge%", "Elementary Mastery" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                                else if (rndSubStat <= 15)
                                {
                                    string[] subCrit = { "CRIT Rate%", "CRIT DMG%" };
                                    int numCrit = rnd.Next(subCrit.Length);
                                    Console.WriteLine(subCrit[numCrit]);
                                }
                                else if (rndSubStat <= 100)
                                {
                                    string[] subOthers = { "HP", "ATK", "DEF" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                            }
                            break;
                        case 2:
                            {
                                if (rndSubStat <= 55)
                                {
                                    string[] subOthers = { "HP%", "ATK%", "Energy Recharge%", "Elementary Mastery" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                                else if (rndSubStat <= 15)
                                {
                                    string[] subCrit = { "CRIT Rate%", "CRIT DMG%" };
                                    int numCrit = rnd.Next(subCrit.Length);
                                    Console.WriteLine(subCrit[numCrit]);
                                }
                                else if (rndSubStat <= 100)
                                {
                                    string[] subOthers = { "HP", "ATK", "DEF" };
                                    int numOthers = rnd.Next(subOthers.Length);
                                    Console.WriteLine(subOthers[numOthers]);
                                }
                            }
                            break;
                    }
                }
            }
        }
    }
}
