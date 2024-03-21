using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCryptoComparerClassLibrary.Abstractions
{
    public interface IGetTickerByRest
    {
        public Task<string> GetTicketByRestAsync(string ticker, CancellationToken token);

    }
}
