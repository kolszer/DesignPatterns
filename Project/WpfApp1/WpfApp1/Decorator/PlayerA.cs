using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp1.Decorator
{
    class PlayerA : Player
    {
        public override void Operation()
        {
            player.Fill = new SolidColorBrush(Colors.White);
        }
    }
}
