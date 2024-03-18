using Binance.Net.Clients;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCryptoСomparer.Abstractions;
using static System.Net.Mime.MediaTypeNames;

namespace TestCryptoСomparer.Implementation
{
    public class BinanceClient: IGetTickerByRest
    {
        private TextBox textBox;
        public BinanceClient(TextBox textBox) 
        { 
            this.textBox = textBox;
        }

        public async Task GetBTCByRestAsync()
        {
            var restClient = new BinanceRestClient();
            while (true)
            {
                var tickerResult = await restClient.SpotApi.ExchangeData.GetTickerAsync("BTCUSDT");
                var lastPrice = tickerResult.Data.LastPrice;

                textBox.Invoke(() => {
                    textBox.Clear();
                    textBox.AppendText(lastPrice.ToString());
                });

                Thread.Sleep(5000);
            }
        }
    }
}
