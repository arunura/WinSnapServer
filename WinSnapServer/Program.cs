using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace WinSnapServer
{
    static class Program
    {

        private static Timer wakeUpTimer;
        private static int seqConfirmed = 1;
        private static WindowSelectorForm windowSelectorForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            windowSelectorForm = new WindowSelectorForm();
            var screenService = new WindowCaptureHTTPService(windowSelectorForm);
            InitializeTabletWakeupRoutine();
            Application.Run(windowSelectorForm);
        }

        static void WakeUpClient(object sender, EventArgs e)
        {
            if (windowSelectorForm.ClientIP != null)
            {
                Console.WriteLine("Executing timed tablet wake up call.");
                try
                {
                    SendCharToClient("C65");
                    System.Threading.Thread.Sleep(500);
                    SendCharToClient("D8");
                    SendCharToClient("U8");
                    SendCharToClient("D8");
                    SendCharToClient("U8");
                }
                catch (Exception ex)
                {
                    //Do nothing
                }
            }
        }

        static void SendCharToClient(string character)
        {
            string url = "http://" + windowSelectorForm.ClientIP + ":7777/key?" + seqConfirmed + "," + character + ",";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();
            var responseReader = new StreamReader(webStream);
            var response = responseReader.ReadToEnd();
            responseReader.Close();

            Console.WriteLine("Response: " + response);
            seqConfirmed++;
            windowSelectorForm.WakeupReqCount += 1;

            if ("multi".Equals(response.Trim()))
                ResetSeqConfirmed();
        }

        static void ResetSeqConfirmed()
        {
            string url = "http://"+ windowSelectorForm.ClientIP + ":7777/";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();
            var responseReader = new StreamReader(webStream);
            while (!responseReader.EndOfStream)
            {
                var responseLine = responseReader.ReadLine();
                if (responseLine.Contains("seqConfirmed ="))
                {
                    seqConfirmed = int.Parse(responseLine.Split(' ')[6].Trim(new char[] { ';' }));
                    break;
                }
            }
            windowSelectorForm.WakeupReqCount += 1;
        }

        static void InitializeTabletWakeupRoutine()
        {
            SetAllowUnsafeHeaderParsing();
            try
            {
                //ResetSeqConfirmed();

                wakeUpTimer = new Timer();
                wakeUpTimer.Tick += new EventHandler(WakeUpClient);
                wakeUpTimer.Interval = 1000 * 60; // 1 min
                wakeUpTimer.Start();

            }
            catch(Exception ex)
            {

            }

        }

        public static bool SetAllowUnsafeHeaderParsing()
        {
            //Get the assembly that contains the internal class
            Assembly aNetAssembly = Assembly.GetAssembly(typeof(System.Net.Configuration.SettingsSection));
            if (aNetAssembly != null)
            {
                //Use the assembly in order to get the internal type for the internal class
                Type aSettingsType = aNetAssembly.GetType("System.Net.Configuration.SettingsSectionInternal");
                if (aSettingsType != null)
                {
                    //Use the internal static property to get an instance of the internal settings class.
                    //If the static instance isn't created allready the property will create it for us.
                    object anInstance = aSettingsType.InvokeMember("Section",
                      BindingFlags.Static | BindingFlags.GetProperty | BindingFlags.NonPublic, null, null, new object[] { });

                    if (anInstance != null)
                    {
                        //Locate the private bool field that tells the framework is unsafe header parsing should be allowed or not
                        FieldInfo aUseUnsafeHeaderParsing = aSettingsType.GetField("useUnsafeHeaderParsing", BindingFlags.NonPublic | BindingFlags.Instance);
                        if (aUseUnsafeHeaderParsing != null)
                        {
                            aUseUnsafeHeaderParsing.SetValue(anInstance, true);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}