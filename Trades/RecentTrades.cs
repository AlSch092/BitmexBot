using BitMEX;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BitMexBot.Trades
{
    public class RecentTrades
    {
        public DateTime timestamp { get; set; }
        public string symbol { get; set; }
        public string side { get; set; }
        public int size { get; set; }
        public double price { get; set; }
        public string tickDirection { get; set; }
        public string trdMatchID { get; set; }
        public uint grossValue { get; set; }
        public double homeNotional { get; set; }
        public double foreignNotional { get; set; }


        public bool GetRecentTrades(Account A, string Symbol)
        {
            BitMEXApi bitmex = new BitMEXApi(A.APIKey, A.SecretKey);
            Dictionary<string, string> Params = new Dictionary<string, string>();
            Params.Add("count", "100");
            Params.Add("reverse", "true");
            Params.Add("symbol", Symbol);

            int TotalBuyQuantity = 0;
            int TotalSellQuantity = 0;
            int BuyQuantities = 0;
            int SellQuantities = 0;
            int PriceAlarmQuantity = 0;
            bool isPriceAlaramSellOrder = false;

            try
            {
                string trades = bitmex.Query("GET", "/trade", Params, true, false);
                trades = JsonHelper.FormatJson(trades);
                trades = trades.Remove(0, 1);

                string[] tradeList = trades.Split('}');

                foreach (string T in tradeList)
                {
                    string FormatTrade = T;

                    if (FormatTrade.Contains(']'))
                    {
                        FormatTrade.Remove(']');
                    }

                    FormatTrade = T + '}';

                    if (FormatTrade[0] == ',')
                    {
                        FormatTrade = FormatTrade.Remove(0, 1);
                    }

                    RecentTrades data = JsonConvert.DeserializeObject<RecentTrades>(FormatTrade);
                    Console.WriteLine("Price: " + data.price + ", " + "Quantity: " + data.size + ", " + "Symbol: " + data.symbol +  ", Buy/Sell: " + data.side + ", Timestamp: " + data.timestamp);

                    if(data.side == "Buy")
                        BuyQuantities += data.size;       
                    else if(data.side == "Sell")               
                        SellQuantities += data.size;       
                    
                    if(data.size >= 1000000)
                    {
                        if (data.side == "Buy")
                        {
                            PriceAlarmQuantity = data.size;
                            isPriceAlaramSellOrder = false;
                        }
                        else
                        {
                            isPriceAlaramSellOrder = true;
                            PriceAlarmQuantity = data.size;
                        }
                    }

                }

                
            }
            catch
            {

                Console.WriteLine("Finished Traversing Recent Trades.");
            }

            Console.WriteLine("Buys: {0}", TotalBuyQuantity);
            Console.WriteLine("Sells: {0}", TotalSellQuantity);
            Console.WriteLine("Total orderbook Buys: " + BuyQuantities + "(" + Symbol + ")" + "\nTotal Orderbook Sells: " + SellQuantities + "(" + Symbol + ")");
            
            int Delta = 0;

            if (BuyQuantities > SellQuantities)
            {
                Delta = BuyQuantities - SellQuantities;
                Console.WriteLine("Live order trend: Up. Buy vs. Sell Orders: {0} More Longs than Shorts - {1}", Delta, Symbol);
            }
            else if (SellQuantities > BuyQuantities)
            {
                Delta = SellQuantities - BuyQuantities;
                Console.WriteLine("Live order trend: Down. Buy vs. Sell: {0} More shorts than Longs - {1}", Delta, Symbol);
            }
             
            if(PriceAlarmQuantity > 0)
            {
                if(isPriceAlaramSellOrder)
                {
                    Console.WriteLine("Found large SELL order: {0}", PriceAlarmQuantity);
                }
                else
                {
                    Console.WriteLine("Found large BUY order: {0}. START THE BULLRUN!?!?", PriceAlarmQuantity);
                }
            }

            return true;
        }
    }
}
