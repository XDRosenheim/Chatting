using System;
using System.Net;
using System.Net.Sockets;

namespace Chatting {
    internal class Program {
        private static void Main( string[] args ) {
            var exit = false;
            var readOpt = Console.Read();
            while(!exit) {
                switch(readOpt) {
                    case 1:
                        Chatter.Connect();
                        exit = true;
                        break;
                    case 2:
                        var port = Console.ReadLine();
                        Chatter.Server();
                        exit = true;
                        break;
                }
            }
        }
    }
}
