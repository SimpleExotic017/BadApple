using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadApple
{
    internal class Frames
    {
        public static void Start()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    Console.Write("+");
                }
                Console.Write("\n");
            }
        }
    }
}
