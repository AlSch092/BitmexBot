using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitMEX;
using BitMexBot;
using Newtonsoft.Json;
using System.Reflection;

namespace BitMexBot
{
    public class orderBook
    {
        public string URL = "https://www.bitmex.com/api/bitcoincharts/";

        public string symbol { get; set; }
        public int id { get; set; }
        public string side { get; set; }
        public int size { get; set; }
        public int price { get; set; }

        public List<Dictionary<double,int>> bids = new List<Dictionary<double,int>>();
        public List<Dictionary<double,int>> asks = new List<Dictionary<double,int>>();

        public double GetOrderBook(Account A, string CurrencyType) //use XBT, ETH, etc, not ETHUSD.
        {
            double AveragePrice = 0.0f;
            int count = 0;

            try
            {
               BitMEXApi bitmex = new BitMEXApi(A.APIKey, A.SecretKey);

               string trades = bitmex.QueryNonv1("GET", URL + CurrencyType + "/orderbook", null, false, false);
                //split into array or orderBook classes and deserialize each


               trades = JsonHelper.FormatJson(trades);
               trades = trades.Remove(trades.IndexOf("\"asks\":"));
               trades = trades + "}";
               Console.WriteLine(trades);

               bids = JsonConvert.DeserializeObject<List<Dictionary<double, int>>>(trades);               
            }
            catch
            {
                Console.WriteLine("End of book or error. If shown orders, no error");
                return AveragePrice / count;
            }

            return AveragePrice / count;
        }
    }
}
