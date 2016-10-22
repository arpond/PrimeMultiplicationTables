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
            Assert.Equal(result,Controller.ValidateInput(""));
        }
    }
}
