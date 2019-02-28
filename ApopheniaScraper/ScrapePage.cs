using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ApopheniaScraper
{
    public class ScrapePage
    {
        public string GetPageData(string url)
        {
            WebResponse response = null;
            StreamReader reader = null;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            response = request.GetResponse();
            reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            
            return reader.ReadToEnd();
        }
    }
}
