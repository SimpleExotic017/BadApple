namespace BadApple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(100,40);
            Console.CursorVisible = false;
            Frames.Start();
            Console.ReadLine();
        }
    }
}
