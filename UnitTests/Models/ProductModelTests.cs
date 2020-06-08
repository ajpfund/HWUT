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
        public void ProductModel_Set_Date_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Date = DateTime.UtcNow.AddDays(1);

            // Assert
            Assert.AreEqual(DateTime.UtcNow.AddDays(1).ToShortDateString(), result.Date.ToShortDateString());
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
        public void ProductModel_Set_Logistics_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Logistics = "Test Logistics";

            // Assert
            Assert.AreEqual("Test Logistics", result.Logistics);
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
        public void ProductModel_Set_Email_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Email = "Test Email";

            // Assert
            Assert.AreEqual("Test Email", result.Email);
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
        public void ProductModel_Set_Ratings_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            int[] testVar = new int[] { 3, 4, 5 };

            // Act
            result.Ratings = testVar;

            // Assert
            Assert.AreEqual(testVar, result.Ratings);
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
        public void ProductModel_Set_Description_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Description = "Test Description";

            // Assert
            Assert.IsNotNull(result.Description);
        }

        [TestMethod]
        public void ProductModel_Get_Description_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            result.Description = "Test Description";

            // Act
            var retVal = result.Description;

            // Assert
            Assert.AreEqual(retVal, result.Description);
        }

        [TestMethod]
        public void ProductModel_Set_Sequence_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Sequence = "Test Sequence";

            // Assert
            Assert.IsNotNull(result.Sequence);
        }

        [TestMethod]
        public void ProductModel_Get_Sequence_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            result.Sequence = "Test Sequence";

            // Act
            var retVal = result.Sequence;

            // Assert
            Assert.AreEqual(retVal, result.Sequence);
        }

        [TestMethod]
        public void ProductModel_Set_ID_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Id = "Test ID";

            // Assert
            Assert.IsNotNull(result.Id);
        }

        [TestMethod]
        public void ProductModel_Get_ID_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            result.Id = "Test ID";

            // Act
            var retVal = result.Id;

            // Assert
            Assert.AreEqual(retVal, result.Id);
        }

        [TestMethod]
        public void ProductModel_Set_Maker_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Maker = "Test Maker";

            // Assert
            Assert.IsNotNull(result.Maker);
        }

        [TestMethod]
        public void ProductModel_Get_Maker_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            result.Maker = "Test Maker";

            // Act
            var retVal = result.Maker;

            // Assert
            Assert.AreEqual(retVal, result.Maker);
        }

        [TestMethod]
        public void ProductModel_Set_Image_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Image = "Test Image";

            // Assert
            Assert.IsNotNull(result.Image);
        }

        [TestMethod]
        public void ProductModel_Get_Image_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            result.Image = "Test Image";

            // Act
            var retVal = result.Image;

            // Assert
            Assert.AreEqual(retVal, result.Image);
        }

        [TestMethod]
        public void ProductModel_Set_URL_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Url = "Test URL";

            // Assert
            Assert.IsNotNull(result.Url);
        }

        [TestMethod]
        public void ProductModel_Get_URL_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            result.Url = "Test URL";

            // Act
            var retVal = result.Url;

            // Assert
            Assert.AreEqual(retVal, result.Url);
        }

        [TestMethod]
        public void ProductModel_Set_Title_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Title = "Test Title";

            // Assert
            Assert.IsNotNull(result.Title);
        }

        [TestMethod]
        public void ProductModel_Get_Title_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            result.Title = "Test Title";

            // Act
            var retVal = result.Title;

            // Assert
            Assert.AreEqual(retVal, result.Title);
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
            Assert.AreEqual(0, retVal);
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

        [TestMethod]
        public void ProductModel_AverageRating_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            result.Ratings = new int[] { 3, 4, 5 };

            // Act
            int retVal = result.AverageRating();

            // Assert
            Assert.AreEqual(4, retVal);
        }

        [TestMethod]
        public void ProductModel_ToString_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            result.Id = "testID";
            result.Maker = "testMaker";
            result.Image = "testImage";
            result.Url = "testURL";
            result.Title = "testTitle";
            result.Description = "testDescription";
            result.Date = result.Date = DateTime.Now.Date;
            result.Sequence = "testSequence";
            result.Email = "testEmail";
            result.Logistics = "testLogistics";
            result.Ratings = new int[] { 3, 4, 5 };

            // Act
            var retVal = result.ToString();

            // Assert
            Assert.IsNotNull(retVal);
        }

    }
}   
