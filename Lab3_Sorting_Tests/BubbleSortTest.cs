using Lab2_Sotring;
using NUnit.Framework;

namespace Lab3_Sorting_Tests
{
    public class BubbleSortTest
    {
        [Test]
        public void TestSortArrayInNaturalOrder()
        {
            int[] arr = {1, 6, -9, 5, 1, 3};

            int[] expectedResult = {-9, 1, 1, 3, 5, 6};

            new BubbleSort<int>().sortBy(arr, new NaturalOrderComparator());
            
            Assert.AreEqual(expectedResult, arr);
        }
    }
}