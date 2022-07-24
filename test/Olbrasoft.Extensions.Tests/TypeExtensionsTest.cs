using System;
using Xunit;

namespace Olbrasoft.Extensions.Tests;

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

    [Fact]
    public void Is_Generic_type()
    {
        //Arrange
        var type = typeof(AwesomeGenericType<>);

        //Act
        var result = type.IsGenericType(type);

        //Assert
        Assert.True(result);

    }

    [Fact]
    public void Implements_Generic_Interface()
    {
        //Arrange
        var type = typeof(AwesomeImplementsGenericInterface);

        //Act
        var result = type.ImplementsGenericInterface(typeof(AwesomeGenericInterface<>));

        //Assert
        Assert.True(result);
    }


}