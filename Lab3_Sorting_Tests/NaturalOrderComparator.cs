using Lab2_Sotring;

namespace Lab3_Sorting_Tests
{
    public class NaturalOrderComparator : IComparator<int>
    {
        public int Compare(int first, int second)
        {
            return first - second;
        }
    }
}