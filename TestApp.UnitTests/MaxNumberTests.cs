using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);   
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> emptyList = new();

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(emptyList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        //Arrange
        List<int> oneElementList = new List<int>() { 42 };
        //Act
        int result = MaxNumber.FindMax(oneElementList);
        //Assert
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> positiveList = new List<int>() { 42, 10, 5, 67 };
        //Act
        int result = MaxNumber.FindMax(positiveList);
        //Assert
        Assert.That(result, Is.EqualTo(67));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> negativeList = new List<int>() { -8, -9, -10, -1 };
        //Act
        int result = MaxNumber.FindMax(negativeList);
        //Assert
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> mixedList = new List<int>() { 42, -8, -50, 90, 5 };
        //Act
        int result = MaxNumber.FindMax(mixedList);
        //Assert
        Assert.That(result, Is.EqualTo(90));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        List<int> manqshkiList = new List<int>() { 42, -8, -50, 90, 5, 100, 100 };
        //Act
        int result = MaxNumber.FindMax(manqshkiList);
        //Assert
        Assert.That(result, Is.EqualTo(100));
    }
}
