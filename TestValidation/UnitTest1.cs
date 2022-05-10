using ClassLibrary1;
using NUnit.Framework;

namespace TestValidation
{
    public class Tests
    {
        [Test]
        public void GivenInputIsString_WhenTestPincode_ShouldReturnPincode()
        {
            Validation validation = new Validation();
            string actual = validation.Validate("425404");
            Assert.AreEqual(actual,"425404");
        }
        [Test]
        public void GivenInputIsString_WhenTestFirstName_ShouldReturnFirstName()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateFirstName("Harshal");
            Assert.AreEqual(actual, "Harshal");
        }
        [Test]
        public void GivenInputIsString_WhenTestLastName_ShouldReturnLastName()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateLastName("Patil");
            Assert.AreEqual(actual, "Patil");
        }
        [Test]
        public void GivenInputIsString_WhenTestMobileNumber_ShouldReturnMobileNumber()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateMobileNumber("9158719379");
            Assert.AreEqual(actual, "9158719379");
        }
        [Test]
        public void GivenInputIsString_WhenTestEmail_ShouldReturnEmail()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateEmail("harshalapatil2796@gmail.com");
            Assert.AreEqual(actual, "harshalapatil2796@gmail.com");
        }
        [Test]
        public void GivenInputIsString_WhenTestPassword_ShouldReturnPassword()
        {
            Validation validation = new Validation();
            string actual = validation.ValidatePassword("Harshu12");
            Assert.AreEqual(actual, "Harshu12");
        }
    }
}