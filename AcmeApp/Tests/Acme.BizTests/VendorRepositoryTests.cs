using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        [TestMethod()]
        public void RetrieveValueTest()
        {
            var repository = new VendorRepository();
            var expected = 42m;

            var actual = repository.RetrieveValue("Select * ...", 42m);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveValueStringTest()
        {
            var repository = new VendorRepository();
            var expected = "test";

            var actual = repository.RetrieveValue("Select * ...", "test");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = 2;

            //Act
            var actual = repository.Retrieve();

            //Assert
            Assert.AreEqual(expected, actual.Count);
        }
    }
}