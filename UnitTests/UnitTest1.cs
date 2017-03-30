using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            getDataAtUrl.MyFunctions.getDataAtUrl("http://w1.weather.gov/data/obhistory/KMKE.html");
        }

        //=regexReplace(getDataAtUrl("https://www.glerl.noaa.gov//metdata/mil/"),"[\u0001-~]*<strong>Air Temperature[\u0001-~]+?>(.+?)&.*<\/td><[\u0001-~]*","$1")

    }
}
