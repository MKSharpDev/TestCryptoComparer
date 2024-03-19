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
    public class KucoinClient : CryptoExchClient, IGetTicker
    {
            public async Task<string> GetBTCByRestAsync()
            {
                return await GetTicketByRestAsync("BTC-USDT");
            }

            public async Task<string> GetETHByRestAsync()
            {
                return await GetTicketByRestAsync("ETH-USDT");
            }
    }
}
