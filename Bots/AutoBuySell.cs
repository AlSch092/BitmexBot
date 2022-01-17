using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using BitMEX;
using BitMexBot;

namespace BitMexBot.Bots
{
    class AutoBuySell
    {
        public static bool BuyOrSell;
        public static string Symbol;
        public static position CurrentPos = null;
        public static double ProfitTakePercent;
        public static bool BuyOrSellTrend;
        public static Account Acct;

        public static void AutoBuyOrSell()
        {
            //todo: check if position is already open on this symbol, if so dont buy/sell any.
            if (CurrentPos == null)
            {
                //Track price thread should be running for a bit by now to get trend        
                if (BuyOrSellTrend == true) //buy
                {
                    Transaction T = new Transaction();
                    T.MarketTransaction(Acct, 1000, "Buy", Symbol);
                }
                else //sell
                {
                    Transaction T = new Transaction();
                    T.MarketTransaction(Acct, 1000, "Sell", Symbol);
                }             
            }

            while(Acct.AutoTrading)
            {
                CurrentPos = position.GetOpenPosition(Acct, Symbol, 1, "liquidationPrice,avgEntryPrice,unrealisedPnl,realisedPnl,unrealisedPnlPcnt,unrealisedRoePcnt");

                if (CurrentPos == null)
                    continue;

                if(CurrentPos.unrealisedPnlPcnt >= ProfitTakePercent * 100)
                {
                    //market buy or sell
                    Console.WriteLine("Reached destination profit percentage! Market-ing out.");
                    Transaction T = new Transaction();

                    if(BuyOrSell == true)
                    {              
                        T.MarketTransaction(Acct, 1000, "Sell", Symbol);              
                    }
                    else
                    {
                        T.MarketTransaction(Acct, 1000, "Buy", Symbol); 
                    }

                }
                else
                {
                    Thread.Sleep(3000);
                }          
            }
            
        }
    }
}
