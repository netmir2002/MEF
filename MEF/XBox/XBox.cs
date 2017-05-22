using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XBox
{
    #region MEF
    //[Export(typeof(ISport))]
    #endregion MEF
    public class XBox : ISport
    {
        public string Equipment
        {
            get
            {
                return "Controler";
            }
        }

        public string Name
        {
            get
            {
                return "XBox One S";
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
