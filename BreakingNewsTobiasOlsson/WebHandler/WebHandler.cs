using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClasses;

namespace WebHandler
{
    public class MyWebHandler
    {
        public async Task<int> UpdateGUI(string url, string searchCrit)
        { 
            WebCollector webData = new WebCollector();

            webData.GetHTMLFromUrl(url);
            WebCalculator stuff = new WebCalculator();
            int result = stuff.Count(webData, searchCrit);

            System.Threading.Thread.Sleep(1000);
            return result;
        }
    }
}
