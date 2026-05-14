using DrawingTool.Core.Interfaces;

namespace DrawingTool.Core.Canvas
{
    public class ConsoleCanvas : ICanvas
    {
        public void DrawLine(
            double x1,
            double y1,
            double x2,
            double y2)
        {
            Console.WriteLine(
                $"Line ({x1}, {y1}) -> ({x2}, {y2})");
        }

        public void DrawCircle(
            double cx,
            double cy,
            double r)
        {
            Console.WriteLine(
                $"Circle centru ({cx}, {cy}) raza {r}");
        }

        public void DrawRect(
            double x,
            double y,
            double w,
            double h)
        {
            Console.WriteLine(
                $"Rectangle ({x}, {y}) {w}x{h}");
        }

        public void DrawEllipse(
            double cx,
            double cy,
            double rx,
            double ry)
        {
            Console.WriteLine(
                $"Ellipse centru ({cx}, {cy}) raze {rx}, {ry}");
        }
    }
}