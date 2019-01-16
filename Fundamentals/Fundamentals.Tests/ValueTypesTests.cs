using NUnit.Framework;
using System;
namespace Fundamentals.Tests
{
    [TestFixture()]
    public class ValueTypesTests
    {
        [Test()]
        public void Test_ValueType_When_PassByValue()
        {
            int number = 46;

            IncrementNumber(number);
            Assert.AreEqual(46, number);
        }

        private void IncrementNumber(int number)
        {
            number += 1;
        }

        [Test()]
        public void Test_ValueType_When_PassByReference()
        {
            int number = 46;

            IncrementNumber(ref number);
            Assert.AreEqual(47, number);
        }

        private void IncrementNumber(ref int number)
        {
            number += 1;
        }

        [Test()]
        public void Test_DateTime()
        {
            DateTime date = new DateTime(2019, 1, 1);

            date.AddDays(1);
            var newDate = date.AddDays(1);

            Assert.AreEqual(1, date.Day);
            Assert.AreEqual(2, newDate.Day);
        }
    }
}
