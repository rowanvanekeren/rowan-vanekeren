using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatzeeTeerling
{
   public class teerlingModel
    {
       static int worpen =0;
       int _aantalOgen;
       bool _vastzetten = false;
       int _aantalWorpen = 0;
       static int _totalScore = 0;
       static int[] _numbers = { 1, 2, 3, 4 };
       //static in aparte klasse;
       public int[] MyNumbers
       {
           get { return _numbers; }
           set { _numbers = value; }
       }






       public int aantalWorpen {
           get { return _aantalWorpen; } 
           set { _aantalWorpen = value; }
       }

       public bool vastzetten
       {
           get
           {
               return _vastzetten;
           }
           set
           {
               _vastzetten = value;
           }



       }


       public int totalScore { get {return _totalScore ;} set {_totalScore = value ;} }

        public int aantalOgen
        {
            get
            {
                return _aantalOgen;
            }
            set
            {
                _aantalOgen = value;
            }
        }


        public int globaalWorp { get { return worpen; } set { worpen = value; } }
    }
}
