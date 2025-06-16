using Problems;

namespace Tests;

public class FindPeakElementSolutionTests
{
    private FindPeakElementSolution _findPeakElementSolution;
    
    [SetUp]
    public void Setup()
    {
        _findPeakElementSolution = new FindPeakElementSolution();
    }

    [Test]
    public void FindPeakElement_TwoPeaks_FindLast()
    {
        int[] nums = [1, 2, 1, 3, 5, 6, 4];

        var peakIndex = _findPeakElementSolution.FindPeakElement(nums);
        
        Assert.That(peakIndex, Is.EqualTo(5));
    }
    
    [Test]
    public void FindPeakElement_OneElement_FindZero()
    {
        int[] nums = [1];

        var peakIndex = _findPeakElementSolution.FindPeakElement(nums);
        
        Assert.That(peakIndex, Is.EqualTo(0));
    }
    
    [Test]
    public void FindPeakElement_DecreaseArray_FindLeftPeak()
    {
        int[] nums = [2, 1];

        var peakIndex = _findPeakElementSolution.FindPeakElement(nums);
        
        Assert.That(peakIndex, Is.EqualTo(0));
    }
    
    [Test]
    public void FindPeakElement_IncreaseArray_FindRightPeak()
    {
        int[] nums = [1, 2];

        var peakIndex = _findPeakElementSolution.FindPeakElement(nums);
        
        Assert.That(peakIndex, Is.EqualTo(1));
    }
}