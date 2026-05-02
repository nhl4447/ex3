namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Distance (m): ");
            double d = double.Parse(Console.ReadLine());

            Console.Write("Hours: ");
            int h = int.Parse(Console.ReadLine());

            Console.Write("Minutes: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Seconds: ");
            int s = int.Parse(Console.ReadLine());

            double t = h * 3600 + m * 60 + s;

            Console.WriteLine("Km/h = " + d * 3.6 / t);
            Console.WriteLine("Miles/h = " + d * 2.23694 / t);
        }
    }
}
