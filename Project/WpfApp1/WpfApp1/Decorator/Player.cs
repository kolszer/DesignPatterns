using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace WpfApp1.Decorator
{
    abstract class Player
    {
        public Shape player { get; set; }

        public abstract void Operation();
    }
}
