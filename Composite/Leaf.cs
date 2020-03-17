using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Leaf : Component
    {
        public Leaf(int number) : base(number)
        {
        }

        public override void AddChild(Component c)
        {
            throw new NotSupportedException("Leaf elemnt cannot add child!");
        }

        public override IList<Component> GetChilds()
        {
            return null;
        }

        public override void RemoveChild(Component c)
        {
            throw new NotSupportedException("Leaf elemnt cannot add child!");
        }

        public override int Sum()
        {
            return this.GetNum();  
        }

        public override void Draw(string space)
        {
            Console.WriteLine(space + this.num);
        }
    }
}
