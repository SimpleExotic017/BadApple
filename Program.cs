namespace BadApple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(96,37);
            Console.CursorVisible = false;
            Frames.Start();
            Console.ReadLine();
        }
    }
}
