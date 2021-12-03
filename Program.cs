using System;
using System.Collections.Generic;

namespace ClassyHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            
             List<IRobber> Rolodex = new List<IRobber>();
            
            while (true)
            {
                prompt($"Number of operators in the Rolodex: {Rolodex.Count}");

             
                prompt("Enter the name of a new scumbag");
                string newOperator = Console.ReadLine();

                if (newOperator == "")
                {
                    break;
                }

                prompt(" 1. Hacker(Disables alarms)\n 2. Muscle(Disarms guards)\n 3. Lock Specialist (Cracks vault)");
                int newOpSpecial = int.Parse(Console.ReadLine());

                var choice = newOpSpecial;

                prompt("enter the crew gang's skill level as an integer between 1 and 100");
                int newOpSkillLevel = int.Parse(Console.ReadLine());

                prompt("enter the percentage cut the crew gang demands for each mission ");
                int newOpCut = int.Parse(Console.ReadLine());

                Rolodex = AddOperative(newOperator, newOpSpecial, newOpSkillLevel, newOpCut, Rolodex);


            void prompt(string Question) { Console.WriteLine($"{Question}");}
            }
            Random random = new Random();

            Bank newBank = new Bank
                {
                    AlarmScore = random.Next(0, 101),
                    VaultScore = random.Next(0, 101),
                    SecurityGaurdScore = random.Next(0, 101),
                    CashOnHand = random.Next(50_000, 1_000_000)
                };

                string leastSecure = newBank.LeastSecureScore;
                string mostSecure = newBank.MostSecureScore;
            Console.WriteLine($"The most secure system is {mostSecure}");

            Console.WriteLine($"The least secure system is {leastSecure}");
            Console.WriteLine("");

                
            List<IRobber> crew = new List<IRobber>();

            while (true)
            {
                try
                {
                    var count = 1;

                    Console.WriteLine("Pick Your Gang");

                    foreach (IRobber operative in Rolodex)
                    {
                        Console.WriteLine($"{count++}-Name: {operative.Name}, Speciality: {operative}, Skill: {operative.SkillLevel}, Percentage Cut: {operative.PercentageCut}");
                    }

                    Console.Write("Please Select an operator for your heist by typing the number assigned to them: ");
                    Console.WriteLine("");

                    int selection = int.Parse(Console.ReadLine());

                    if (Convert.ToString(selection) == "")
                    {
                        break;
                    }

                    Console.WriteLine("Here is your current gang: ");

                    crew.Add(Rolodex[selection - 1]);
                    Rolodex.RemoveAt(selection - 1);
                    var crewCount = crew.Count - 1;

                    Console.WriteLine($"You have added {crew[crewCount].Name} to your gang");
                    Console.WriteLine("");

                    Console.WriteLine("Here is your current gang: ");

                    foreach (IRobber gang in crew)
                    {
                        Console.WriteLine($"{gang.Name}, {gang}, {gang.SkillLevel}, {gang.PercentageCut}");
                    }
                    Console.WriteLine("");

                }

                catch (FormatException)
                {
                    Console.WriteLine("Your gang is complete");
                    break;

                }
            }
                
              Console.WriteLine("Time hit a lick...");

            foreach (IRobber operative in crew)
            {
                operative.PerformSkill(newBank);
            }

            if (newBank.IsSecure)
            {
                Console.WriteLine("Heist failed");
            }
            else
            {
                Console.WriteLine($"Heist Successful");

            }  
                
                
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
            foreach (IRobber robber in Rolodex)
                Console.WriteLine($"{robber.Name} {robber.SkillLevel} {robber} {robber.PercentageCut} ");
            }
        }
    
}
