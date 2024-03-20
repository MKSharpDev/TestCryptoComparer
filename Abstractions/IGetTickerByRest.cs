using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCryptoСomparer.Abstractions
{
    public interface IGetTickerByRest
    {
        public Task<string> GetTicketByRestAsync(string ticker, CancellationToken token);

    }
}
