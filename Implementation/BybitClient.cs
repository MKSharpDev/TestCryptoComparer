using Binance.Net.Clients;
using Bybit.Net.Clients;
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
    public class BybitClient : IGetTickerByRest
    {
        private TextBox textBox;
        public BybitClient(TextBox textBox) 
        { 
            this.textBox = textBox;
        }

        public async Task GetBTCByRestAsync(CancellationToken token)
        {
            var restClient = new BybitRestClient();

            while (!token.IsCancellationRequested)
            {
                var tickerResult = await restClient.V5Api.ExchangeData.GetSpotTickersAsync("BTCUSDT");
                var lastPrice = tickerResult.Data.List.First().LastPrice;

                textBox.Invoke(() => {
                    textBox.Clear();
                    textBox.AppendText(lastPrice.ToString());
                });

                Thread.Sleep(5000);
            }
        }
    }
}
