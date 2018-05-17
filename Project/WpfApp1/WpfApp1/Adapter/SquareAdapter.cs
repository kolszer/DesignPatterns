using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace WpfApp1.Adapter
{
    class SquareAdapter
    {
        public Shape toEllipse(Shape shape)
        {
            var result = new Ellipse();
            result.Fill = shape.Fill;
            result.Stroke = shape.Stroke;
            double maxSize = (shape.Width > shape.Height) ? shape.Width : shape.Height;
            result.Width = maxSize;
            result.Height = maxSize;

            return result;
        }
    }
}
