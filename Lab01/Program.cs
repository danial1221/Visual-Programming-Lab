using System;
namespace Numbers
{
    class program
    {
        static void main(string[] args)
        {
            ExploringNumbers();
        }
        private static void ExploringNumbers()
        {
            Console.WriteLine($"int uses{sizeof(int)} bytes and can store numbers in the range :\n\n" + $" {int.MinValue} to  {int.MaxValue: N0}.\n");

            Console.WriteLine("___________________________________________________________________________________________________________________");

            Console.WriteLine($"int uses{sizeof(double)} bytes and can store numbers in the range :\n\n" + $" {double.MinValue} to  {double.MaxValue: N0}.\n");
            Console.WriteLine("___________________________________________________________________________________________________________________");

            Console.WriteLine($"int uses{sizeof(decimal)} bytes and can store numbers in the range :\n\n" + $" {decimal.MinValue:N0} to  {decimal.MaxValue: N0}.\n");
        }
    }
}
