using System;

namespace ServerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server1 = new Server();
            Console.WriteLine(server1.Process("pong"));

            Server server2 = new Server("time");
            Console.WriteLine(server2.Process("ping"));

            Server server3 = new Server("toUpper");
            Console.WriteLine(server3.Process("pong"));

            Server server4 = new Server("toUpper", "time");
            Console.WriteLine(server4.Process("echo sialala"));

        }
    }
}
