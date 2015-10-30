using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade
{
    public class MoneyModel
    {
        static int _money = 450;
        int _income = 0;
        int _incomeAfterUpgrade = 0;

        public int Money { get { return _money; } set { _money = value; } }
        public int Income { get { return _income; } set { _income = value; } }
    }
}
