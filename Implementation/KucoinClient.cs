using Binance.Net.Clients;
using Kucoin.Net.Clients;
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
    public class KucoinClient : IGetTickerByRest
    {
        private TextBox textBox;
        public KucoinClient(TextBox textBox) 
        { 
            this.textBox = textBox;
        }

        public async Task GetBTCByRestAsync(CancellationToken token)
        {
            var restClient = new KucoinRestClient();
            while (!token.IsCancellationRequested)
            {
                var tickerResult = await restClient.SpotApi.ExchangeData.GetTickerAsync("BTC-USDT");
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
