using System.Runtime.InteropServices.ComTypes;
using PatternPractice.AbstractFactory;
using static System.Configuration.ConfigurationSettings;

namespace PatternPractice
{
    public static class ConfigManager
    {
        public static string MethodFactoryKey=> AppSettings["FactoryMethod"];
        public static string AbstractFactoryKey => AppSettings["AbstractFactory"];
        public static string BuilderKey => AppSettings["Builder"];
        public static string AdapterKey => AppSettings["Adapter"];
       
    }
}
