using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.Decorator.Document
{
    public abstract class Document
    {
        abstract public void Display();
    }

    public class PurchaseRequest : Document
    {
        public override void Display()
        {
            Console.WriteLine("PurchaseRequest document");
        }
    }

    public class LeaveRequest : Document
    {
        public override void Display()
        {
            Console.WriteLine("LeaveRequest document");
        }
    }

    public abstract class Decorator : Document
    {
        private readonly Document document;

        protected Decorator(Document document)
        {
            this.document = document;
        }

        public override void Display()
        {
            this.document.Display();
        }
    }

    public class ApproverDecorator : Decorator
    {
        public ApproverDecorator(Document document) : base(document)
        {
            Console.WriteLine("Add approve feature");
        }
        //This class didn't implement the base Display method.
        public void Approver()
        {
            Console.WriteLine("Approve");
        }
    }

    public class DeleterDecorator : Decorator
    {
        public DeleterDecorator(Document document) : base(document)
        {
            Console.WriteLine("Add delete feature");
        }

        public void Deleter()
        {
            Console.WriteLine("Delete");
        }
    }
    [Description("透明与半透明Decorator")]
    class App
    {
        //如果newDoc也使用Document类型来定义，将导致客户端无法调用新增业务方法approve()，因为在抽象构件类Document中没有对approve()方法的声明。也就是说，在客户端无法统一对待装饰之前的具体构件对象和装饰之后的构件对象。
        //在实际使用过程中，由于新增行为可能需要单独调用，因此这种形式的装饰模式也经常出现，这种装饰模式被称为半透明(Semi-transparent)装饰模式，而标准的装饰模式是透明(Transparent)装饰模式。下面我们对这两种装饰模式进行较为详细的介绍：
        //(1)透明装饰模式
        //在透明装饰模式中，要求客户端完全针对抽象编程，装饰模式的透明性要求客户端程序不应该将对象声明为具体构件类型或具体装饰类型，而应该全部声明为抽象构件类型。对于客户端而言，具体构件对象和具体装饰对象没有任何区别。
        //也就是应该使用如下代码：

        //Component c, c1; //使用抽象构件类型定义对象

        //c = new ConcreteComponent()；
        //c1 = new ConcreteDecorator(c)；

        // 而不应该使用如下代码：

        //ConcreteComponent c; //使用具体构件类型定义对象

        //c = new ConcreteComponent()；

        //  或
        //ConcreteDecorator c1; //使用具体装饰类型定义对象
        //c1 = new ConcreteDecorator(c)；

        //透明装饰模式，在客户端中的代码如下，全部使用抽象类来定义具体构件对象和具体装饰对象       

        //Component component, componentSB, componentBB; //全部使用抽象构件定义
        //component = new Window();
        //componentSB = new ScrollBarDecorator(component);
        //componentBB = new BlackBorderDecorator(componentSB);
        //componentBB.display();

        //透明装饰模式可以让客户端透明地使用装饰之前的对象和装饰之后的对象，无须关心它们的区别，此外，还可以对一个已装饰过的对象进行多次装饰，得到更为复杂、功能更为强大的对象。在实现透明装饰模式时，
        //要求具体装饰类的operation()方法覆盖抽象装饰类的operation()方法，除了调用原有对象的operation()外还需要调用新增的addedBehavior()方法来增加新行为，

        //(2)半透明装饰模式
        //透明装饰模式的设计难度较大，而且有时我们需要单独调用新增的业务方法。为了能够调用到新增方法，我们不得不用具体装饰类型来定义装饰之后的对象，而具体构件类型还是可以使用抽象构件类型来定义，
        //这种装饰模式即为半透明装饰模式，也就是说，对于客户端而言，具体构件类型无须关心，是透明的；但是具体装饰类型必须指定，这是不透明的。如本节前面所提到的文件对象功能增加实例，
        //为了能够调用到在Approver中新增方法approve()，客户端代码片段如下所示：

        //Document doc; //使用抽象构件类型定义
        //doc = new PurchaseRequest();
        //Approver newDoc; //使用具体装饰类型定义
        //newDoc = new Approver(doc);
        //半透明装饰模式可以给系统带来更多的灵活性，设计相对简单，使用起来也非常方便；但是其最大的缺点在于不能实现对同一个对象的多次装饰，而且客户端需要有区别地对待装饰之前的对象和装饰之后的对象。
        //在实现半透明的装饰模式时，我们只需在具体装饰类中增加一个独立的addedBehavior()方法来封装相应的业务处理，由于客户端使用具体装饰类型来定义装饰后的对象，因此可以单独调用addedBehavior()方法来扩展系统功能。

        static void Main()
        {
            Document doc;//抽象构件定义
            doc = new PurchaseRequest();
            ApproverDecorator adDoc;//具体装饰类来定义对象
            adDoc = new ApproverDecorator(doc);
            adDoc.Display();
            adDoc.Approver();
        }

        //装饰模式总结
        //装饰模式降低了系统的耦合度，可以动态增加或删除对象的职责，并使得需要装饰的具体构件类和具体装饰类可以独立变化，以便增加新的具体构件类和具体装饰类。在软件开发中，装饰模式应用较为广泛，
        //例如在JavaIO中的输入流和输出流的设计、javax.swing包中一些图形界面构件功能的增强等地方都运用了装饰模式。

        //1.主要优点
        //(1) 对于扩展一个对象的功能，装饰模式比继承更加灵活性，不会导致类的个数急剧增加。
        //(2) 可以通过一种动态的方式来扩展一个对象的功能，通过配置文件可以在运行时选择不同的具体装饰类，从而实现不同的行为。
        //(3) 可以对一个对象进行多次装饰，通过使用不同的具体装饰类以及这些装饰类的排列组合，可以创造出很多不同行为的组合，得到功能更为强大的对象。
        //(4) 具体构件类与具体装饰类可以独立变化，用户可以根据需要增加新的具体构件类和具体装饰类，原有类库代码无须改变，符合“开闭原则”。

        //2.主要缺点
        //(1) 使用装饰模式进行系统设计时将产生很多小对象，这些对象的区别在于它们之间相互连接的方式有所不同，而不是它们的类或者属性值有所不同，大量小对象的产生势必会占用更多的系统资源，在一定程序上影响程序的性能。
        //(2) 装饰模式提供了一种比继承更加灵活机动的解决方案，但同时也意味着比继承更加易于出错，排错也很困难，对于多次装饰的对象，调试时寻找错误可能需要逐级排查，较为繁琐。
        
        //3.适用场景
        //(1) 在不影响其他对象的情况下，以动态、透明的方式给单个对象添加职责。
        //(2) 当不能采用继承的方式对系统进行扩展或者采用继承不利于系统扩展和维护时可以使用装饰模式。不能采用继承的情况主要有两类：第一类是系统中存在大量独立的扩展，为支持每一种扩展或者扩展之间的组合将产生大量的子类，
        //使得子类数目呈爆炸性增长；第二类是因为类已定义为不能被继承（如Java语言中的final类）。
    }
}
