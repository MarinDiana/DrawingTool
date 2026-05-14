using DrawingTool.Core.Interfaces;
using DrawingTool.Core.Models;

namespace DrawingTool.Core.Shapes
{
    public class Ellipse : IShape
    {
        private double _x;
        private double _y;
        private double _radiusX;
        private double _radiusY;

        public Ellipse(
            double x,
            double y,
            double radiusX,
            double radiusY)
        {
            _x = x;
            _y = y;
            _radiusX = radiusX;
            _radiusY = radiusY;
        }

        public void Draw(ICanvas canvas)
        {
            canvas.DrawEllipse(
                _x,
                _y,
                _radiusX,
                _radiusY);
        }

        public void Move(double dx, double dy)
        {
            _x += dx;
            _y += dy;
        }

        public void Scale(double factor)
        {
            _radiusX *= factor;
            _radiusY *= factor;
        }

        public BoundingBox GetBoundingBox()
        {
            return new BoundingBox(
                _x - _radiusX,
                _y - _radiusY,
                _radiusX * 2,
                _radiusY * 2
            );
        }
    }
}