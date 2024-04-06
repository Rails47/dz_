using System.Net.Sockets;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient("192.168.100.3", 8888);
            NetworkStream stream = client.GetStream();

            byte[] data = new byte[1024];
            int bytesRead = stream.Read(data, 0, data.Length);


            stream.Close();
            client.Close();
        }
    }
}
