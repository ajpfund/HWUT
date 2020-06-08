using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Get_Logistics_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("", result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("Unknown", result.Email);
        }

        [TestMethod]
        public void ProductModel_Get_Ratings_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result.Ratings);
        }

        [TestMethod]
        public void ProductModel_AverageRating_Invalid_Ratings_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            result.Ratings = null;

            // Act
            int retVal = result.AverageRating();

            // Assert
            Assert.AreEqual(0,retVal);
        }

        [TestMethod]
        public void ProductModel_AverageRating_Invalid_ZeroCount_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            result.Ratings = new int[] { };

            // Act
            int retVal = result.AverageRating();

            // Assert
            Assert.AreEqual(0, retVal);
        }

        [TestMethod]
        public void ProductModel_AverageRating_Invalid_ZeroTotal_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            result.Ratings = new int[] { 0 };

            // Act
            int retVal = result.AverageRating();

            // Assert
            Assert.AreEqual(0, retVal);
        }
    }
}
