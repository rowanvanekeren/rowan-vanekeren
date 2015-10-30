using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatzeeTeerling
{
   public class teerlingController 
    {
       public  TeerlingVieuw _view;
       public teerlingModel _model;

       

       static int seeder = 0;
        Random random = new Random(++seeder);

        public teerlingController()
        {
          _view = new TeerlingVieuw(this);
        _model = new teerlingModel();
        }
        public TeerlingVieuw getView()
        {
            //TeerlingVieuw teerling = new TeerlingVieuw();
            return _view;

        }
        public void werpTeerling()
        {
            
            if (_model.vastzetten == false) { 
            int teerlingGetal = random.Next(1, 7);
            _model.aantalOgen = teerlingGetal;

           
            }
              

        }

        public void Score(int score)
        {
            _model.totalScore = _model.totalScore + score;
        }

        public void vastzetten()
        {
            Console.WriteLine(_model.vastzetten);
            
                _model.vastzetten = ! _model.vastzetten;
         

            
            
        }


        public void Teller()
        {
            _model.aantalWorpen++;
        }

        public void highscores(){

            int score = _model.totalScore;

            int min_index = Array.IndexOf(_model.MyNumbers, _model.MyNumbers.Min());
            _model.MyNumbers[min_index] = score;

            Array.Sort(_model.MyNumbers);
            Array.Reverse(_model.MyNumbers);
            
            
            
       
 
        }




    }
}
