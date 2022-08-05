using System;
using System.Collections.Generic;

namespace Playground2
{
    class Program
    {
        static void Main(string[] args)
        {
            int? index = null;

            Console.WriteLine(1);

            if (index.HasValue && index.Value == 1)
            {
                Console.WriteLine(index);

            }
            Console.WriteLine(3);

        }
    }
}
