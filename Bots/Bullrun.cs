using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitMEX;

namespace BitMexBot.Bots
{
    class Bullrun //Price tracker can call this if tons of buys are around
    {
        double MarkPrice;
        uint ExcessBuyOrdersQty;
        position TradePosition;
        Transaction Tx;

        public void TrackBullRun(string Symbol, int ContractQty) // FOMO market buy, track price until reaches % then sell market
        {
            


        }
    }
}
