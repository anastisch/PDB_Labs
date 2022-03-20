namespace Lab2_Sotring
{
    public interface ISorting<T>
    {
        public void sortBy(T[] array, IComparator<T> elementComparator);
    }
}