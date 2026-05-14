using DrawingTool.Core.Interfaces;
using DrawingTool.Core.Models;

namespace DrawingTool.Core.Shapes
{
    public class Circle : IShape
    {
        private double _x;
        private double _y;
        private double _radius;

        public Circle(double x, double y, double radius)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        public void Draw(ICanvas canvas)
        {
            canvas.DrawCircle(
                _x,
                _y,
                _radius);
        }

        public void Move(double dx, double dy)
        {
            _x += dx;
            _y += dy;
        }

        public void Scale(double factor)
        {
            _radius *= factor;
        }

        public BoundingBox GetBoundingBox()
        {
            return new BoundingBox(
                _x - _radius,
                _y - _radius,
                _radius * 2,
                _radius * 2
            );
        }
    }
}