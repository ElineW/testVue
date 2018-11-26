using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BL_Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            Customer customer = new Customer();
            customer.Lastname = "Baggins";

            string expected = "Baggins";
            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
