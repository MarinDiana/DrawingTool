using DrawingTool.Core.Interfaces;
using DrawingTool.Core.Models;

namespace DrawingTool.Core.Proxy
{
    public class ReadOnlyShapeProxy : IShape
    {
        private readonly IShape _shape;

        public ReadOnlyShapeProxy(IShape shape)
        {
            _shape = shape;
        }

        public void Draw(ICanvas canvas)
        {
            _shape.Draw(canvas);
        }

        public void Move(double dx, double dy)
        {
            throw new InvalidOperationException("Shape is locked");
        }

        public void Scale(double factor)
        {
            throw new InvalidOperationException("Shape is locked");
        }

        public BoundingBox GetBoundingBox()
        {
            return _shape.GetBoundingBox();
        }
    }
}