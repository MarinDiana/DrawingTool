using DrawingTool.Core.Composite;
using DrawingTool.Core.Shapes;

namespace DrawingTool.Tests
{
    [TestClass]
    public class CompositeTests
    {
        [TestMethod]
        public void Picture_Scale_DoublesAllDimensions()
        {
            Picture picture = new Picture();

            Rectangle rectangle = new Rectangle(10, 10, 40, 20);
            Circle circle = new Circle(50, 50, 10);

            picture.Add(rectangle);
            picture.Add(circle);

            picture.Scale(2.0);

            var box = picture.GetBoundingBox();

            Assert.AreEqual(10, box.X);
            Assert.AreEqual(10, box.Y);
            Assert.AreEqual(80, box.Width);
            Assert.AreEqual(60, box.Height);
        }

        [TestMethod]
        public void Picture_GetBoundingBox_ReturnsCorrectBox()
        {
            Picture picture = new Picture();

            picture.Add(new Rectangle(10, 10, 40, 20));
            picture.Add(new Circle(100, 100, 10));

            var box = picture.GetBoundingBox();

            Assert.AreEqual(10, box.X);
            Assert.AreEqual(10, box.Y);
            Assert.AreEqual(100, box.Width);
            Assert.AreEqual(100, box.Height);
        }
    }
}