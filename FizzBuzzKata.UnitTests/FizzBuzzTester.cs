using System;
using System.Diagnostics.Eventing.Reader;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests
{
	[TestFixture]
	public class FizzBuzzTester
	{
		readonly FizzBuzzer _translator = new FizzBuzzer();

		[Test, Category("Unit")]
		public void InstantiateTranslator()
		{
			//Arrange

			//Act
			//Assert

			Assert.IsNotNull(_translator);
		}

		[Test, Category("Unit")]
		public void When_AskedABoutOne_ReturnsOne()
		{
			//Arrange
			//Act
			var answer = _translator.Translate(1);

			//Assert
			Assert.AreEqual(1.ToString(), answer);
		}

		[Test, Category("Unit")]
		public void When_Three_ReturnFizz()
		{
			//Arrange
			//Act

			var answer = _translator.Translate(3);
			//Assert
			Assert.AreEqual("Fizz", answer);
		}

		[Test, Category("Unit")]
		public void WhenFour_DoNot_ReturnFizz()
		{
			//Arrange
			//Act

			var answer = _translator.Translate(4);
			//Assert
			Assert.AreNotEqual("Fizz", answer);
		}

		[Test, Category("Unit")]
		public void WhenFive_Return_Buzz()
		{
			//Arrange
			//Act

			var answer = _translator.Translate(5);
			//Assert
			Assert.AreEqual("Buzz", answer);
		}

		[Test, Category("Unit")]
		public void WhenTenReturnBuzz()
		{
			//Arrange
			//Act

			var answer = _translator.Translate(10);
			//Assert
			Assert.AreEqual("Buzz", answer);
		}

		[Test, Category("Unit")]
		public void FifteenReturnsFizzBuzz()
		{
			//Arrange
			//Act

			var answer = _translator.Translate(15);
			//Assert
			Assert.AreEqual("FizzBuzz", answer);
		}

		[Test, Category("Unit")]
		public void FiftyTwoReturnsBuzz()
		{
			var answer = _translator.Translate(52);

			Assert.AreEqual("Buzz", answer);
		}

		[Test, Category("Unit")]
		public void PrintFunList()
		{
			for(int i=1;i<=100;i++)
			{
				System.Diagnostics.Debug.WriteLine(_translator.Translate(i));
			}
		}

		[Test, Category("Unit")]
		public void ThirtyOneReturnsFizz()
		{
			var answer = _translator.Translate(31);

			Assert.AreEqual("Fizz", answer);
		}

		[Test, Category("Unit")]
		public void thirtyFiveReturnsFizzBuzz()
		{
			//Arrange
			var answer = _translator.Translate(35);
			//Act
			//Assert
			Assert.AreEqual("FizzBuzz", answer);
		}
	}



	public class FizzBuzzer
	{
		public string Translate(int input)
		{
			if (IsDivisibleByThree(input) && IsDivisibleByFive(input))
				return "FizzBuzz";

			if (IsDivisibleByThree(input))
				return "Fizz";

			if (input.ToString().Contains("3") && input.ToString().Contains("5"))
				return "FizzBuzz";
			if (IsDivisibleByFive(input))
				return "Buzz";

			if (input.ToString().Contains("3"))
				return "Fizz";

			if (input.ToString().Contains("5"))
				return "Buzz";

			


			return input.ToString();
		}

		private bool IsDivisibleByThree(int input)
		{
			return input % 3 == 0;
		}

		private bool IsDivisibleByFive(int input)
		{
			return input % 5 == 0;
		}

	}
}
