using System;

namespace ClassyHeist
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(bank Bank)
        {
            Bank.VaultScore = Bank.VaultScore - SkillLevel;

            Console.WriteLine($"{Name} is opening the Vault. Decreased Security by {SkillLevel}");

            if (Bank.VaultScore <= 0)
            {
                Console.WriteLine($"{Name} has opened Vault");
            }
            else Console.WriteLine("Still trying to open the Vault");
        }
    }
}