using System;
using System.Collections.Generic;

namespace ClassyHeist
{
    class Program
    {
        static void Main(string[] args)
        {

            var MrBrown = new Hacker
            {
                Name = "MrBrown",
                SkillLevel = 57,
                PercentageCut = 20,
            };
            var MrWhite = new Muscle
            {
                Name = "MrWhite",
                SkillLevel = 57,
                PercentageCut = 15,
            };
            var MrPink = new LockSpecialist
            {
                Name = "MrPink",
                SkillLevel = 100,
                PercentageCut = 60,
            };
            var MrLightBrown = new Hacker
            {
                Name = "MrLightBrown",
                SkillLevel = 90,
                PercentageCut = 30,
            };
            var MrOffWhite = new Muscle
            {
                Name = "MrOffWhite",
                SkillLevel = 7,
                PercentageCut = 4,
            };
            var MrFushia = new LockSpecialist
            {
                Name = "MrFushia",
                SkillLevel = 25,
                PercentageCut = 10,
            };


            var Rolodex = new List<IRobber>()
            {
                MrBrown,
                MrWhite,
                MrPink,
                MrLightBrown,
                MrOffWhite,
                MrFushia
            };
            while (true)
            {
                prompt($"Number of operatives in the Rolodex: {Rolodex.Count}");

                prompt("Would you like to Add a Crew Member:(y/n)");
                string WouldYouLikeToAdd = Console.ReadLine();
                if (WouldYouLikeToAdd == "n")
                {
                    break;
                }
                prompt("Enter the name of a new scumbag");
                string newOperator = Console.ReadLine();

                prompt(" 1. Hacker(Disables alarms)\n 2. Muscle(Disarms guards)\n 3. Lock Specialist (Cracks vault)");
                int newOpSpecial = int.Parse(Console.ReadLine());

                var choice = newOpSpecial;

                prompt("enter the crew member's skill level as an integer between 1 and 100");
                int newOpSkillLevel = int.Parse(Console.ReadLine());

                prompt("enter the percentage cut the crew member demands for each mission ");
                int newOpCut = int.Parse(Console.ReadLine());

                Rolodex = AddOperative(newOperator, newOpSpecial, newOpSkillLevel, newOpCut, Rolodex);

                var newRandom = new Random();
                var newBank = new bank
                {
                    AlarmScore = newRandom.Next(0, 101),
                    VaultScore = newRandom.Next(0, 101),
                    SecurityGaurdScore = newRandom.Next(0, 101),
                    CashOnHand = newRandom.Next(50_000, 1_000_000)
                };

                string mostSecure = newBank.MostSecureScore;
                Console.WriteLine($"{mostSecure}");
                string leastSecure = newBank.LeastSecureScore;
                Console.WriteLine($"{leastSecure}");




                static List<IRobber> AddOperative(string newOperator, int choice, int newOpSkillLevel, int newOpCut, List<IRobber> Rolodex)
                {
                    if (choice == 1)
                    {
                        Hacker newOperative = new Hacker()
                        {
                            Name = newOperator,
                            SkillLevel = newOpSkillLevel,
                            PercentageCut = newOpCut,
                        };
                        Rolodex.Add(newOperative);
                    }
                    else if (choice == 2)
                    {
                        Muscle newOperative = new Muscle()
                        {
                            Name = newOperator,
                            SkillLevel = newOpSkillLevel,
                            PercentageCut = newOpCut,
                        };
                        Rolodex.Add(newOperative);
                    }
                    else if (choice == 3)
                    {
                        LockSpecialist newOperative = new LockSpecialist()
                        {
                            Name = newOperator,
                            SkillLevel = newOpSkillLevel,
                            PercentageCut = newOpCut,
                        };
                        Rolodex.Add(newOperative);
                    };
                    return Rolodex;
                }
                Console.WriteLine($"{Rolodex.Count}");
            }
            foreach (IRobber robber in Rolodex)
                Console.WriteLine($"{robber.Name} {robber.SkillLevel} {robber} {robber.PercentageCut} ");
            void prompt(string Question) { Console.WriteLine($"{Question}"); }
        }
    }
}
