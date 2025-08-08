using Assignment_ADV_01;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_ADV_01
{
    #region Q"1Generic Range Class
    //public class Range<T> where T : IComparable<T>
    //{
    //    private T min;
    //    private T max;

    //    public Range(T minimum, T maximum)
    //    {
    //        min = minimum;
    //        max = maximum;
    //    }

    //    public bool IsInRange(T value)
    //    {
    //        return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
    //    }

    //    public double Length()
    //    {
    //        return Convert.ToDouble(max) - Convert.ToDouble(min);
    //    }
    //}
    #endregion

    #region Q"4 FixedSizeList Implementation
    //public class FixedSizeList<T>
    //{
    //    private T[] items;
    //    private int count = 0;
    //    private int capacity;

    //    public FixedSizeList(int capacity)
    //    {
    //        if (capacity <= 0)
    //            throw new ArgumentException("Capacity must be greater than zero.");
    //        this.capacity = capacity;
    //        items = new T[capacity];
    //    }

    //    public void Add(T item)
    //    {
    //        if (count >= capacity)
    //            throw new InvalidOperationException("List is full. Cannot add more elements.");
    //        items[count] = item;
    //        count++;
    //    }

    //    public T Get(int index)
    //    {
    //        if (index < 0 || index >= count)
    //            throw new IndexOutOfRangeException("Invalid index.");
    //        return items[index];
    //    }
    //}

    #endregion


}
internal class Program
{

    #region Q2"Reverse ArrayList Function
    //static void ReverseArrayList(ArrayList list)
    //{
    //    int left = 0;
    //    int right = list.Count - 1;

    //    while (left < right)
    //    {
    //        object temp = list[left];
    //        list[left] = list[right];
    //        list[right] = temp;

    //        left++;
    //        right--;
    //    }
    //}
    #endregion
    static void Main()
    {


        #region //Question:1. create a generic Range<T> class that represents a range of values from a
        //minimum value to a maximum value. The range should support basic
        //operations such as checking if a value is within the range and determining
        //the length of the range.
        //    Console.WriteLine("Choose data type (int/double): ");
        //    string typeChoice = Console.ReadLine().Trim().ToLower();

        //    if (typeChoice == "int")
        //    {
        //        Console.Write("Enter minimum value: ");
        //        int min = Convert.ToInt32(Console.ReadLine());

        //        Console.Write("Enter maximum value: ");
        //        int max = Convert.ToInt32(Console.ReadLine());

        //        Range<int> range = new Range<int>(min, max);

        //        Console.Write("Enter value to check: ");
        //        int value = Convert.ToInt32(Console.ReadLine());

        //        Console.WriteLine("Is in range? " + range.IsInRange(value));
        //        Console.WriteLine("Range length: " + range.Length());
        //    }
        //    else if (typeChoice == "double")
        //    {
        //        Console.Write("Enter minimum value: ");
        //        double min = Convert.ToDouble(Console.ReadLine());

        //        Console.Write("Enter maximum value: ");
        //        double max = Convert.ToDouble(Console.ReadLine());

        //        Range<double> range = new Range<double>(min, max);

        //        Console.Write("Enter value to check: ");
        //        double value = Convert.ToDouble(Console.ReadLine());

        //        Console.WriteLine("Is in range? " + range.IsInRange(value));
        //        Console.WriteLine("Range length: " + range.Length());
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid type selected!");
        //    }
        //}
        #endregion


        #region //Quesiton: 2. You are given an ArrayList containing a sequence of elements.
        //  try to reverse the order of elements in the ArrayList in-place(in the same
        //arrayList) without using the built-in Reverse.Implement a function that
        //takes the ArrayList as input and modifies it to have the reversed order of elements.


        //    ArrayList myList = new ArrayList();

        //    Console.Write("Enter number of elements: ");
        //    if (!int.TryParse(Console.ReadLine(), out int count) || count < 0)
        //    {
        //        Console.WriteLine("Invalid number. Exiting.");
        //        return;
        //    }

        //    Console.WriteLine("Enter the elements (each on a new line):");
        //    for (int i = 0; i < count; i++)
        //    {
        //        myList.Add(Console.ReadLine()); 
        //    }

        //    Console.WriteLine("\nOriginal ArrayList:");
        //    foreach (var item in myList)
        //        Console.Write(item + " ");
        //    Console.WriteLine();


        //    ReverseArrayList(myList);

        //    Console.WriteLine("\nReversed ArrayList:");
        //    foreach (var item in myList)
        //        Console.Write(item + " ");
        //    Console.WriteLine();
        //}
        #endregion


        #region Question: 3. You are given a list of integers. Your task is to find and return a new list
        //containing only the even numbers from the given list.

        //static List<int> GetEvenNumbers(List<int> numbers)
        //{
        //    List<int> evens = new List<int>();
        //    foreach (int num in numbers)
        //    {
        //        if (num % 2 == 0)
        //            evens.Add(num);
        //    }
        //    return evens;
        //}


        //List<int> nums = new List<int>();

        //Console.Write("Enter number of integers: ");
        //int count = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter the integers:");
        //for (int i = 0; i < count; i++)
        //    nums.Add(int.Parse(Console.ReadLine()));

        //List<int> evenNums = GetEvenNumbers(nums);

        //Console.WriteLine("\nEven numbers:");
        //foreach (var n in evenNums)
        //    Console.Write(n + " ");

        #endregion


        #region Question 4 : implement a custom list called FixedSizeList<T> with a predetermined
        //capacity.This list should not allow more elements than its capacity and
        //should provide clear messages if one tries to exceed it or access invalid indices.

        //FixedSizeList<string> list = new FixedSizeList<string>(3);

        //try
        //{
        //    list.Add("Apple");
        //    list.Add("Banana");
        //    list.Add("Cherry");
        //    //list.Add("Extra"); // Uncomment to test overflow exception

        //    Console.WriteLine(list.Get(0));
        //    Console.WriteLine(list.Get(2));
        //    // Console.WriteLine(list.Get(5)); // Uncomment to test invalid index
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //} 
        #endregion
    }


}






