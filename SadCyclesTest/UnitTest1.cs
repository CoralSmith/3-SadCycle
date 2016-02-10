using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SadCycles;
using System.Collections.Generic;
using System.Linq;

namespace SadCyclesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenBase2Start1Returns1()
        {
            AssertContainsAll(new List<int> { 1 }, SadCycle.Generate(2, 1));
        }

        [TestMethod]
        public void GivenBase2Start10Returns1()
        {
            AssertContainsAll(new List<int> { 1 }, SadCycle.Generate(2, 10));
        }

        public void AssertContainsAll(IEnumerable<int> expected, IEnumerable<int> actual)
        {
            int n1 = expected.Distinct().Count();
            int n2 = actual.Distinct().Count();

            Assert.AreEqual(n1, n2);
            Assert.AreEqual(n1, expected.Intersect(actual).Count());
            Assert.AreEqual(n2, actual.Intersect(expected).Count());
        }
    }


}
