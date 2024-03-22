using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCryptoСomparerClassLibrary.Abstractions
{
    internal interface IGetTicker
    {
        public Task<string> BaseGetTicketByRestAsync(string ticker, CancellationToken token);

    }
}
