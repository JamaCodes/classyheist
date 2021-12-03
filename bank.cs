using System; 
using System.Collections.Generic;
using System.Linq;

namespace ClassyHeist
{
    public class Bank 
    {
        public int CashOnHand {get; set;}
        public int AlarmScore{get; set;}
        public int VaultScore {get; set;}
        public int SecurityGaurdScore {get; set;}

        public string MostSecureScore 
        {
            get
            {
                return securityScores.OrderByDescending(score => score.Value).First().Key;
            }
        }
         public string LeastSecureScore 
        {
            get
            {
                return securityScores.OrderBy(score => score.Value).First().Key;
            }
        }

        private Dictionary <string, int> securityScores
        {
            get
            {
                return new Dictionary<string, int>
                {
                 {"AlarmScore", AlarmScore},
                {"VaultScore" , VaultScore},
                {"SecurityGaurdScore", SecurityGaurdScore}
                };
            } 
        }

        public bool IsSecure
        {
            get
            {
                if (AlarmScore <= 0 && VaultScore <= 0 && SecurityGaurdScore <= 0)
                {
                    return false;
                }
                else return true;

            }
        }
    }
}