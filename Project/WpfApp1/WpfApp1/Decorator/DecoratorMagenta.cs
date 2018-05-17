using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp1.Decorator
{
    class DecoratorMagenta : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            component.player.Stroke = new SolidColorBrush(Colors.Magenta);
        }
    }
}
