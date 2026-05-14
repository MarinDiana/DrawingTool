using DrawingTool.Core.Canvas;
using DrawingTool.Core.Composite;
using DrawingTool.Core.Shapes;
using System.IO;
using DrawingTool.Core.Proxy;

namespace DrawingTool.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleCanvas canvas =
                new ConsoleCanvas();

            Picture picture =
                new Picture();

            picture.Add(
                new Line(0, 0, 100, 100));

            picture.Add(
                new Circle(50, 50, 25));

            picture.Add(
                new Rectangle(10, 10, 40, 20));

            picture.Add(
                new Ellipse(80, 80, 30, 15));

            Console.WriteLine("=== DRAW ===");

            picture.Draw(canvas);

            Console.WriteLine();

            Console.WriteLine("=== MOVE ===");

            picture.Move(10, 20);

            picture.Draw(canvas);

            Console.WriteLine();

            Console.WriteLine("=== SCALE ===");

            picture.Scale(2);

            picture.Draw(canvas);

            Console.WriteLine();

            var box =
                picture.GetBoundingBox();

            Console.WriteLine(
                $"BoundingBox: X={box.X}, Y={box.Y}, Width={box.Width}, Height={box.Height}");

            Console.WriteLine();
            Console.WriteLine("=== SVG CANVAS ===");

            SvgCanvas svgCanvas =
                new SvgCanvas();

            picture.Draw(svgCanvas);

            File.WriteAllText(
                "desen.svg",
                svgCanvas.GetSvg());

            Console.WriteLine("Fisier SVG generat: desen.svg");

            Console.WriteLine();
            Console.WriteLine("=== PROXY READ ONLY ===");

            Circle lockedCircle =
                new Circle(30, 30, 10);

            ReadOnlyShapeProxy proxy =
                new ReadOnlyShapeProxy(lockedCircle);

            proxy.Draw(canvas);

            try
            {
                proxy.Move(10, 10);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}