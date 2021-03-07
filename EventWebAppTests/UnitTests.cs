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
            var value = DateTime.Now.Date.AddDays(1);
            var attrib = new DateFutureOnlyAttribute();

            var result = attrib.IsValid(value);

            Assert.True(result);
        }
    }
}
