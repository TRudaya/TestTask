using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Core.UI.Pages
{
    public interface IPage
    {
        void Open(string part = "");
    }
}
