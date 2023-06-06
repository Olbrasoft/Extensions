using FluentAssertions;
using Xunit;

namespace Olbrasoft.Extensions.Tests;
public class Int32ExtensionsTests
{
    [Fact]
    public void Int32Extensions_Sould_Be_Static_Class()
    {
        //Arrange
        var type = typeof(Int32Extensions);

        //Act
        var result = type.IsStatic();

        //Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Int32Extensions_Should_Be_Public_Class()
    {
        //Arrange
        var type = typeof(Int32Extensions);

        //Act
        var result = type.IsPublic;

        //Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Assembly_Name_Should_Be_Equivalent_To_Expected()
    {
        //Arrange
        var expected = "Olbrasoft.Extensions";

        //Act
        var name = typeof(Int32Extensions).Assembly.GetName().Name;

        //Assert
        name.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Int32Extensions_NamespaceShouldBe_EquivalentToExpected()
    {
        //Arrange
        var expected = "Olbrasoft.Extensions";   

        //Act
        var @namespace= typeof(Int32Extensions).Namespace;

        //Assert
        @namespace.Should().BeEquivalentTo(expected);   
    }

    [Fact]
    public void ParseOrZero_NonNumber_ShouldBeZero()
    {
        //Arrange
        var sut = "nonNumber";
       
        //Act
        int result = Int32Extensions.ParseOrZero(sut);

        //Assert
        result.Should().Be(0);
    }

    [Fact]
    public void ParseOrZero_1976AsString_ShouldBe1976()
    {
        //Arrange
        var sut = "1976";

        //Act
        var result = Int32Extensions.ParseOrZero(sut);

        //Assert
        result.Should().Be(1976);
    }

    [Fact]
    public void ParseOrZero_Null_ShouldBe0()
    {
        //Arrange
        string sut = null;

        //Act
        var result = Int32Extensions.ParseOrZero(sut);

        //Assert
        result.Should().Be(0);
    }

    [Fact]
    public void ParseOrZero_minus700_ShouldBeminus700()
    {
        //Arrange
        var sut = "-700";

        //Act
        var result = Int32Extensions.ParseOrZero(sut);

        //Assert
        result.Should().Be(-700);
    }
}
