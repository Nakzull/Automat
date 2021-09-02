using System;

namespace Automat
{
    class Program
    {
        static void Main(string[] args)
        {
            Wares.AddToList();
            for (; ; )
                Wares.Logic();
        }
    }
}
