namespace First_Task
{

    public class BananaRipenessRange<T> where T : IComparable<T>
    {
        private T min;
        private T max;


        public BananaRipenessRange(T minimum, T maximum)
        {
            min = minimum;
            max = maximum;
        }


        public bool IsPerfectBanana(T ripeness)
        {
            return ripeness.CompareTo(min) >= 0 && ripeness.CompareTo(max) <= 0;
        }
    }
    internal class Program
    {
        static void Main()
        {

            Console.Write("Enter minimum ripeness: ");
            double min = double.Parse(Console.ReadLine());


            Console.Write("Enter maximum ripeness: ");
            double max = double.Parse(Console.ReadLine());


            BananaRipenessRange<double> bananaRange = new BananaRipenessRange<double>(min, max);


            Console.Write("Enter banana ripeness to check: ");
            double bananaRipeness = double.Parse(Console.ReadLine());


            bool isPerfect = bananaRange.IsPerfectBanana(bananaRipeness);
            Console.WriteLine("Is the banana perfect? " + isPerfect);
        }
    }
}
