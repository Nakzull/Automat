using System;

namespace Automat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here I add my wares to my list and then I make an infinity loop so that the vending machine keeps running even after use.
            Wares.AddToList();
            for (; ; )
                Wares.Logic();
        }
    }
}
