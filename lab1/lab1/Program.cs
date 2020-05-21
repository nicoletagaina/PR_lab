using System;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Drawing.Imaging;

public class GetSocket
{
     public static void Main(string[] args)
     {
          string URL = "http://unite.md/", result = "", headers;
          int port =80;// portul 80
          

       

       Uri uri = new Uri(URL);
        string host = uri.Authority;
        string path = uri.Scheme + "://" + uri.Authority + uri.AbsolutePath;
        /* www.cyberforum.ru/csharp-beginners/thread1841234.html */
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        socket.Connect(host, port);

        

          if (socket.Connected)
          {
              headers =
               "GET " + path + " HTTP/1.1\r\n" +
               "Host: " + host + "\r\n" +
               "User-Agent: Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/54.0.2840.71 Safari/537.36\r\n" +
               "Connection: Close\r\n" +
               "Accept: */*\r\n" +
               "Accept-Language: ru-RU,ru;q=0.9,en;q=0.8\r\n\r\n"; 
            
            
            Byte[] bytesSent = Encoding.UTF8.GetBytes(headers);
            Byte[] bytesReceived = new Byte[1024];
               socket.Send(bytesSent, bytesSent.Length, 0);
               int bytes = 0;
          Label1:
               bytes = socket.Receive(bytesReceived, bytesReceived.Length, 0);
               result += Encoding.UTF8.GetString(bytesReceived, 0, bytes);
               if (bytes > 0)
               {
                    goto Label1;
               }
          }

         var str = Regex.Split(result, "\n");
          Regex regex = new Regex(@"/images/[^ ]*(.jpg|.png|.gif)+");
          Match coincid;
          int n = 0, k = 0;
          string urlImg;
          foreach (var item in str)
          {
               urlImg = "http://unite.md";
            coincid = regex.Match(str[n]);
               n++;
               if (coincid.Success)
               {
                    k++;
                    urlImg = urlImg + coincid.Value;
                    string nume = k.ToString();
                    nume = nume + ".png";
                    
                    SaveImage(nume, ImageFormat.Png, urlImg);
               }
          }
          
        Console.WriteLine("Descarcare este finisata");
            Console.WriteLine("Intrati bin - Debug  ");
        string a = Console.ReadLine();

           socket.Close();
           socket.Dispose();
        

    }


     public static void SaveImage(string salvare, ImageFormat f, string stringul)
     {
          WebClient client = new WebClient();
          Stream st = client.OpenRead(stringul);
          Bitmap bitmap; //prelucrarea imagiinilor
          bitmap = new Bitmap(st);

          if (bitmap != null)
          {
               bitmap.Save(salvare, f);
          }
 


     }
}
