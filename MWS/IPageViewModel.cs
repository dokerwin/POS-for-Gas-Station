using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MWS.MWSUtil.Enums;

namespace MWS
{
    public interface IPageViewModel
    {
        string Name { get; }
        string ButtonPage { get; }
        PageType TypeOfPage { get; }

        event PropertyChangedEventHandler PropertyChanged;
    }
}
