using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade
{
    public class UpgradeController
    {
        UpgradeView _view;
        UpgradeModel _model;

        public UpgradeController() {
            _view = new UpgradeView( this );
            _model = new UpgradeModel();
        }

        public UpgradeView getView() {
            return _view;
        }
    }
}
