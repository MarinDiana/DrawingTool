using System.Text;
using DrawingTool.Core.Interfaces;

namespace DrawingTool.Core.Canvas
{
    public class SvgCanvas : ICanvas
    {
        private readonly StringBuilder _svg =
            new StringBuilder();

        public void DrawLine(
            double x1,
            double y1,
            double x2,
            double y2)
        {
            _svg.AppendLine(
                $"<line x1=\"{x1}\" y1=\"{y1}\" x2=\"{x2}\" y2=\"{y2}\" stroke=\"black\" />");
        }

        public void DrawCircle(
            double cx,
            double cy,
            double r)
        {
            _svg.AppendLine(
                $"<circle cx=\"{cx}\" cy=\"{cy}\" r=\"{r}\" stroke=\"black\" fill=\"none\" />");
        }

        public void DrawRect(
            double x,
            double y,
            double w,
            double h)
        {
            _svg.AppendLine(
                $"<rect x=\"{x}\" y=\"{y}\" width=\"{w}\" height=\"{h}\" stroke=\"black\" fill=\"none\" />");
        }

        public void DrawEllipse(
            double cx,
            double cy,
            double rx,
            double ry)
        {
            _svg.AppendLine(
                $"<ellipse cx=\"{cx}\" cy=\"{cy}\" rx=\"{rx}\" ry=\"{ry}\" stroke=\"black\" fill=\"none\" />");
        }

        public string GetSvg()
        {
            return
                "<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"500\" height=\"500\">\n"
                + _svg.ToString()
                + "</svg>";
        }
    }
}