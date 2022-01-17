using BitMEX;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BitMexBot
{
    public class trollbox
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string user { get; set; }
        public string message { get; set; }
        public string html { get; set; }
        public bool fromBot { get; set; }
        public int channelID { get; set; }   

        public static string GetTrollboxData(Account A, int count, int channelID)
        {
            BitMEXApi api = new BitMEXApi(A.APIKey, A.SecretKey);
            string TargetURI = "/api/v1/chat?count=";
            TargetURI += count;
            TargetURI += "&reverse=true";

            string Result = api.QueryNonv1("GET", TargetURI, null, true, false);

            try
            {
                Result = Result.Remove(0, 1);
                Result = Result.Remove(Result.Length - 1, 1);
                trollbox tb = JsonConvert.DeserializeObject<trollbox>(Result);

                Console.WriteLine(tb.date + " - " + tb.user + ": " + tb.message);

                return tb.user + ": " + tb.message;
            }
            catch
            {
                Console.WriteLine("Failed to get trollbox chat.");
                return null;
            }
        }

        public bool PostMessage(Account A, string msg)
        {
            BitMEXApi Api = new BitMEXApi(A.APIKey, A.SecretKey);

            Dictionary<string, string> Params = new Dictionary<string, string>();
            Params.Add("channelID", "1");
            Params.Add("message", msg);
            string Result = Api.Query("POST", "/chat", Params, true, false);
            Console.WriteLine(Result);

            return true;
        }

        
    }
}
