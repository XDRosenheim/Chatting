using System;
using System.Net;
using System.Net.Sockets;

namespace Chatting {
    internal class Chatter {
        public static void Connect() {
            string readIp, nickname;
            var connectPort = 0;
            IPAddress connectIp = null;
            var isIp = false;
            var isPort = false;
            var isNick = false;
            //
            // Nickname / Screenname / Username
            //
            while(!isNick) {
                try {
                    Console.Write( "Enter a nickname: " );
                    nickname = Console.ReadLine();
                    isNick = true;
                } catch(Exception) {
                    // Exception!
                }
            }
            //
            // IP Address
            //
            while(!isIp) {
                try {
                    Console.Write( "IP: \t" );
                    readIp = Console.ReadLine();
                    if(readIp != null) {
                        connectIp = IPAddress.Parse( readIp );
                    }
                    isIp = true;
                } catch(Exception) {
                    // Exception!
                    Console.Clear();
                }
            }
            //
            // Port
            //
            while(!isPort) {
                try {
                    Console.Write( "Port:\t" );
                    var readPort = Console.ReadLine();
                    connectPort = int.Parse( readPort );
                    isPort = true;
                } catch(Exception) {
                    // Exception!
                    Console.SetCursorPosition( 0, 2 );
                    Console.Write( "\r" + new string( ' ', Console.WindowWidth ) );
                }
            }
            if(connectIp != null) {
                var client = new TcpClient( connectIp.ToString(), connectPort );
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public static void Server() {
            var listener = TcpListener.Create(1337);
        }
        public static void Server(int port) {
            var listener = TcpListener.Create(port);
        }
    }
}
