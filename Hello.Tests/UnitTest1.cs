using System;
using Xunit;
using Hello;

namespace Hello.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Is_Leap_Year()
        {
            var hello = new Program();
            Assert.True(hello.IsLeapYear(200));
        }
         [Fact]
        public void is_not_Leap_year()
        {
            var hello = new Program();
            Assert.False(hello.IsLeapYear(230));
        }

    }
}
