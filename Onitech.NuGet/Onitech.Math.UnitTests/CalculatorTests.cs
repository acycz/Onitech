using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Ploeh.AutoFixture;
using Should;

namespace Onitech.Math.UnitTests
{
    public class CalculatorTests
    {
        private static readonly Fixture Fixture = new Fixture();

        [Test]
        public void Sum_of_two_numbers_are_equal_sum_of_the_two_numbers()
        {
            var number1 = Fixture.Create<int>();
            var number2 = Fixture.Create<int>();

            Calculator.Add(number1, number2).ShouldEqual(number1+number2);
        }
    }
}