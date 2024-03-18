using Binance.Net.Clients;
using Bitget.Net.Clients;
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
    public class BitgetClient : IGetTickerByRest
    {
        private TextBox textBox;
        public BitgetClient(TextBox textBox) 
        { 
            this.textBox = textBox;
        }

        public async Task GetBTCByRestAsync()
        {
            var restClient = new BitgetRestClient();
            while (true)
            {
                var tickerResult = await restClient.SpotApi.ExchangeData.GetTickerAsync("BTCUSDT_SPBL");
                var lastPrice = tickerResult.Data.ClosePrice;

                textBox.Invoke(() => {
                    textBox.Clear();
                    textBox.AppendText(lastPrice.ToString());
                });
                Thread.Sleep(5000);
            }
        }
    }
}
