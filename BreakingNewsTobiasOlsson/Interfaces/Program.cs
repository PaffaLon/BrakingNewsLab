using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        public interface IWebCollector
        {
            /// <summary>
            /// Html code from last search
            /// </summary>
            string HtmlCode { get; set; }
            /// <summary>
            /// Save html code from given URL to htmlCode property
            /// If url is NULL, empty or not containing "http", save string.Empty
            /// </summary>
            /// <param name="url"></param>
            /// <returns></returns>
            void GetHTMLFromUrl(string url);
        }

        public interface IWebCalculator
        {
            /// <summary>
            /// Calculates the number of occurences for given keyword in given html code.
            /// Takes a IWebCollector as a parameter
            /// Returns -1 if webcoll is NULL or Webcollector.Htmlcode property is
            /// NULL/empty or if the keyword is NULL/empty
            /// </summary>
            int CalculateNumberOfHits(IWebCollector webColl, string keyword);
        }
    }
}
