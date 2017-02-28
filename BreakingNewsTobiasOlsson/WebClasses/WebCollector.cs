using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace WebClasses
{
    public class WebCollector
    {
        public string HtmlCode { get; set; }
        
        public void GetHTMLFromUrl(string url)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    HtmlCode = wc.DownloadString(url);
                }
            }

            /*
            Uri location = new Uri(url);
            using (WebClient getter = new WebClient())
            {
                Task<string> getWebData = Task.Run(async () => await getter.DownloadStringTaskAsync(location));
                HtmlCode = getWebData.Result;
            }
            */
            catch (Exception e)
            {
                throw new Exception("No url recived." + e.Message);
            }
        }
    }
}