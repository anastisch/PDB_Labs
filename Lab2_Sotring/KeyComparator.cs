using System;

namespace Lab2_Sotring
{
    public class KeyComparator <T, K> : IComparator<T> where K : IComparable
    {
        public delegate K KeyExtractor(T obj);
        
        // Делегат, извлекающий ключи из сравниваемых объектов
        private readonly KeyExtractor _keyExtractor;

        public KeyComparator(KeyExtractor keyExtractor)
        {
            _keyExtractor = keyExtractor;
        }
        
        public int Compare(T first, T second)
        {
            K firstKey = _keyExtractor.Invoke(first);
            K secondKey = _keyExtractor.Invoke(second);

            return firstKey.CompareTo(secondKey);
        }
    }
}