namespace Lab2_Sotring
{
    public class BubbleSort<T> : ISorting<T>
    {
        public void sortBy(T[] array, IComparator<T> elementComparator)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (elementComparator.Compare(array[i],array[j]) > 0)
                    {
                        (array[i], array[j]) = (array[j], array[i]);
                    }
                }
            }
        }
    }
}