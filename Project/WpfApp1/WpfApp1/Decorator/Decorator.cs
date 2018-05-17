using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Decorator
{
    abstract class Decorator : Player
    {
        protected Player component;
        public void SetComponent(Player player)
        {
            component = player;
        }
        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }
}
