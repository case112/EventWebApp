using EventWebApp.CustomValidation;
using System;
using Xunit;

namespace EventWebAppTests
{
    public class UnitTests
    {
        [Fact]
        public void DateCanBeFutureOnly()
        {
            // arrange
            var value = DateTime.Now.Date.AddDays(1);
            var attrib = new DateFutureOnlyAttribute();

            // act
            var result = attrib.IsValid(value);

            // assert
            Assert.True(result);
        }
    }
}
