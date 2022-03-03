using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWS
{
    public interface IPageViewModel
    {
        string Name { get; }
        string ButtonPage { get; }

        event PropertyChangedEventHandler PropertyChanged;
    }
}
