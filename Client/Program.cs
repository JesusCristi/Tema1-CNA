using Grpc.Core;
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Host = "localhost";
            const int Port = 16842;
            var channel = new Channel($"{Host}:{Port}", ChannelCredentials.Insecure);
            Console.WriteLine("Enter your name please -> ");
            do
            {
                var key = Console.ReadLine();
                var client = new Generated.NameRequestService.NameRequestServiceClient(channel);
                client.OutputName(new Generated.Name
                {
                    Name_ = key
                });
            } while (true);

            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
