using ClassLibrary1;
using NUnit.Framework;

namespace TestValidation
{
    public class Tests
    {
        [Test]
        public void Pincode()
        {
            Validation validation = new Validation();
            string actual = validation.Validate("425404");
            Assert.AreEqual(actual,"425404");
        }
        [Test]
        public void FirstName()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateFirstName("Harshal");
            Assert.AreEqual(actual, "Harshal");
        }
        [Test]
        public void LastName()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateLastName("Patil");
            Assert.AreEqual(actual, "Patil");
        }
        [Test]
        public void MobileNumber()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateMobileNumber("9158719379");
            Assert.AreEqual(actual, "9158719379");
        }
        [Test]
        public void Email()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateEmail("harshalapatil2796@gmail.com");
            Assert.AreEqual(actual, "harshalapatil2796@gmail.com");
        }
        [Test]
        public void Password()
        {
            Validation validation = new Validation();
            string actual = validation.ValidatePassword("Harshu12");
            Assert.AreEqual(actual, "Harshu12");
        }
    }
}