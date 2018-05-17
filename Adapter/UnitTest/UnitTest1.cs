using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testToHTML()
        {
            string y = "<body>\n"
                    + "<p>asdasd</p>\n"
                    + "<h1>!!!SDFSFSFD</h1>\n"
                    + "<p>SDFSFSFD</p>\n"
                    + "<ul>\n"
                    + "<li>aaa1</li>\n"
                    + "<li>bbb2</li>\n"
                    + "</ul>\n"
                    + "<p>SDFSFSFD</p>\n"
                    + "</body>\n";

            string x = ">asdasd\n"
                    + "###!!!SDFSFSFD\n"
                    + ">SDFSFSFD\n"
                    + "1.aaa1\n"
                    + "2.bbb2\n"
                    + ">SDFSFSFD";

            Adapter.Adapter adapter = new Adapter.Adapter(new Adapter.HTMLAdapter());
            string result = adapter.Request(x);
            Assert.AreEqual(y.ToUpper(), result.ToUpper());
        }

        [TestMethod]
        public void testToMD()
        {
            string x = "<body>\n"
                    + "<p>asdasd</p>\n"
                    + "<h1>!!!SDFSFSFD</h1>\n"
                    + "<p>SDFSFSFD</p>\n"
                    + "<ul>\n"
                    + "<li>aaa1</li>\n"
                    + "<li>bbb2</li>\n"
                    + "</ul>\n"
                    + "<p>SDFSFSFD</p>\n"
                    + "</body>";

            string y = ">asdasd\n"
                    + "###!!!SDFSFSFD\n"
                    + ">SDFSFSFD\n"
                    + "1.aaa1\n"
                    + "2.bbb2\n"
                    + ">SDFSFSFD\n";

            Adapter.Adapter adapter = new Adapter.Adapter(new Adapter.MDAdapter());
            string result = adapter.Request(x);
            Assert.AreEqual(y.ToUpper(), result.ToUpper());
        }
    }
}
