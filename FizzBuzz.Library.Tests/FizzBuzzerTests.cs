using NUnit.Framework;
using System;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void Buzzer_WhenDefault_ReturnsInput(
            [Values(1,2,4,7,8,11,13,14,16,17,19)] int input)
        {
           
            //Act
            string output = FizzBuzzer.GetValue(input);


            //Assert
            Assert.AreEqual(input.ToString(), output);

        }
        [Test]
        public void Buzzer_WhenDiv3_ReturnFizz(
            [Values(3,6,9,12,18)] int input)
        {
         
            //Act
            string output = FizzBuzzer.GetValue(input);


            //Assert
            Assert.AreEqual("Fizz", output);

        }
        [Test]
        public void Buzzer_When5_ReturnBuzz(
             [Values(5,10,20)] int input)
      
        {
            //Act
            string output = FizzBuzzer.GetValue(input);


            //Assert
            Assert.AreEqual("Buzz", output);

        }
        [Test]
        public void Buzzer_WhenDiv3AndDiv5_ReturnsFizzBuzz(
           [Values(15)] int input)

        {


            //Act
            string output = FizzBuzzer.GetValue(input);


            //Assert
            Assert.AreEqual("FizzBuzz", output);

        }
    }
}
