using System.Collections;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 10, 2, 38, 4, 5, 6, 7, 8, 9, 17, 11, 12, 13, 14 };
            bubblesort(x);
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
        }


        #region 1
        public static void bubblesort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {

                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }


                if (!swapped)
                    break;

            }

        }
        #endregion


    }



    #region 2
    public class Range<T> where T : IComparable<T>
    {
        public T Minimum { get; private set; }
        public T Maximum { get; private set; }

        public Range(T minimum, T maximum)
        {
            if (minimum.CompareTo(maximum) > 0)
            {
                throw new ArgumentException("input invalid");
            }

            Minimum = minimum;
            Maximum = maximum;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0;
        }

        public T Length()
        {
            dynamic min = Minimum;
            dynamic max = Maximum;
            return max - min;
        }

        #endregion


        #region 3

        static void ReverseArrayList(ArrayList arrayList)
        {
            int left = 0;
            int right = arrayList.Count - 1;

            while (left < right)
            {
                object temp = arrayList[left];
                arrayList[left] = arrayList[right];
                arrayList[right] = temp;

                left++;
                right--;
            }
        }
        #endregion

        #region 4
        static List<T> GetEvenNumbers(List<int> numbers)
        {
            List<T> evenNumbers = new List<T>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            return evenNumbers;
        }
        #endregion

        #region 5

public class FixedSizeList<T>
    {
        private T[] items;
        private int count;

        public int Capacity { get; private set; }

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("more than 0.");
            }

            Capacity = capacity;
            items = new T[capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (count >= Capacity)
            {
                throw new InvalidOperationException("List is full.");
            }

            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Invalid index.");
            }

            return items[index];
        }
    }




        #endregion


        #region 6
        ///???????????
        #endregion
    }


}




    



