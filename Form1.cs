using BitMEX;
using BitMexBot.Trades;
using BitMexBot.Position;
using BitMexBot.Bots;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;


namespace BitMexBot
{
    public partial class MainForm : Form
    {
        Account A = new Account();
        double xBt = 0;
        Thread TrackPriceThread;
        Thread UpdatePositionsThread;
        Thread AutoBuySellThread;
        Thread TrollboxLogThread;
        const double Satoshi = 0.00000001;
        double BeepPrice;

        public MainForm()
        {
           
            InitializeComponent();
        }

        private void UpdateGUI()
        {
            while(true)
            {
                var txt = this.comboBox_SelectedCurrency.Text;

                position Position = position.GetOpenPosition(A, this.comboBox_SelectedCurrency.Text, 1, "liquidationPrice,avgEntryPrice,unrealisedPnl,realisedPnl");

                try
                {
                    ListViewItem ListItem = new ListViewItem();
                    ListItem.Text = txt;
                    ListItem.Name = txt;
                    ListItem.SubItems.Add(Convert.ToString(Position.avgEntryPrice));
                    ListItem.SubItems.Add(Convert.ToString(Position.currentQty));
                    ListItem.SubItems.Add(Convert.ToString(Position.timestamp));

                    if (Position.openingQty > 0)
                    {
                        ListItem.SubItems.Add("Buy");
                    }
                    else
                    {
                        ListItem.SubItems.Add("Sell");
                    }

                    ListItem.SubItems.Add(Convert.ToString(Position.liquidationPrice));
                    ListItem.SubItems.Add(Convert.ToString(Position.unrealisedPnl * Satoshi));
                    ListItem.SubItems.Add(Convert.ToString(Position.realisedPnl * Satoshi));


                    if (!this.listView_Positions.Items.ContainsKey(txt))
                    {

                        listView_Positions.Items.Add(ListItem);
                    }
                    else
                    {
                        ListViewItem ListItemReplace = this.listView_Positions.Items[0];
                        ListItemReplace.SubItems.Clear();
                        ListItemReplace.Text = txt;
                        ListItemReplace.Name = txt;
                        ListItemReplace.SubItems.Add(Convert.ToString(Position.avgEntryPrice));
                        ListItemReplace.SubItems.Add(Convert.ToString(Position.currentQty));
                        ListItemReplace.SubItems.Add(Convert.ToString(Position.timestamp));

                        if (Position.openingQty > 0)
                        {
                            ListItemReplace.SubItems.Add("Buy");
                        }
                        else
                        {
                            ListItemReplace.SubItems.Add("Sell");
                        }

                        ListItemReplace.SubItems.Add(Convert.ToString(Position.liquidationPrice));
                        ListItemReplace.SubItems.Add(Convert.ToString(Position.unrealisedPnl * Satoshi));
                        ListItemReplace.SubItems.Add(Convert.ToString(Position.realisedPnl * Satoshi));
                    }
                }
                catch
                {
                    Console.WriteLine("Failed to get entryPrice on updating position.");
                }


                Thread.Sleep(3000);
            }
        }

        private void button_GetRecentTrades_Click(object sender, EventArgs e)
        {
            RecentTrades trades = new RecentTrades();
            string Symbol = comboBox_SelectedCurrency.Text;
            trades.GetRecentTrades(A, Symbol);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transaction s = new Transaction();

            string Symbol = comboBox_SelectedCurrency.Text;
            double Price = Convert.ToDouble(numericUpDown_TransactionLimitPrice.Text);
            uint Quantity = Convert.ToUInt32(numericUpDown_TransactionQuantity.Text);
            double Leverage = Convert.ToDouble(numericUpDown_TransactionLeverage.Text);

            bool PostOnly = false;
           
            if(this.checkBox_TransactionPostOnly.Checked)
             PostOnly = true;
            
            s.LimitTransaction(A, PostOnly, Quantity, Transaction.OrderTypes.Limit, Price, Symbol, "Sell");
        }


        private void TrackPrice()
        {
            instrument I = new instrument();
            bool Tracking = true;
            double MarkPrice = I.GetInstrumentPrice(A, this.comboBox_SelectedCurrency.Text);
            int IncreaseCounter = 0;
            int DecreaseCounter = 0;

            Console.WriteLine("Starting Mark Price: " + MarkPrice + " - Getting price trend please wait 20-30s");

            while(Tracking)
            {
                string Symbol = this.comboBox_SelectedCurrency.Text; //change to combobox
             
                double OldMarkPrice = MarkPrice;
                MarkPrice = I.GetInstrumentPrice(A, Symbol);     
               
                if(MarkPrice <= BeepPrice)
                {
                    for (int i = 0; i <= 300; i++ )
                    {
                        Console.Beep();
                        Thread.Sleep(500);
                    }                      
                }

                if(MarkPrice > OldMarkPrice) //increase
                    IncreaseCounter += 1;
                else if(MarkPrice < OldMarkPrice)           
                    DecreaseCounter += 1;
                
                if (IncreaseCounter >= 10 || DecreaseCounter >= 10)
                {
                    if(IncreaseCounter > DecreaseCounter)
                    {
                        Console.WriteLine("Trend Increasing.");

                        //write to file: csv for input to AI program
                        using (System.IO.StreamWriter file =
                            new System.IO.StreamWriter(@"BTC.csv", true))
                        {
                            file.WriteLine("{0},{1},{2},{3}", DateTime.Now, MarkPrice, "1", MarkPrice + 5);
                        }

                        DecreaseCounter = 0;
                        IncreaseCounter = 0;

                        AutoBuySell.BuyOrSellTrend = true;
                    }
                    else if (DecreaseCounter > IncreaseCounter)
                    {
             
                        using (System.IO.StreamWriter file =
                            new System.IO.StreamWriter(@"C:\Users\pello\OneDrive\Desktop\BTC.csv", true))
                        {
                            file.WriteLine("{0},{1},{2},{3}", DateTime.Now, MarkPrice, "0", MarkPrice - 5);
                        }
                        Console.WriteLine("Trend Decreasing");
                        AutoBuySell.BuyOrSellTrend = false;
                        DecreaseCounter = 0;
                        IncreaseCounter = 0;
                    }
                }

                Thread.Sleep(3000);


                DecreaseCounter = 0;
                IncreaseCounter = 0;
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //CheckForIllegalCrossThreadCalls = false;

            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("INITIALIZING CRAB-17... DIALING LORD BOG FOR ACCESS CONTROL...\n\n");
            //Console.WriteLine("BOY SMINEM CURRENTLY VISITING A MUSEUM WITH GRANDPARENTS. ACCESS APPROVED.\n");

            //A.FillAPIKeys("./Keys.txt");
            //Console.WriteLine(A.APIKey + " " +  A.SecretKey);
            double Satoshi = A.GetWalletBalance();
            Console.WriteLine(Satoshi);
            //Console.WriteLine("CRAB-17 WELCOMES YOU. PLEASE USE WISELY. \nALL CREDITS TO XIANLABS LTD: DEVLEOPED FOR LORDS BOGDANOFF.\n\n");

            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("Satoshi: " + Satoshi);
            //Console.WriteLine("XBT: " + (0.00000001 * Convert.ToDouble(Satoshi)));
            //this.xBt = (0.00000001 * Convert.ToDouble(Satoshi));
            //Console.WriteLine("Account: " + A.AccountId);
            //Console.WriteLine("Email: " + A.Email + " Readable name: " + A.ReadableName);
            //Console.ResetColor();

            //Console.WriteLine("\nGlobal recommended leverage for BTC, ETH: 10x or less depending on wallet size.");
            //Console.WriteLine("Shorting is usually recommended. Find a dumpy market (eth, btc, xrp)");

            //A.GetAccountDetails();
            //this.label_WalletBalance.Text = Convert.ToString("Wallet balance: " + A.walletBalance * 0.00000001);
            //this.label_UNPL.Text = Convert.ToString("UNPL: " + A.unrealisedPnl * 0.00000001);
            //this.label_AvailableBalance.Text = Convert.ToString("Available balance: " + A.excessMargin * 0.00000001);

        }

        private void button_GetAccountOrders_Click(object sender, EventArgs e)
        {
            Order s = new Order();

            string Symbol = comboBox_SelectedCurrency.Text;

            s.GetOrders(A, Symbol);
        }

        private void button_Long_Click(object sender, EventArgs e)
        {
            Transaction L = new Transaction();

            string Symbol = comboBox_SelectedCurrency.Text;
            double Price = Convert.ToDouble(numericUpDown_TransactionLimitPrice.Text);
            uint Quantity = Convert.ToUInt32(numericUpDown_TransactionQuantity.Text);
            double Leverage = Convert.ToDouble(numericUpDown_TransactionLeverage.Text);

            if (this.checkBox_TransactionPostOnly.Checked && this.checkBox_MarketOrder.Checked == false)
            { 
                L.LimitTransaction(A, true, Quantity, Transaction.OrderTypes.Limit, Price, Symbol, "Buy");
            }
            else if(this.checkBox_MarketOrder.Checked && this.checkBox_TransactionPostOnly.Checked == false)
            {
                L.MarketTransaction(A, Quantity, "Buy", Symbol);
            }
            else
            {
                MessageBox.Show("Please select either Post-Only or Market");
            }        
        }

        private void whoIsSnimenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("knowyourmeme.com");
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All credits go to XIAN LABS INC. Credits for REST API to BitMex.");
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You wish nub. HA.");
            MessageBox.Show("But srs. Kingpin#1068, looking for experienced traders + TA's.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BitMEXApi api = new BitMEXApi(A.APIKey, A.SecretKey);
            string result =  api.GetOrders(this.comboBox_SelectedCurrency.Text);
            Console.WriteLine(result);
        }

        private void button_SetLeverage_Click(object sender, EventArgs e)
        {
            leverage L = new leverage();
            L.ChangeLeverage(A, this.comboBox_SelectedCurrency.Text, Convert.ToDouble(this.numericUpDown_TransactionLeverage.Value));
        }

        private void button_GetTrollbox_Click(object sender, EventArgs e)
        {
            trollbox.GetTrollboxData(A, 1, 0);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            instrument inst = new instrument();
            inst.GetInstrumentPrice(A, this.comboBox_SelectedCurrency.Text);

        }

        private void checkBox_TrackPrice_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_TrackPrice.Checked == true)
            {
                TrackPriceThread = new Thread(new ThreadStart(this.TrackPrice));
                TrackPriceThread.Start();
            }
            else
            {
                TrackPriceThread.Abort();
            }
        }

        private void button_PostTrollbox_Click(object sender, EventArgs e)
        {
            string Txt = textBox_TrollboxText.Text;
            trollbox tb = new trollbox();
            tb.PostMessage(A, Txt);
        }

        private void button_GetPositions_Click(object sender, EventArgs e)
        {
            //get current positions. make thread and update gui

            position OpenPos = position.GetOpenPosition(A, this.comboBox_SelectedCurrency.Text, 1, "liquidationPrice,avgEntryPrice");
            if (OpenPos == null)
            {
                Console.WriteLine("GetOpenPositions failed.");
            }
            else
            {
                Console.WriteLine("GetOpenPositions succeeded.");
                Console.WriteLine(OpenPos.currency + " " + OpenPos.account + " " + OpenPos.avgEntryPrice + " " + OpenPos.symbol + " " + OpenPos.currentCost);

                if(UpdatePositionsThread == null)
                {
                    UpdatePositionsThread = new Thread(new ThreadStart(this.UpdateGUI));
                    UpdatePositionsThread.Start();
                }
            }
        }

        private void button_CancelAllOrders_Click(object sender, EventArgs e)
        {
            BitMEXApi api = new BitMEXApi(A.APIKey, A.SecretKey);
            api.DeleteOrder("test");
        }

        private void checkBox_AntiLiquidation_CheckedChanged(object sender, EventArgs e)
        {
            
            if (this.checkBox_AntiLiquidation.Checked == true)
            {
                //get current positions
                position OpenPos = position.GetOpenPosition(A, this.comboBox_SelectedCurrency.Text, 1, "liquidationPrice,avgEntryPrice");
                if (OpenPos == null)
                {
                    Console.WriteLine("GetOpenPositions failed.");
                    
                    //PreventLiqidationsThread.Start();
                }
                else
                {
                    Console.WriteLine("GetOpenPositions succeeded.");
                    Console.WriteLine(OpenPos.currency + " " + OpenPos.account + " " + OpenPos.bankruptPrice + " " + OpenPos.symbol + " " + OpenPos.currentCost);
                    liquidation.PreventLiquidations(this.A, this.comboBox_SelectedCurrency.Text, Convert.ToDouble(this.textBox_AntiLiquidation.Text));
                }
            }
            else
            {

            }

        }

        private void checkBox_TrackPrice_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_TrackPrice.Checked == true)
            {
                if(this.radioButton_Beep.Checked == true)
                {
                    BeepPrice = Convert.ToDouble(this.textBox_Beep.Text);
                }

                TrackPriceThread = new Thread(new ThreadStart(this.TrackPrice));
                TrackPriceThread.Start();
            }
            else
            {
                TrackPriceThread.Abort();
            }
        }

        private void checkBox_MarketOrder_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox_AutoPurchase_CheckedChanged_1(object sender, EventArgs e)
        {
            if(this.checkBox_AutoPurchase.Checked == true)
            {
                if(this.radioButton_Buy.Checked == true) //is buying
                {
                    AutoBuySell.BuyOrSell = true;
                }
                else if(this.radioButton_Sell.Checked == true)
                {
                    AutoBuySell.BuyOrSell = false;
                }
                
                AutoBuySell.Symbol = this.comboBox_SelectedCurrency.Text;

                try
                {
                    AutoBuySell.ProfitTakePercent = Convert.ToDouble(this.textBox_AutoBuySellProfit.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter a percentage in the profit taking box.");
                    AutoBuySell.ProfitTakePercent = 0.0f;
                }
                
                AutoBuySell.CurrentPos = position.GetOpenPosition(A, AutoBuySell.Symbol, 1, "liquidationPrice,avgEntryPrice,unrealisedPnl,realisedPnl,unrealisedPnlPcnt,unrealisedRoePcnt");

                A.AutoTrading = true;
                AutoBuySell.Acct = A;
                AutoBuySellThread = new Thread(new ThreadStart(AutoBuySell.AutoBuyOrSell));
                AutoBuySellThread.Start();
            }
            else
            {
                A.AutoTrading = false;
                AutoBuySellThread.Abort();
                AutoBuySellThread = null;
            }
        }

        public void LogChatsToFile()
        {
            string Filename = "chats.txt";
            string previousMsg = "";
            while (true)
            {
                string Msg = trollbox.GetTrollboxData(A, 1, 0);
                
                if(previousMsg.CompareTo(Msg) != 0)
                {
                    if (Msg != null)
                    {
                        previousMsg = Msg;
                        //write to file: csv for input to AI program
                        using (System.IO.StreamWriter file =
                        new System.IO.StreamWriter(Filename, true))
                        {
                            file.WriteLine("{0}", Msg);
                            file.Close();
                        }
                    }
                }

                Thread.Sleep(3000);
            }

        }

        private void checkBox_LogChats_CheckedChanged(object sender, EventArgs e)
        {
            if(this.checkBox_LogChats.Checked == true)
            {
                TrollboxLogThread = new Thread(new ThreadStart(this.LogChatsToFile));
                TrollboxLogThread.Start();
            }
            else
            {
                TrollboxLogThread.Abort();
            }
        }
    }
}
