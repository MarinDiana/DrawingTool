using DrawingTool.Core.Interfaces;
using DrawingTool.Core.Models;

namespace DrawingTool.Core.Shapes
{
    public class Line : IShape
    {
        private double _x1;
        private double _y1;
        private double _x2;
        private double _y2;

        public Line(double x1, double y1, double x2, double y2)
        {
            _x1 = x1;
            _y1 = y1;
            _x2 = x2;
            _y2 = y2;
        }

        public void Draw(ICanvas canvas)
        {
            canvas.DrawLine(
                _x1,
                _y1,
                _x2,
                _y2);
        }

        public void Move(double dx, double dy)
        {
            _x1 += dx;
            _y1 += dy;
            _x2 += dx;
            _y2 += dy;
        }

        public void Scale(double factor)
        {
            _x1 *= factor;
            _y1 *= factor;
            _x2 *= factor;
            _y2 *= factor;
        }

        public BoundingBox GetBoundingBox()
        {
            double x = Math.Min(_x1, _x2);
            double y = Math.Min(_y1, _y2);
            double width = Math.Abs(_x2 - _x1);
            double height = Math.Abs(_y2 - _y1);

            return new BoundingBox(x, y, width, height);
        }
    }
}