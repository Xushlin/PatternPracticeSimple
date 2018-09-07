using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.Composite.Structure
{
    [Description("2.0.0 Composite structure.")]
    static class App
    {
        public static void Main()
        {
            Component root=new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Component composite=new Composite("Composite X");
            composite.Add(new Leaf("Composite XA"));
            composite.Add(new Leaf("Composite XB"));

            root.Add(composite);
            root.Add(new Leaf("Leaf C"));

            Component leaf=new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);
            
            root.Display(1);

            Console.ReadKey();
        }
    }
}
