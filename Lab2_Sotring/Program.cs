using System;
using System.Linq;

namespace Lab2_Sotring
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix =
            {
                new []{1, 2, 3, 4},
                new []{2, 5, 8, 10},
                new []{0, 0, 20, 0}
            };

            IComparator<int[]> comparator;
            
            Console.WriteLine("1 - сортировка по сумме" + "\n" + 
                              "2 - соритровка по максимальному элементу в строке" + "\n" +
                              "3 - сортировка по минимальному элементу в строке");
            ConsoleKey input = Console.ReadKey().Key;
            
            bool sortingAsc;

            KeyComparator<int[], IComparable>.KeyExtractor keyExtractor;
            
            switch (input)
            {
                case ConsoleKey.D1:
                    keyExtractor = row => row.Sum();
                    break;
                case ConsoleKey.D2:
                    keyExtractor = row => row.Max();
                    break;
                case ConsoleKey.D3:
                    keyExtractor = row => row.Min();
                    break;
                default:
                    throw new Exception();
            }
            
            Console.Clear();
            comparator = new KeyComparator<int[], IComparable>(keyExtractor);
            sortingAsc = requestSortDirection();
            comparator = ReversedComparator<int[]>.wrap(comparator, sortingAsc);
            
            new BubbleSort<int[]>().sortBy(matrix, comparator);

            printMatrix(matrix);
        }
        
        public static bool requestSortDirection()
        {
            Console.WriteLine("1 - соритровка по возрастанию" + "\n" + 
                              "2 - сортировка по убыванию");
            ConsoleKey input = Console.ReadKey().Key;
            Console.Clear();
            switch (input)
            {
                case ConsoleKey.D1:
                    return true;
                case ConsoleKey.D2:
                    return false;
                default:
                    return requestSortDirection();
            }
        }
        
        public static void printMatrix<T> (T[][] matrix)
        {
            foreach (var row in matrix)
            {
                foreach (var element in row)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
        }
    }
}