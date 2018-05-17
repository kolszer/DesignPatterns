using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace WpfApp1.Boards
{
    public class FactoryBoards
    {
        private static FactoryBoards factory;

        private FactoryBoards() { }

        public static FactoryBoards getInstance()
        {
            if (factory == null)
                factory = new FactoryBoards();
            return factory;
        }

        public Window createWindow(string id, Shape p1, Shape p2)
        {
            if (id.ToUpper() == "RED")
                return new Red(p1, p2);
            else if (id.ToUpper() == "GREEN")
                return new Green(p1, p2);
            else if (id.ToUpper() == "BLUE")
                return new Blue(p1, p2);

            return null;
        }
    }
}
