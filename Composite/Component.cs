using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Component
    {
        protected int num;

        public Component(int number)
        {
            this.num = number;
        }

        public abstract void AddChild(Component c);

        public abstract void RemoveChild(Component c);

        public abstract IList<Component> GetChilds();

        public abstract void Draw(string space);

        public abstract int Sum();

        public int GetNum()
        {
            return this.num;
        }
    }
}
