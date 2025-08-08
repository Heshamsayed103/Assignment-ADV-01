using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_01
{
    internal static class Helper<T01> where T01 : struct
    {
        // Generic Constraints:
        // 1. Primary Constraints [0 : 1]
        // 1.1 Class
        // 1.2 Struct
        // 1,3 Special type point
        // 1.4 enum
        // 1.5 notnull

        // 2. Secondary Constraints [0 : M]
        // T Implement Interface

        // 3. Constructor Constraints



        // T : Must Be Type Which Implement The IComparable Interface

        public static void BubbleSort<T>(T[] Arr) where T : IComparable<T>
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (Arr[j].CompareTo(Arr[j + 1]) > 0)
                            SWAP(ref Arr[j], ref Arr[j + 1]);

                    }


                }
            }
        }

        public static void BubbleSort<T>(T[] Arr, IComparer<T> comparer) where T : IComparable<T>
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (comparer.Compare(Arr[j], Arr[j + 1]) > 0)
                            SWAP(ref Arr[j], ref Arr[j + 1]);

                    }


                }
            }
        }

        #region Non Generic BubbleSort
        //public static void BubbleSort(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if(Arr[j] > Arr[j +1])
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);

        //            }


        //        }
        //    }
        //} 
        #endregion


        #region Generic Linear Search Method 
        public static int LinearSearch<T>(T[] Arr, T Value)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Arr[i].Equals(Value)) return i;
                }

            }

            return -1;
        }

        public static int LinearSearch<T>(T[] Arr, T Value, IEqualityComparer<T> equalityComparer)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Arr[i].Equals(Value)) return i;
                }

            }

            return -1;
        }
        #endregion

        #region Non Generic LinearSearch
        //public static int LinearSearch(int[] Arr, int Value)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            if (Arr[i] == Value) return i;
        //        }

        //    }

        //    return -1;
        //} 
        #endregion

        #region Generic SWAP
        public static void SWAP<T>(ref T X, ref T Y)
        {
            T Temp = X;

            X = Y;

            Y = Temp;
        }

        public static void Print(string data)
        {
            Console.WriteLine(data);
        }
        #endregion

        public static void PrintArray<T>(T[] arr)
        {
            foreach (T i in arr)
            {
                Console.WriteLine($"{i} ");
            }


        }

        #region Non Generic SWAP

        //public static void SWAP(ref int X , ref int Y)
        //{
        //    int Temp = X;

        //    X = Y; 

        //    Y = Temp;
        //}

        //public static void SWAP(ref double X, ref double Y)
        //{
        //    double Temp = X;

        //    X = Y;

        //    Y = Temp;
        //}


        //public static void SWAP(ref Point X, ref Point Y)
        //{
        //    Point Temp = X;

        //    X = Y;

        //    Y = Temp;
        //} 
        #endregion
    }
}
