using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PrimeMultiplicationTables.Tests
{
    public class Tests_Controller
    {
        /// <summary>
        /// Check that the empty input is invalid
        /// </summary>
        [Fact]
        public void ValidateEmptyInput()
        {
            var result = new Tuple<bool, int>(false, -1);
            Assert.Equal(result, Controller.ValidateInput(""));
        }

        /// <summary>
        /// Check that non numerical input is invalid
        /// </summary>
        [Fact]
        public void ValidateNonNumericalInput()
        {
            var result = new Tuple<bool, int>(false, -1);
            Assert.Equal(result, Controller.ValidateInput("A"));
        }

        /// <summary>
        /// Check that interger input is valid
        /// </summary>
        /// <param name="input">The interger value to be tested</param>
        /// <param name="numResult">The interger result expected</param>
        [Theory]
        [InlineData(1, 1)]
        [InlineData(10, 10)]
        [InlineData(100, 100)]
        [InlineData(1000, 1000)]
        public void ValidateNumericalInput(String input, int numResult)
        {
            var result = new Tuple<bool, int>(true, numResult);
            Assert.Equal(result, Controller.ValidateInput(input));
        }

        /// <summary>
        /// Check that negative interger input is invalid
        /// </summary>
        /// <param name="input">The interger value to be tested</param>
        /// <param name="numResult">The interger result expected</param>
        [Theory]
        [InlineData(-1, -1)]
        [InlineData(-10, -1)]
        [InlineData(-100, -1)]
        [InlineData(-1000, -1)]
        public void ValidateNegativeNumericalInput(String input, int numResult)
        {
            var result = new Tuple<bool, int>(false, numResult);
            Assert.Equal(result, Controller.ValidateInput(input));
        }

        [Theory]
        [InlineData(1.1, -1)]
        [InlineData(10.2, -1)]
        [InlineData(143.4, -1)]
        [InlineData(-78.1, -1)]
        public void ValidateFloatInput(String input, int numResult)
        {
            var result = new Tuple<bool, int>(false, numResult);
            Assert.Equal(result, Controller.ValidateInput(input));
        }
    }
}
