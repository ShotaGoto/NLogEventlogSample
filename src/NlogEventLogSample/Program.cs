using NLog;
using System;

namespace NlogEventLogSample
{
    internal static class Program
    {
        private static Logger Logger = LogManager.GetCurrentClassLogger();

        private static void Main(string[] args)
        {
            try
            {
                Logger.Info("Hello World");
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
        }
    }
}