using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDna.Integration;
using ExcelDna.IntelliSense;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTests")]

public class AddIn : IExcelAddIn
{
    public void AutoOpen()
    {
        IntelliSenseServer.Register();
    }

    public void AutoClose()
    {
    }
}


namespace getDataAtUrl
{
    public static class MyFunctions
    {
        [ExcelFunction(Description = "Retrieves the text at the provided URL and uses the regex search and replace patterns to isolate the value you want.")]
        public static string getDataAtUrl([ExcelArgument(Name = "url", Description = "The URL of the resource to parse")] string url)
        {
            return getDataAtUrl_private(url);
        }

        private static string getDataAtUrl_private(string url)
        {
            HttpWebRequest request = WebRequest.CreateHttp (url);
            request.UserAgent = "Chrome";
            WebResponse response = request.GetResponse();
            Stream resStream = response.GetResponseStream();
            StreamReader myStrRdr = new StreamReader(resStream);
            string str = myStrRdr.ReadToEnd();

            return str;
        }





        // Returns:
        //     A new string that is identical to the input string, except that the replacement
        //     string takes the place of each matched string. If pattern is not matched in the
        //     current instance, the method returns the current instance unchanged.
        [ExcelFunction(Description = "In a specified input string, replaces all strings that match a specified regular expression with a specified replacement string.")]
        public static string regexReplace([ExcelArgument(Name = "inputString", Description = "The string to search for a match")] string inputString,
        [ExcelArgument(Name = "regexSearchPattern", Description = "The regular expression pattern to match")] string regexSearchPattern,
        [ExcelArgument(Name = "regexReplacePattern", Description = "The replacement string")] string regexReplacePattern)
        {
            return Regex.Replace(inputString, regexSearchPattern, regexReplacePattern);
        }

    }



    public class Class1
    {
    }



}
