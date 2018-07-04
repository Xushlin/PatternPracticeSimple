using System;
using System.ComponentModel;

namespace PatternPractice.AbstractFactory
{
    [Description("3. Abstract Factory")]
    public static class App
    {
        public static void Main()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("========Abstract Factory =====");
            Console.WriteLine("====Create Spring Products====");
            Console.WriteLine("==============================");
            ISkinFactory factory;
            IButton button;
            ITextBox textBox;
            ILabel label;

            factory=new SpringSkinFactory();
            button = factory.CreateButton();
            button.Disply();

            textBox = factory.CreateTextBox();
            textBox.Display();

            label = factory.CreateLabel();
            label.Disply();
            
            Console.WriteLine("==============================");
            Console.WriteLine("========Abstract Factory =====");
            Console.WriteLine("====Create Spring Products====");
            Console.WriteLine("==============================");

            factory =new SummerSkinFactory();
            button=factory.CreateButton();
            button.Disply();

            textBox = factory.CreateTextBox();
            textBox.Display();

            label = factory.CreateLabel();
            label.Disply();
            
            Console.WriteLine("==============================");
            Console.WriteLine("=========Abstract Factory=====");
            Console.WriteLine("====Reflaction Create Factory==");
        
            //var ob=Type.GetType(typeof(DatabaseLoggerFactory).FullName);// as ILoggerFactory;
            Type obj = Type.GetType(ConfigManager.AbstractFactoryKey);
            if (obj == null) return;
            factory = obj.Assembly.CreateInstance(obj.FullName) as ISkinFactory;

            if (factory == null) return;

            button = factory.CreateButton();
            button.Disply();

            textBox = factory.CreateTextBox();
            textBox.Display();

            label = factory.CreateLabel();
            label.Disply();


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