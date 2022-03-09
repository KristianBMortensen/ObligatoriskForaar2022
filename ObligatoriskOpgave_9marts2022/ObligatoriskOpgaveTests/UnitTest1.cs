using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOpgave_9marts2022;
using System;

namespace ObligatoriskOpgaveTests
{
    [TestClass]
    public class CarTests
    {
       
        [TestMethod]
        public void Car_ModelLengthGreaterThan4_ReturnTrue()
        {//arrange
            ObligatoriskOpgave_9marts2022.Car klasse = new ObligatoriskOpgave_9marts2022.Car("Volvo", 100, "UB72");
           
            bool expected = klasse.Model.Length > 4; // act

            Assert.IsTrue(expected); // assert
        }
        [TestMethod]
        public void Car_PriceGreaterThan0_ReturnTrue()
        {
            ObligatoriskOpgave_9marts2022.Car klasse = new ObligatoriskOpgave_9marts2022.Car("Volvo", 100, "UB72");

            bool expected = klasse.Price > 0;

            Assert.IsTrue(expected);
        }
        
       
      
        [TestMethod]
        public void Car_LicensePlateEquals2_ReturnTrue()
        {
            ObligatoriskOpgave_9marts2022.Car klasse = new ObligatoriskOpgave_9marts2022.Car("Volvo", 100000, "UB");
            int expected = 2;
            bool characterLengthIsValid = (klasse.LicensePlate.Length == expected);

            Assert.IsTrue(characterLengthIsValid);
        }
        [TestMethod]
        public void Car_LicensePlateEquals5_ReturnTrue()
        {
            ObligatoriskOpgave_9marts2022.Car klasse = new ObligatoriskOpgave_9marts2022.Car("Volvo", 100000, "UB 48");
            int expected = 5;

            bool lengthIsValid = (klasse.LicensePlate.Length == expected);

            Assert.IsTrue(lengthIsValid);
        }
        
    }
}
