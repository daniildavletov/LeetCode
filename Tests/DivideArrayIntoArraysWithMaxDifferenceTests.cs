using NuGet.Frameworks;
using Problems;

namespace Tests;

public class DivideArrayIntoArraysWithMaxDifferenceTests
{
    private DivideArrayIntoArraysWithMaxDifference _divideArrayIntoArraysWithMaxDifference;

    [SetUp]
    public void Setup()
    {
        _divideArrayIntoArraysWithMaxDifference = new DivideArrayIntoArraysWithMaxDifference();
    }

    [Test]
    public void DivideArray_SimpleCase()
    {
        var arrays = _divideArrayIntoArraysWithMaxDifference.DivideArray([1, 3, 4, 8, 7, 9, 3, 5, 1], 2);
        Assert.That(arrays, Has.Length.EqualTo(3));
        Assert.That(arrays[0][0], Is.EqualTo(1));
        Assert.That(arrays[0][1], Is.EqualTo(1));
        Assert.That(arrays[0][2], Is.EqualTo(3));
        Assert.That(arrays[1][0], Is.EqualTo(3));
        Assert.That(arrays[1][1], Is.EqualTo(4));
        Assert.That(arrays[1][2], Is.EqualTo(5));
        Assert.That(arrays[2][0], Is.EqualTo(7));
        Assert.That(arrays[2][1], Is.EqualTo(8));
        Assert.That(arrays[2][2], Is.EqualTo(9));
    }
    
    [Test]
    public void DivideArray_ImpossibleCase()
    {
        var arrays = _divideArrayIntoArraysWithMaxDifference.DivideArray([2, 4, 2, 2, 5, 2], 2);
        Assert.That(arrays, Has.Length.EqualTo(0));
    }
    
    [Test]
    public void DivideArray_MoreComplexCase()
    {
        var arrays = _divideArrayIntoArraysWithMaxDifference.DivideArray([4,2,9,8,2,12,7,12,10,5,8,5,5,7,9,2,5,11], 14);
        Assert.That(arrays, Has.Length.EqualTo(6));
    }
}