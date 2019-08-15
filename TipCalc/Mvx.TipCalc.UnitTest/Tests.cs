using System;
using Mvx.TipCalc.Core.Services;
using NUnit.Framework;

namespace Mvx.TipCalc.UnitTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CalculationIsCorrect()
        {
            // arrange
            var calcSvs = new CalculationService();
            var bill = 200;
            var percentage = 5;
            var expected = 10;
            // act
            var actual = calcSvs.TipAmount(bill, percentage);
            // assert
            Assert.AreEqual(expected,actual);
        }
    }
}