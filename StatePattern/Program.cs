namespace StatePattern
{
    internal class Program
    {
        static void Main()
        {
            CeilingFan fan = new(new OffState());

            do
            {
                Console.WriteLine("Press Enter to cycle fan, press any other key to exit");

                var key = Console.ReadKey();

                if (key.Key != ConsoleKey.Enter)
                    break;

                fan.PullChain();
            } while (true);
        }
    }
}