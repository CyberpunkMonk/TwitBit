using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections.Generic;

namespace TwitBit {
    /// <summary>
    /// TESTING TWITCH IRC CONNECTIVITY
    /// </summary>
    class TEST {
        //private string _uName;
        public string Channel { get; set; }
        public string IP { get; set; }
        public int? Port { get; set; }
        private TcpClient _tcpClient { get; set; }
        private StreamReader _streamReader { get; set; }

        //private TcpClient _tcpClient;
        //private StreamReader _streamReader;

        //Do nothing constructor
        public TEST() {

        }

        public TEST(string IPParam, int portParam, string channelParam) {
            Channel=channelParam;
            IP=IPParam;
            Port=portParam;
            test();
        }

        public void test() {
            //Console.WriteLine($"Channel: {Channel}\nIP: {IP}\nPort: {Port}\n");
        }
    }
}