using System;
using System.IO;
using System.Net.Sockets;

namespace OPG3TCPCLIENT
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World it is client!");
            Console.ReadLine();


            TcpClient clientSocket = new TcpClient("localhost", 7000);


            Stream ns = clientSocket.GetStream();  //provides a Stream
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true; // enable automatic flushing

            string message = Console.ReadLine();
            sw.WriteLine(message);
            string serverAnswer = sr.ReadLine();
            Console.WriteLine("Server: " + serverAnswer);

            ns.Close();

            clientSocket.Close();
        }
    }

}
