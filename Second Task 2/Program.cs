namespace Second_Task_2
{

    public class MultiBox<T>
    {
        private List<T> items = new List<T>();

        public void InsertItem(T item)
        {
            items.Add(item);
        }

        public List<T> GetAllItems()
        {
            return items;
        }

        public int Count()
        {
            return items.Count;
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }
    }
    internal class Program
    {
        static void Main()
        {
            
            MultiBox<string> stringBox = new MultiBox<string>();

            
            Console.WriteLine(stringBox.IsEmpty()); // Output: True

            
            stringBox.InsertItem("Apple");
            stringBox.InsertItem("Banana");

            
            Console.WriteLine(stringBox.Count()); // Output: 2
        }
    }

}

