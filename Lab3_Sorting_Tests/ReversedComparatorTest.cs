using Lab2_Sotring;
using NUnit.Framework;

namespace Lab3_Sorting_Tests
{
    public class ReversedComparatorTest
    {
        [Test]
        public void TestReversedComparatorByTwoNumbers()
        {
            IComparator<int> comparator = new NaturalOrderComparator();
            IComparator<int> reversedComparator = new ReversedComparator<int>(comparator);

            int actualResult = reversedComparator.Compare(-2, 6);
            Assert.Greater(actualResult, 0);
            
            actualResult = reversedComparator.Compare(8, 8);
            Assert.AreEqual(0, actualResult);
            
            actualResult = reversedComparator.Compare(6, -2);
            Assert.Less(actualResult, 0);
        }
    }
}