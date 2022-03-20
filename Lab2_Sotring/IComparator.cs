namespace Lab2_Sotring
{
    public interface IComparator<T>
    {
        /**
         * Сравнивает два объекта и возвращает:
         *  - положительное число, если первый объект больше второго;
         *  - 0, если числа равны;
         *  - отрицательное число, если первый объект меньше второго.
         */
        public int Compare(T first, T second);
    }
}