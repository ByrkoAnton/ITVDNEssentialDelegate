using System;

namespace delegate03
{
    class Program
    {
        public delegate int SomeDel();
        public delegate double Average(SomeDel[]arr);

        static void Main(string[] args)
        {
            SomeDel[] arr = new SomeDel[3];
            arr[0] += GetRnd;
            arr[1] += GetRnd;
            arr[2] += GetRnd;

            Average average = delegate(SomeDel[] arr)
            {
                int sum = 0;
                foreach (var var in arr)
                {
                    int num = var.Invoke();
                    sum += num;
                    Console.WriteLine(num);
                }
                return (double) sum / arr.Length;
            };

            Console.WriteLine($"average = {average (arr)}");

            int GetRnd()
            {
                Random rnd = new Random();
                return rnd.Next(20);
            }
        }
    }
}
