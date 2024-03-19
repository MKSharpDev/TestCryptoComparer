using Binance.Net.Clients;
using Bitget.Net.Clients;
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
    public class BybitClient : CryptoExchClient, IGetTicker
    {

        public async Task<string> GetBTCByRestAsync()
        {
            return await GetBTCByRestV5ApiAsync("BTCUSDT");
        }

        public async Task<string> GetETHByRestAsync()
        {
            return await GetBTCByRestV5ApiAsync("ETHUSDT");
        }
    }
}
