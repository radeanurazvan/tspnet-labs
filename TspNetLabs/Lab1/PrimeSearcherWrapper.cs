using System;
using System.Threading;
using System.Threading.Tasks;
using Lab1.PrimeSearcher;

namespace Lab1
{
    public sealed class PrimeSearcherWrapper
    {
        public PrimeSearcherWrapper(IPrimeSearcherStrategy strategy)
        {
            Strategy = strategy;
        }

        public IPrimeSearcherStrategy Strategy { get; }

        public async Task RunWithTap(int number)
        {
            try
            {
                var startLog = $"Start TASK: {Name} la {TaskTimestamp}. Numar natural dat = {number}";
                Logs.Add(startLog);
                
                var result = await Task.Run(() => Strategy.SearchFor(number));
                var endLog = $"Terminare TASK: {Name} la {TaskTimestamp}. Numar prim = {result}";
                Logs.Add(endLog);
            }
            catch (Exception)
            {
                var errorLog = $"Iesire temporara TASK: {Name}";
                Logs.Add(errorLog);
            }
        }

        public void RunWithThreads(int number)
        {
            try
            {
                var startLog = $"Start THREAD: {Name} la {TaskTimestamp}. Numar natural dat = {number}";
                Logs.Add(startLog);

                var returnValue = 0;
                var thread = new Thread(() => { returnValue = Strategy.SearchFor(number);});
                thread.Start();
                thread.Join();

                var endLog = $"Terminare THREAD: {Name} la {TaskTimestamp}. Numar prim = {returnValue}";
                Logs.Add(endLog);
            }
            catch (Exception)
            {
                var errorLog = $"Iesire temporara THREAD: {Name}";
                Logs.Add(errorLog);
            }
        }

        private string Name => Strategy.GetType().Name;

        private string TaskTimestamp => $"{DateTime.Now:hh:mm:s:ms}";
    }
}