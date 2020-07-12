using System;
using System.Threading.Channels;

namespace delegateAdditional
{
    class Program
    {
        public delegate double Average(int a, int b, int c);
        static void Main(string[] args)
        {
            Average average = delegate(int a, int b, int c)
            {
                return (a + b + c) / (double) 3;
            };

            Console.WriteLine($"average = {average(5,8,3)}");
        }

    }
}
