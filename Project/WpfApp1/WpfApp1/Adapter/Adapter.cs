using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace WpfApp1.Adapter
{
    class Adapter : EllipseAdapter
    {
        public Func<Shape, Shape> Request;

        public Adapter(EllipseAdapter ellipseAdapter)
        {
            Request = ellipseAdapter.toSquare;
        }

        public Adapter(SquareAdapter squareAdapter)
        {
            Request = squareAdapter.toEllipse;
        }

        public void ChangeRequest(Func<Shape, Shape> ff)
        {
            Request = ff;
        }
    }
}
