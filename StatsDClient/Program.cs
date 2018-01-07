using System;

namespace StatsDClient
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sending metrics to StatsD");

            while(true)
            {
                for (int i = 0; i < 10; i++)
                {
                    var statsDClient = new StatsD("graphite.learngraphana.com");
           
                    statsDClient.Send("SqlServer.Orders.LastMinute:1|g");
}
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Metric was sent!");
            }
        }
    }
}
