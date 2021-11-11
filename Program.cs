using System;

namespace Demo9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
        int y = 20;
        int z = 30;

        Method(x, y, ref z);
        Console.WriteLine("x={0}, y={1}, and z={2}", x, y, z);
    }

    static void Method(int i, int j, ref int k)
    {
        i = 100;
        j = 200;
        k = 300;
        }
    }
}
