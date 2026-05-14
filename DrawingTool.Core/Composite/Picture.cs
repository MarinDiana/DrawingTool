using DrawingTool.Core.Interfaces;
using DrawingTool.Core.Models;

namespace DrawingTool.Core.Composite
{
    public class Picture : IShape
    {
        private readonly List<IShape> _shapes =
            new List<IShape>();

        public void Add(IShape shape)
        {
            _shapes.Add(shape);
        }

        public void Remove(IShape shape)
        {
            _shapes.Remove(shape);
        }

        public void Draw(ICanvas canvas)
        {
            foreach (var shape in _shapes)
            {
                shape.Draw(canvas);
            }
        }

        public void Move(double dx, double dy)
        {
            foreach (var shape in _shapes)
            {
                shape.Move(dx, dy);
            }
        }

        public void Scale(double factor)
        {
            foreach (var shape in _shapes)
            {
                shape.Scale(factor);
            }
        }

        public BoundingBox GetBoundingBox()
        {
            if (_shapes.Count == 0)
            {
                return new BoundingBox(0, 0, 0, 0);
            }

            var first =
                _shapes[0].GetBoundingBox();

            double minX = first.X;
            double minY = first.Y;

            double maxX = first.X + first.Width;
            double maxY = first.Y + first.Height;

            foreach (var shape in _shapes)
            {
                var box = shape.GetBoundingBox();

                minX = Math.Min(minX, box.X);
                minY = Math.Min(minY, box.Y);

                maxX = Math.Max(
                    maxX,
                    box.X + box.Width);

                maxY = Math.Max(
                    maxY,
                    box.Y + box.Height);
            }

            return new BoundingBox(
                minX,
                minY,
                maxX - minX,
                maxY - minY
            );
        }
    }
}