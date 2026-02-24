namespace BadApple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(800,800);
            Console.CursorVisible = false;
            Frames.Start();
            Console.ReadLine();
        }
    }
}
