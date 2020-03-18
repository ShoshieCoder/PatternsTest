using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /// <summary>
    /// Container which has children
    /// </summary>
    public class Composite : Component
    {

        private IList<Component> childs = new List<Component>();

        public Composite(int number) : base(number)
        {
        }

        public override void AddChild(Component c)
        {
            childs.Add(c);
        }

        public override IList<Component> GetChilds()
        {
            return childs;
        }

        public override void RemoveChild(Component c)
        {
            childs.Remove(c);
        }

        public override void Draw(string space)
        {
            Console.WriteLine(space + this.num);

            foreach (Component c in childs)
            {
                c.Draw(space + "    ");
            }
        }

        public override int Sum()
        {
            int sum = this.GetNum();
            foreach(Component c in childs)
            {
                sum += c.Sum();
            }
            return sum;
        }
    }
}
