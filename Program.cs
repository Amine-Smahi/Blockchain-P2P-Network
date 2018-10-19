using Newtonsoft.Json;
using System;

namespace BlockchainCore
{
    class Program
    {
        public static int Port;
        private static P2PServer _server;
        private static readonly P2PClient Client = new P2PClient();
        public static Blockchain PhillyCoin = new Blockchain();
        private static string _name = "Unknown";

        static void Main(string[] args)
        {
            PhillyCoin.InitializeChain();

            if (args.Length >= 1)
                Port = int.Parse(args[0]);
            if (args.Length >= 2)
                _name = args[1];

            if (Port > 0)
            {
                _server = new P2PServer();
                _server.Start();
            }
            if (_name != "Unkown")
            {
                Console.WriteLine($"Current user is {_name}");
            }

            Console.WriteLine("=========================");
            Console.WriteLine("1. Connect to a server");
            Console.WriteLine("2. Add a transaction");
            Console.WriteLine("3. Display Blockchain");
            Console.WriteLine("4. Exit");
            Console.WriteLine("=========================");

            int selection = 0;
            while (selection != 4)
            {
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Please enter the server URL");
                        string serverUrl = Console.ReadLine();
                        Client.Connect($"{serverUrl}/Blockchain");
                        break;
                    case 2:
                        Console.WriteLine("Please enter the receiver name");
                        string receiverName = Console.ReadLine();
                        Console.WriteLine("Please enter the amount");
                        string amount = Console.ReadLine();
                        PhillyCoin.CreateTransaction(new Transaction(_name, receiverName, int.Parse(amount)));
                        PhillyCoin.ProcessPendingTransactions(_name);
                        Client.Broadcast(JsonConvert.SerializeObject(PhillyCoin));
                        break;
                    case 3:
                        Console.WriteLine("Blockchain");
                        Console.WriteLine(JsonConvert.SerializeObject(PhillyCoin, Formatting.Indented));
                        break;

                }

                Console.WriteLine("Please select an action");
                string action = Console.ReadLine();
                selection = int.Parse(action);
            }

            Client.Close();
        }
    }
}
