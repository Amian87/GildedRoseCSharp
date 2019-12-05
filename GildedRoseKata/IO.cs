using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class IO : IIO
    {
        public void ConsoleWrite(string output)
        {
            Console.WriteLine(output);
        }
    }
}
