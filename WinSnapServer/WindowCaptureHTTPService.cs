using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WinSnapServer
{
    public class WindowCaptureHTTPService
    {
        public HttpListener listener;
        public const string httpPort = "7777";
        public string url = "http://+:" + httpPort + "/";
        public int requestCount = 0;
        

        public string indexPage =
            "<!DOCTYPE>" +
            "<html>" +
            "  <head>" +
            "    <meta http-equiv=\"refresh\" content=\"30\">" +
            "    <title>Screencast</title>" +
            "  </head>" +
            "  <body style=\" margin: 0px; \">" +
            "    <img src=\"\\image\" width=\"100%\" height=\"100%\" >" +    
            "  </body>" +
            "</html>";

        private WindowSelectorForm gui;

        public WindowCaptureHTTPService(WindowSelectorForm form)
        {
            gui = form;
            // Create a Http server and start listening for incoming connections
            listener = new HttpListener();
            listener.Prefixes.Add(url);
            listener.Start();
            Console.WriteLine("Listening for connections on {0}", url);
            gui.ServiceURL = "http://" + GetLocalIPAddress() + ":" + httpPort + "/";

            // Handle requests
            Task listenTask = HandleIncomingConnections();
        }
        ~WindowCaptureHTTPService()
        {
            listener.Close();
        }

        public async Task HandleIncomingConnections()
        {
            bool runServer = true;

            // While a user hasn't visited the `shutdown` url, keep on handling requests
            while (runServer)
            {
                // Will wait here until we hear from a connection
                HttpListenerContext ctx = await listener.GetContextAsync();

                // Peel out the requests and response objects
                HttpListenerRequest req = ctx.Request;
                HttpListenerResponse resp = ctx.Response;

                gui.ClientIP = req.RemoteEndPoint.Address.ToString();

                // Print out some info about the request
                Console.WriteLine("Request #: {0}", ++requestCount);
                Console.WriteLine(req.Url.ToString());
                Console.WriteLine(req.HttpMethod);
                Console.WriteLine(req.UserHostName);
                Console.WriteLine(req.UserAgent);
                Console.WriteLine(req.RemoteEndPoint.Address.ToString());
                Console.WriteLine();

                gui.RequestCount = requestCount.ToString();

                byte[] data;

                if ((req.HttpMethod == "GET") && (req.Url.AbsolutePath == "/image"))
                {
                    Console.WriteLine("Image requested");
                    WindowSnap snap = WindowSnap.GetWindowSnap(WindowSelectorForm.hSelectedWnd, true);
                    if (snap.Image != null)
                    {
                        MemoryStream memStream = new MemoryStream(10000);
                        snap.Image.Save(memStream, System.Drawing.Imaging.ImageFormat.Png);
                        data = memStream.GetBuffer();
                        resp.ContentType = "image/png";
                        //resp.ContentEncoding = Encoding.UTF8;
                        resp.ContentLength64 = data.LongLength;

                        // Write out to the response stream (asynchronously), then close it
                        await resp.OutputStream.WriteAsync(data, 0, data.Length);
                        resp.Close();
                        continue;
                    }
                }

                // If `shutdown` url requested w/ POST, then shutdown the server after serving the page
                if ((req.HttpMethod == "POST") && (req.Url.AbsolutePath == "/shutdown"))
                {
                    Console.WriteLine("Shutdown requested");
                    runServer = false;
                }

                // Write the response info
                data = Encoding.UTF8.GetBytes(indexPage);
                resp.ContentType = "text/html";
                resp.ContentEncoding = Encoding.UTF8;
                resp.ContentLength64 = data.LongLength;

                // Write out to the response stream (asynchronously), then close it
                await resp.OutputStream.WriteAsync(data, 0, data.Length);
                resp.Close();
            }
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork && ip.ToString().StartsWith("192.168.1."))
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }
}
