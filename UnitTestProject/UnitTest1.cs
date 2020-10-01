using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using JenkinsTestApp;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private const string expected = "Hello Jenkins";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.Main();
                var result = sw.ToString().Trim();
                Assert.AreEqual(expected, result);
            }
        }
    }
}
