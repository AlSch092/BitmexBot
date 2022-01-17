using BitMEX;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitMexBot
{
    public class liquidation
    {
        public string orderID { get; set; }
        public string symbol { get; set; }
        public string side { get; set; }
        public double price { get; set; }
        public int leavesQty { get; set; }

        public static double GetLiquidationPrice(Account A, string Symbol)
        {
            BitMEXApi bitmex = new BitMEXApi(A.APIKey, A.SecretKey);

            Dictionary<string, string> Params = new Dictionary<string, string>();
            Params.Add("symbol", Symbol);
            Params.Add("columns", "[\"lastValue\", \"liquidationPrice\"]");
            Params.Add("count", Convert.ToString(1));

            string TargetURI = "/position?filter=%7B%22symbol%22%3A%22" + Symbol + "%22%7D&columns=%5B%22avgEntryPrice%22%2C%20%22liquidationPrice%22%2C%20%22currentQty%22%5D&count=1";

            //clean this.            
            string Result = bitmex.Query("GET", TargetURI, null, true, false);

            try
            {
                liquidation lqdtn = JsonConvert.DeserializeObject<liquidation>(Result);
                return lqdtn.price;
            }
            catch
            {
                Console.WriteLine("Failed to get liquidation price.");
                return 0.0f;
            }         
        }


        public static bool PreventLiquidations(Account A, string Symbol, double BackoutPercent)
        {
            bool isTracking = true;

            while (isTracking)
            {
                BitMEXApi bitmex = new BitMEXApi(A.APIKey, A.SecretKey);

                Dictionary<string, string> Params = new Dictionary<string, string>();
                Params.Add("symbol", Symbol);
                Params.Add("columns", "[\"lastValue\", \"liquidationPrice\"]");
                Params.Add("count", Convert.ToString(1));

                string TargetURI = "/position?filter=%7B%22symbol%22%3A%22" + Symbol + "%22%7D&columns=%5B%22avgEntryPrice%22%2C%20%22liquidationPrice%22%2C%20%22currentQty%22%5D&count=1";

                //clean this.            
                string Result = bitmex.Query("GET", TargetURI, null, true, false);
                Console.WriteLine(Result);

                liquidation lqdtn = JsonConvert.DeserializeObject<liquidation>(Result);


                int LiqIndex = Result.IndexOf("liquidationPrice\":");
                string LiqSubstr = Result.Substring(LiqIndex + "liquidationPrice\":".Length, 6);
                double LiquidationPrice = Convert.ToDouble(LiqSubstr);
                Console.WriteLine("Liquidation: " + LiquidationPrice);

                int EntryIndex = Result.IndexOf("avgEntryPrice\":");
                string EntrySubstr = Result.Substring(EntryIndex + "avgEntryPrice\":".Length, 6);
                double EntryPrice = Convert.ToDouble(EntrySubstr);
                Console.WriteLine("Entry: " + EntryPrice);

                int MarkIndex = Result.IndexOf("markPrice\":");
                string MarkSubstr = Result.Substring(MarkIndex + "markPrice\":".Length, 6);
                double MarkPrice = Convert.ToDouble(MarkSubstr);
                Console.WriteLine("Mark: " + MarkPrice);

                int QuantityIndex = Result.IndexOf("currentQty\":");
                string QuantitySubstr = Result.Substring(QuantityIndex + "currentQty\":".Length, 6);
                QuantitySubstr = QuantitySubstr.Replace(",", "");
                int Quantity = Convert.ToInt32(QuantitySubstr);
                Console.WriteLine("Quantity: " + Quantity);


                bool isBackingOut = false;

                //calcaullate bsackout % price - ~60-70%
                if (EntryPrice > LiquidationPrice)//underwater long
                {
                    double Units = EntryPrice - LiquidationPrice;
                    if (EntryPrice > MarkPrice)
                    {
                        double Diff = EntryPrice - MarkPrice;
                        double Percentage = (Units - Diff) / Units;
                        Console.WriteLine("Percent: {0}", Percentage);

                        if (Percentage >= BackoutPercent)
                        {
                            //market sell asap
                        }
                    }
                }


                return true;
            }

            return true;
        }

    }
}
