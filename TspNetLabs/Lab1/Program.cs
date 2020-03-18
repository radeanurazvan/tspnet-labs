using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1.PrimeSearcher;

namespace Lab1
{
    public static class Program
    {
        private static readonly IEnumerable<IPrimeSearcherStrategy> strategies = new List<IPrimeSearcherStrategy>
        {
            new IterativePrimeSearcherStrategy(),
            new RandomPrimeSearcherStrategy()
        };

        public static async Task Main()
        {
            Logs.OnLogAppeared += (sender, log) => Console.WriteLine(log);

            //var tasks = strategies.Select(s => new PrimeSearcherWrapper(s))
            //    .Select(w => w.RunWithTap(100000));
            //await Task.WhenAll(tasks.ToArray());

            foreach (var strategy in strategies)
            {
                var wrapper = new PrimeSearcherWrapper(strategy);
                wrapper.RunWithThreads(10000);
            }
        }
    }
}
