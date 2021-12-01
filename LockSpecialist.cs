using system;

namespace ClassyHeist
{
    public class LockSpecialist : IRobber
    {
        public string Name {get; set;}
        public int SkillLevel {get ; set;}
        public int PercentageCut {get ; set;}

        public void PerformSkill(bank bank)
        {
            bank.AlarmScore = bank.AlarmScore - SkillLevel;
        }
    }
}