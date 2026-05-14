using DrawingTool.Core.Canvas;
using DrawingTool.Core.Shapes;

namespace DrawingTool.Tests
{
    [TestClass]
    public class BridgeTests
    {
        [TestMethod]
        public void SvgCanvas_DrawCircle_GeneratesSvgCircle()
        {
            SvgCanvas canvas = new SvgCanvas();

            Circle circle = new Circle(50, 50, 25);

            circle.Draw(canvas);

            string svg = canvas.GetSvg();

            Assert.IsTrue(svg.Contains("<circle"));
            Assert.IsTrue(svg.Contains("cx=\"50\""));
            Assert.IsTrue(svg.Contains("cy=\"50\""));
            Assert.IsTrue(svg.Contains("r=\"25\""));
        }

        [TestMethod]
        public void SvgCanvas_DrawRectangle_GeneratesSvgRect()
        {
            SvgCanvas canvas = new SvgCanvas();

            Rectangle rectangle = new Rectangle(10, 20, 100, 50);

            rectangle.Draw(canvas);

            string svg = canvas.GetSvg();

            Assert.IsTrue(svg.Contains("<rect"));
            Assert.IsTrue(svg.Contains("x=\"10\""));
            Assert.IsTrue(svg.Contains("y=\"20\""));
            Assert.IsTrue(svg.Contains("width=\"100\""));
            Assert.IsTrue(svg.Contains("height=\"50\""));
        }
    }
}