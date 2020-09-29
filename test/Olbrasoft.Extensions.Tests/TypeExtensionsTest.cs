using System;
using Xunit;

namespace Olbrasoft.Extensions.Tests
{
    public class TypeExtensionsTest
    {
        [Fact]
        public void IsStatic()
        {
            var type = typeof(AwesomeSaticClass);

            var result = type.IsStatic();

            Assert.True(result);
        }

        [Fact]
        public void Is_Not_Static()
        {
            //Arrange
            var type = typeof(AwesomeNotStaticClass);

            //Act
            var result = type.IsStatic();

            //Assert
            Assert.False(result);
        }
    }
}