using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFun.Test
{
    public class NumberTest
    {
        [Fact]
        public void NumberBy3()
        {
            NumberService numberService = new NumberService();
            string message = numberService.GetNumberString(9);
            Assert.Equal("Fizz", message);
        }

        [Fact]
        public void NumberByNot3()
        {
            NumberService numberService = new NumberService();
            string message = numberService.GetNumberString(10);
            Assert.NotEqual("Fizz", message);
        }


        [Fact]
        public void NumberBy5()
        {
            NumberService numberService = new NumberService();
            string message = numberService.GetNumberString(10);
            Assert.Equal("Buzz", message);
        }

        [Fact]
        public void NumberByNot5()
        {
            NumberService numberService = new NumberService();
            string message = numberService.GetNumberString(11);
            Assert.NotEqual("Buzz", message);
        }

        [Fact]
        public void NumberBy3And5()
        {
            NumberService numberService = new NumberService();
            string message = numberService.GetNumberString(15);
            Assert.Equal("FizzBuzz", message);
        }

        [Fact]
        public void NumberByNot3And5()
        {
            int i = 16;
            NumberService numberService = new NumberService();
            string message = numberService.GetNumberString(i);
            Assert.Equal(i.ToString(), message);
        }
    }
}
