using System;
using Xunit;
using Hello;
using System.IO;

namespace Hello.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Is_Leap_Year()
        {
            var hello = new Program();
            Assert.True(hello.IsLeapYear(2000));
        }
         [Fact]
        public void is_not_Leap_year()
        {
            var hello = new Program();
            Assert.False(hello.IsLeapYear(2333));
        }
          [Fact]
        public void year_is_less_than_1582()
        {
          var hello = new Program();
            Assert.False(hello.IsLeapYear(400));

        }
         

    }
}
