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
            //IterationOne();
            IterationTwo();
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t   Thank you for watching");
            Console.WriteLine("\t\t\t\t       Programmed by:");
            Console.WriteLine("\t\t\t\t\t    Hell-C");
            Console.WriteLine("\t\t\t\t\t     aka:");
            Console.WriteLine("\t\t\t\t    Matthias van Hogerhuis");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        private static void IterationOne()
        {
            string[] frame;
            string img = "";
            string lastimg = "";
            Console.BackgroundColor = ConsoleColor.Black;
            string[] appendToDiff = new string[5573];
            for (int frameIndex = 1; frameIndex <= 5572; frameIndex++)
            {
                string frameDiff = "";
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
                    frame = File.ReadAllLines($"..\\..\\..\\frames-ascii\\out{frameIndex}.jpg.txt");
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
                    img += $"\n";
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
                            frameDiff += $"{i % 97},{i / 97},BLACK;";
                        }
                        else
                        {
                            Console.Write(" ");
                            frameDiff += $"{i % 97},{i / 97},WHITE;";
                        }
                    }
                }
                appendToDiff[frameIndex - 1] = frameDiff;
                lastimg = img;
                Thread.Sleep(10);
            }
            File.WriteAllLines(@"..\..\..\frame-diff\frames-diff.txt", appendToDiff);
        }

        private static void IterationTwo()
        {
            //36 hood
            //97 breed
            for (int i = 0; i < 36; i++)
            {
                for (int j = 0; j < 97; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("");
            string[] frames = File.ReadAllLines($"..\\..\\..\\frame-diff\\frames-diff.txt");

            int LastFrames = 0;
            DateTime start = DateTime.Now;

            for (int frameIndex = 0; frameIndex < frames.Length; frameIndex++)
            {
                if (frames[frameIndex].Contains(";"))
                {
                    string[] diffs = frames[frameIndex].Split(";");
                    for (int frameDiffs = 0; frameDiffs < diffs.Length - 1; frameDiffs++)
                    {
                        string[] split = diffs[frameDiffs].Split(",");
                        int x = Convert.ToInt32(split[0].Trim());
                        int y = Convert.ToInt32(split[1].Trim());
                        string color = split[2].Trim();

                        Console.SetCursorPosition(x, y);
                        if (color == "BLACK")
                        {
                            Console.Write(pixel);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                        
                    }
                }

                Console.SetCursorPosition(0, 37);
                Console.Write($"{frameIndex}\t\t");
                Random rand = new Random();
                Console.Write($"{59 + rand.Next(0, 4)}/FPS");
                Console.WriteLine("");

                Thread.Sleep(16);
            }
        }
    }
}
