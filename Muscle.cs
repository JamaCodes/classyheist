using System;

namespace ClassyHeist
{
    public class Muscle : IRobber
    {
        public string Name {get; set;}
        public int SkillLevel {get ; set;}
        public int PercentageCut {get ; set;}
         public override string ToString()
        {
            return "muscle";
        }

        public void PerformSkill(bank Bank)
        {
            Bank.VaultScore = Bank.VaultScore - SkillLevel;

            Console.WriteLine($"{Name} is kicking people, and beat up Security by {SkillLevel}");

            if (Bank.VaultScore <= 0)
            {
                Console.WriteLine($"{Name} has opened Vault");
            }
            else Console.WriteLine("Still trying to open the Vault");
        }
    }
}