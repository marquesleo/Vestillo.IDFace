using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vestillo.IDFace
{
    public static class LoggerInitializer
    {
        private static bool isConfigured = false;

        public static void ConfigureLogger()
        {
            if (!isConfigured)
            {
                Log.Logger = new LoggerConfiguration()
                    .MinimumLevel.Debug()
                    .WriteTo.File("logs\\log.txt", rollingInterval: RollingInterval.Day)
                    .CreateLogger();

                Log.Information("Logger configurado com sucesso.");
                isConfigured = true;
            }
        }
    }
}
