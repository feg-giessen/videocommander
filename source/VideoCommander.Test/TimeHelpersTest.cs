using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace D16.VideoCommander.Test
{
    ///<summary>
    ///Dies ist eine Testklasse für "TimeHelpersTest" und soll
    ///alle TimeHelpersTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class TimeHelpersTest
    {
        /// <summary>
        ///Ruft den Testkontext auf, der Informationen
        ///über und Funktionalität für den aktuellen Testlauf bietet, oder legt diesen fest.
        ///</summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        ///Ein Test für "FromFormatedString"
        ///</summary>
        [TestMethod()]
        public void FromFormatedStringTest()
        {
            string formatedString = "12:30";
            TimeSpan expected = new TimeSpan(0, 12, 30);

            TimeSpan actual;
            actual = TimeHelpers.FromFormatedString(formatedString);
            
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Ein Test für "ToFormatedString"
        ///</summary>
        [TestMethod()]
        public void ToFormatedStringTest()
        {
            TimeSpan time = new TimeSpan(10, 5, 39);
            string expected = "10:05:39";

            string actual;
            actual = TimeHelpers.ToFormatedString(time);
            
            Assert.AreEqual(expected, actual);
        }
    }
}
