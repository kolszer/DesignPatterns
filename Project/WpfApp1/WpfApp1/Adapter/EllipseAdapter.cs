using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace WpfApp1.Adapter
{
    class EllipseAdapter
    {
        public Shape toSquare(Shape shape)
        {
            var result = new Rectangle();
            result.Fill = shape.Fill;
            result.Stroke = shape.Stroke;
            double maxSize = (shape.Width > shape.Height) ? shape.Width : shape.Height;
            result.Width = maxSize;
            result.Height = maxSize;

            return result;
        }
    }
}
