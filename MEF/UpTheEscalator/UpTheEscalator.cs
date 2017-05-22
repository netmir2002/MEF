using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpTheEscalator
{
    #region MEF
    //[Export(typeof(ISport))]
    #endregion MEF
    public class UpTheEscalator : ISport
    {
        public string Equipment
        {
            get
            {
                return "Shoes";
            }
        }

        public string Name
        {
            get
            {
                return "Up The Escalator";
            }
        }

        public bool CanIDoThat(string name)
        {
            if(name == "Stephen Hawking")
            {
                return false;
            }

            return true;
        }
    }
}
