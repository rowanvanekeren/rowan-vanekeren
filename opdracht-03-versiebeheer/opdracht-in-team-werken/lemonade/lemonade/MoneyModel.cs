using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade
{
    public class MoneyModel
    {
        static float _money = 500f;
        float _income = 0f;
        float _incomeAfterUpgrade = 0f;
        float multiplier = 1f;

        public float Money { get { return _money; } set { _money = value; } }
        public float Income { get { return _income; } set { _income = value; } }
        public float IncomeAfterUpgrade { get { return _incomeAfterUpgrade; } set { _incomeAfterUpgrade = value; } }
        public float Multiplier { get { return multiplier; } set { multiplier = value; } }
    }
}
