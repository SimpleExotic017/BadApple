using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadApple
{
    internal class Frames
    {
        private static string pixel = "█";

        public static void Start()
        {
            string[] frame;
            string img = "";
            string lastimg = "";
            Console.BackgroundColor = ConsoleColor.Black;
            for (int frameIndex = 1; frameIndex <= 5572; frameIndex++)
            {
                if (frameIndex < 10)
                {
                    frame = File.ReadAllLines(
                        $"..\\..\\..\\frames-ascii\\out000{frameIndex}.jpg.txt"
                    );
                }
                else if (frameIndex < 100)
                {
                    frame = File.ReadAllLines(
                        $"C:..\\..\\..\\frames-ascii\\out00{frameIndex}.jpg.txt"
                    );
                }
                else if (frameIndex < 1000)
                {
                    frame = File.ReadAllLines(
                        $"..\\..\\..\\frames-ascii\\out0{frameIndex}.jpg.txt"
                    );
                }
                else
                {
                    frame = File.ReadAllLines(
                        $"C:\\Users\\matth\\school\\side-projects\\BadApple\\frames-ascii\\out{frameIndex}.jpg.txt"
                    );
                }
                img = "";
                for (int i = 0; i < frame.Length; i++)
                {
                    for (int j = 0; j < frame[i].Length; j++)
                    {
                        if (frame[i].Substring(j, 1) == "@")
                        {
                            img += pixel;
                        }
                        else
                        {
                            img += " ";
                        }
                    }
                    img += "\n";
                }
                if (frameIndex == 1)
                {
                    lastimg = img;
                    Console.WriteLine(img);
                }
                for (int i = 0; i < img.Length - 1; i++)
                {
                    if (lastimg.Substring(i, 1) != img.Substring(i, 1))
                    {
                        Console.SetCursorPosition(i % 97, i / 97);
                        if (lastimg.Substring(i, 1) == " ")
                        {
                            Console.Write(pixel);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                lastimg = img;
                
                Thread.Sleep(20);
            }
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\t\t\tThank you for watching");
            Console.WriteLine("\t\t\t    Programmed by:");
            Console.WriteLine("\t\t\t\tHell-C");
            Console.WriteLine("\t\t\t\t aka:");
            Console.WriteLine("\t\t\tMatthias van Hogerhuis");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
