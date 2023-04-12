using BubbleSortApp;

namespace BubbleSortTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new int[] {1,2,5},new int[] { 2,4,6},new int[] { 1,2,2,4,5,6})]
    [TestCase(new int[] { 1, 5 }, new int[] { 2, 4, 6 }, new int[] { 1, 2, 4, 5, 6 })]
    [TestCase(new int[] { }, new int[] { 2, 4, 6 }, new int[] { 2, 4, 6 })]
    [TestCase(new int[] { }, new int[] { }, new int[] { })]
    public void GivenTwoArrays_PreludeMergeSort_ReturnsCorrectArray(int[] arr1, int[] arr2, int[] output)
    {
        Assert.That(Program.PreludeMergeSort(arr1, arr2), Is.EqualTo(output));
    }

    [TestCase (new int[] { 1, 2, 5 }, null)]
    [TestCase(null, new int[] { 1, 2, 5 })]
    [TestCase(null, null)]
    public void GivenNullArrays_PreludeMergeSort_ThrowsCorrectException(int[] arr1, int[] arr2)
    {
        Assert.That(() => Program.PreludeMergeSort(arr1, arr2), Throws.TypeOf<ArgumentException>().With.Message.EqualTo("This method needs two arrays"));
    }



}