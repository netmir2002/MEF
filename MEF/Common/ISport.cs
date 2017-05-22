using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    #region Another MEF Option
    //[InheritedExport]
    #endregion

    public interface ISport
    {
        string Name { get; }
        string Equipment { get; }
        bool CanIDoThat(string name);
    }
}
