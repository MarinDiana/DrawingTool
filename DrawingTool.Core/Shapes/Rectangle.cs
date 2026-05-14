using DrawingTool.Core.Interfaces;
using DrawingTool.Core.Models;

namespace DrawingTool.Core.Shapes
{
    public class Rectangle : IShape
    {
        private double _x;
        private double _y;
        private double _width;
        private double _height;

        public Rectangle(
            double x,
            double y,
            double width,
            double height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }

        public void Draw(ICanvas canvas)
        {
            canvas.DrawRect(
                _x,
                _y,
                _width,
                _height);
        }

        public void Move(double dx, double dy)
        {
            _x += dx;
            _y += dy;
        }

        public void Scale(double factor)
        {
            _width *= factor;
            _height *= factor;
        }

        public BoundingBox GetBoundingBox()
        {
            return new BoundingBox(
                _x,
                _y,
                _width,
                _height
            );
        }
    }
}