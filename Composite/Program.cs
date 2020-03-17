using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new Composite(0);
            Component leaf1 = new Leaf(1);
            Component leaf2 = new Leaf(2);
            Component leaf3 = new Leaf(3);
            root.AddChild(leaf1);
            root.AddChild(leaf2);
            root.AddChild(leaf3);

            Component c1 = new Composite(4);
            Component leaf5 = new Leaf(5);
            Component leaf6 = new Leaf(6);
            Component leaf7 = new Leaf(7);
            c1.AddChild(leaf5);
            c1.AddChild(leaf6);
            c1.AddChild(leaf7);

            root.AddChild(c1);

            Component c2 = new Composite(222);
            root.AddChild(c2);

            Component lastLeaf = new Leaf(2);
            root.AddChild(lastLeaf);

            Console.WriteLine($"root sum: {root.Sum()}");
            Console.WriteLine($"c1 sum: {c1.Sum()}");

            Console.WriteLine($"root: {CheckEven(root)}"); //false;
            Console.WriteLine($"c2: {CheckEven(c2)}"); //true;
        }

        static bool CheckEven(Component obj)
        {
            if (obj.GetNum() % 2 != 0)
                return false;

            if(obj.GetChilds() == null)//in case a leaf is last
            {
                if (obj.GetNum() % 2 != 0)
                    return false;
            }

            foreach(Component c in obj.GetChilds())
            {
                return CheckEven(c);
            }

            return true;
        }
    }
}
