using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace D16.VideoCommander.Test
{
    
    
    /// <summary>
    ///Dies ist eine Testklasse für "DisplaySettingTest" und soll
    ///alle DisplaySettingTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class DisplaySettingTest
    {
        /// <summary>
        ///Ruft den Testkontext auf, der Informationen
        ///über und Funktionalität für den aktuellen Testlauf bietet, oder legt diesen fest.
        ///</summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        ///Ein Test für "CloseAfterPlay"
        ///</summary>
        [TestMethod()]
        public void CloseAfterPlayTest()
        {
            DisplaySetting target = new DisplaySetting();
            
            bool expected = true;
            bool actual;
            target.CloseAfterPlay = expected;
            actual = target.CloseAfterPlay;
            
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Ein Test für "Embedded"
        ///</summary>
        [TestMethod()]
        public void EmbeddedTest()
        {
            DisplaySetting target = new DisplaySetting();

            bool expected = true;
            bool actual;
            target.Embedded = expected;
            actual = target.Embedded;
            
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Ein Test für "Fullscreen"
        ///</summary>
        [TestMethod()]
        public void FullscreenTest()
        {
            DisplaySetting target = new DisplaySetting();

            bool expected = true;
            bool actual;
            target.Fullscreen = expected;
            actual = target.Fullscreen;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Ein Test für "Height"
        ///</summary>
        [TestMethod()]
        public void HeightTest()
        {
            DisplaySetting target = new DisplaySetting();

            int expected = 513;
            int actual;
            target.Height = expected;
            actual = target.Height;
            
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Ein Test für "Width"
        ///</summary>
        [TestMethod()]
        public void WidthTest()
        {
            DisplaySetting target = new DisplaySetting();

            int expected = -1;
            int actual;
            target.Width = expected;
            actual = target.Width;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Ein Test für "XPos"
        ///</summary>
        [TestMethod()]
        public void XPosTest()
        {
            DisplaySetting target = new DisplaySetting();

            int expected = 540;
            int actual;
            target.XPos = expected;
            actual = target.XPos;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Ein Test für "YPos"
        ///</summary>
        [TestMethod()]
        public void YPosTest()
        {
            DisplaySetting target = new DisplaySetting();

            int expected = 13;
            int actual;
            target.YPos = expected;
            actual = target.YPos;

            Assert.AreEqual(expected, actual);
        }
    }
}
