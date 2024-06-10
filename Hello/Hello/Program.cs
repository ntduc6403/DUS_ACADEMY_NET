namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            try
            {
                int n = 0;
                int x = 10 / n;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }

        }
    }
}
