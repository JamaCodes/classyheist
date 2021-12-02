using System;

namespace ClassyHeist
{
    public class Hacker : IRobber
    {
        public string Name {get; set;}
        public int SkillLevel {get ; set;}
        public int PercentageCut {get ; set;}

     public void PerformSkill(bank Bank)
        {
            Bank.VaultScore = Bank.VaultScore - SkillLevel;

            Console.WriteLine($"{Name} is hacking the alarms. Decreased Security by {SkillLevel}");

            if (Bank.VaultScore <= 0)
            {
                Console.WriteLine($"{Name} has turned off the alarm");
            }
            else Console.WriteLine("Still trying to open the alarm");
        }
    }
}