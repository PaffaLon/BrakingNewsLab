using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebClasses.Interfaces;

namespace WebClasses
{
    public class WebCalculator
    {
        public int CalculateNumberOfHits(IWebCollector webColl, string keyword)
        {
            throw new NotImplementedException();
        }
        
        public int Count(WebCollector htmlCode, string searchCrit)
        {
            if (htmlCode == null)
            {
                return -1;
            }
            else
            {
                var regex = new Regex(string.Format(searchCrit), RegexOptions.IgnoreCase);
                int NrOfHits = regex.Matches(htmlCode.HtmlCode).Count;
                return NrOfHits;
            }
        }
    }
}
