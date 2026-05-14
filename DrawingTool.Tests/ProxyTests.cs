using DrawingTool.Core.Canvas;
using DrawingTool.Core.Proxy;
using DrawingTool.Core.Shapes;

namespace DrawingTool.Tests
{
    [TestClass]
    public class ProxyTests
    {
        [TestMethod]
        public void ReadOnlyShapeProxy_Draw_DelegatesToShape()
        {
            SvgCanvas canvas = new SvgCanvas();

            Circle circle = new Circle(30, 30, 10);
            ReadOnlyShapeProxy proxy = new ReadOnlyShapeProxy(circle);

            proxy.Draw(canvas);

            string svg = canvas.GetSvg();

            Assert.IsTrue(svg.Contains("<circle"));
            Assert.IsTrue(svg.Contains("cx=\"30\""));
            Assert.IsTrue(svg.Contains("cy=\"30\""));
            Assert.IsTrue(svg.Contains("r=\"10\""));
        }

        [TestMethod]
        public void ReadOnlyShapeProxy_Move_ThrowsException()
        {
            Circle circle = new Circle(30, 30, 10);
            ReadOnlyShapeProxy proxy = new ReadOnlyShapeProxy(circle);

            Assert.ThrowsExactly<InvalidOperationException>(() =>
            {
                proxy.Move(10, 10);
            });
        }

        [TestMethod]
        public void ReadOnlyShapeProxy_Scale_ThrowsException()
        {
            Circle circle = new Circle(30, 30, 10);
            ReadOnlyShapeProxy proxy = new ReadOnlyShapeProxy(circle);

            Assert.ThrowsExactly<InvalidOperationException>(() =>
            {
                proxy.Scale(2);
            });
        }
    }
}