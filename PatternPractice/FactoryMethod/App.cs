using System;
using System.ComponentModel;

namespace PatternPractice.FactoryMethod
{[Description("2.Factory Method")]
    static class App
    {
        public static void Main()
        {

            Console.WriteLine("==============================");
            Console.WriteLine("===========Factory Method =====");
            Console.WriteLine("==============================");
            ILoggerFactory factory;
            ILogger logger;

            factory=new FileLoggerFactory();
            logger = factory.CreateLogger();
            logger.WriteLog();

            factory=new DatabaseLoggerFactory();
            logger = factory.CreateLogger();
            logger.WriteLog();

            Console.WriteLine("==============================");
            Console.WriteLine("===========Factory Method =====");
            Console.WriteLine("====Reflaction Create Factory==");
        
            //var ob=Type.GetType(typeof(DatabaseLoggerFactory).FullName);// as ILoggerFactory;
            var obj = Type.GetType(ConfigManager.MethodFactoryKey);
            if (obj == null) return;
            factory = Activator.CreateInstance(obj) as ILoggerFactory;

            if (factory == null) return;

            logger = factory.CreateLogger();
            logger.WriteLog();

//            1、假设你要反射一个 DLL 中的类，并且没有引用它（即未知的类型）： 
//             Assembly assembly = Assembly.LoadFile("程序集路径，不能是相对路径"); // 加载程序集（EXE 或 DLL） 
//            object obj = assembly.CreateInstance("类的完全限定名（即包括命名空间）"); // 创建类的实例 
//
//            2、若要反射当前项目中的类可以为：
//            Assembly assembly = Assembly.GetExecutingAssembly(); // 获取当前程序集 
//            object obj = assembly.CreateInstance("类的完全限定名（即包括命名空间）"); // 创建类的实例，返回为 object 类型，需要强制类型转换
//            3、也可以为：
//            Type type = Type.GetType("类的完全限定名");
//            object obj = type.Assembly.CreateInstance(type);
        }
    }
}