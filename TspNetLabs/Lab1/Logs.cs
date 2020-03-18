using System;
using System.Collections.Generic;

namespace Lab1
{
    public static class Logs
    {
        private static ICollection<string> logs = new List<string>();

        public static event EventHandler<string> OnLogAppeared;

        public static void Add(string log)
        {
            logs.Add(log);
            OnLogAppeared?.Invoke(null, log);
        }
    }
}