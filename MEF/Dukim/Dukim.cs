using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukim
{
    #region MEF
    [Export(typeof(ISport))]
    #endregion MEF
    public class Dukim : ISport
    {
        public string Equipment
        {
            get
            {
                return "Dukim";
            }
        }

        public string Name
        {
            get
            {
                return "Dukim";
            }
        }

        public bool CanIDoThat(string name)
        {
            if (name == "Trumpeldor")
            {
                return false; 
            }

            return true;
        }
    }
}
