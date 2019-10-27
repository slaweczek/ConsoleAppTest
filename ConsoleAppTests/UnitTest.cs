using System.Collections.Generic;
using ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleAppTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dict1 = new string[] { "A", "J", "K" };
            var dict2 = new string[] { "L", "M" };
            var dict3 = new string[] { "N" };

            var value = Vocabulary.SpreadLists(dict1, dict2, dict3);

            var correctAnswer = new List<string>() {"ALN", "AMN", "JLN", "JMN", "KLN", "KMN"};

            CollectionAssert.AreEqual(correctAnswer, value[0]);
        }
    }
}
