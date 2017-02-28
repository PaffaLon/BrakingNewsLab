using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakingNewsTobiasOlsson.Classes;

namespace BreakingNewsTobiasOlsson.Classes
{
    class StatusBar
    {
        private void Statusbar()
        {
            int i;
            for (i = 0; i < 101; i++)
            {
                GlobalVariabels.StatusBarNr = i.ToString();
                if (i == 100)
                    break;
            }
        }
    }
}