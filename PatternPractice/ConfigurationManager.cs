using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Configuration.ConfigurationSettings;

namespace PatternPractice
{
    public static class ConfigManager
    {
        public static string MethodFactoryKey=> AppSettings["FactoryMethod"];
        public static string AbstractFactoryKey => AppSettings["AbstractFactory"];
    }
}
