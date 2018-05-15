using System;
using NUnit.Framework;
namespace UnitTestPractice
{

	public class Calc
	{
		public double Add(double num1, double num2)
		{
			return num1 + num2;
		}
	}



	[TestFixture()]
    public class Examples
    {
		Calc CalcT = new Calc();	

	  [Test()]	
      public void Test()
		{
			Assert.AreEqual(CalcT.Add(1, 2), 3);
		}
    }
}
