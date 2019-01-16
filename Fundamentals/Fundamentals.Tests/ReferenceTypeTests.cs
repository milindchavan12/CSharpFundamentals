using NUnit.Framework;
using System;
namespace Fundamentals.Tests
{
    [TestFixture()]
    public class ReferenceTypeTests
    {
        [Test()]
        public void Test_StringComparision()
        {
            string name1 = "Scott";
            string name2 = "scott";

            var result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [Test()]
        public void Test_ReferenceType_When_PassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveNametoBook(book2);
            Assert.AreEqual("A Gradebook", book1.Name);
        }

        private void GiveNametoBook(GradeBook book)
        {
            book.Name = "A Gradebook";
        }

        [Test()]
        public void Test_ReferenceType_When_PassByReference()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveNametoBook(ref book2);
            Assert.AreEqual("A Gradebook", book2.Name);
            Assert.AreNotEqual("A Gradebook", book1.Name);
        }

        private void GiveNametoBook(ref GradeBook book)
        {
            book = new GradeBook();
            book.Name = "A Gradebook";
        }
    }
}
