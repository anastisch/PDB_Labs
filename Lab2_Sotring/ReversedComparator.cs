namespace Lab2_Sotring
{
    public class ReversedComparator<T> : IComparator<T>
    {
        private IComparator<T> del;

        public ReversedComparator(IComparator<T> del)
        {
            this.del = del;
        }

        public int Compare(T first, T second)
        { 
            return -del.Compare(first, second);
        }

        public static IComparator<T> wrap(IComparator<T> original, bool asc)
        {
            if (asc)
            {
                return original;
            }

            return new ReversedComparator<T>(original);
        }
    }
}