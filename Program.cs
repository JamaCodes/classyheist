using System;
using System.Collections.Generic;

namespace ClassyHeist
{
    class Program
    {
        static void Main(string[] args)
        {

            var MrBrown = new Hacker();
            var MrWhite = new Muscle();
            var MrPink = new LockSpecialist();
            var MrLightBrown = new Hacker();
            var  MrOffWhite = new Muscle();
            var MrFushia = new LockSpecialist();

        
            var Rolodex = new List<IRobber>()
            {
                MrBrown,
                MrWhite,
                MrPink,
                MrLightBrown,
                MrOffWhite,
                MrFushia
            };
           
            prompt($"Number of operatives in the Rolodex: {Rolodex.Count}");

            // prompt("Would you like to Add a Crew Member:(Y/N)");
            // string WouldYouLikeToAdd = Console.ReadLine();

            prompt("Enter the name of a new possible crew member");
            string newOperator = Console.ReadLine();
            
            prompt(" 1. Hacker(Disables alarms)\n 2. Muscle(Disarms guards)\n 3. Lock Specialist (Cracks vault)");
            int newOpSpecial = int.Parse(Console.ReadLine());
            
            var choice = newOpSpecial;

            prompt("enter the crew member's skill level as an integer between 1 and 100");
            int newOpSkillLevel = int.Parse(Console.ReadLine());

            prompt("enter the percentage cut the crew member demands for each mission "); 
            int newOpCut  = int.Parse(Console.ReadLine());

            Rolodex = AddOperative(newOperator, newOpSpecial, newOpSkillLevel, newOpCut, Rolodex);

            

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
    
            void prompt(string Question){Console.WriteLine($"{Question}");}
            
        }
    }
}
