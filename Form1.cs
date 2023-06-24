using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometryFigure
{
    public partial class Form1 : Form
    {
        private Shape selectedShape;
        private List<Shape> shapes;

        public Form1()
        {
            InitializeComponent();
            shapes = new List<Shape>();
            drawingPanel.Paint += drawingPanel_Paint;
        }
        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            // Викликається при перерисуванні панелі
            foreach (Shape shape in shapes)
            {
                shape.Draw(e.Graphics);
            }

            if (selectedShape != null)
            {
                selectedShape.Draw(e.Graphics);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Викликається при перерисуванні форми
            if (selectedShape != null)
            {
                selectedShape.Draw(e.Graphics);
            }
        }

        private void circle_Click(object sender, EventArgs e)
        {
            // Створення нового кола
            int radius = int.Parse(txtCircleRadius.Text);
            int x = int.Parse(txtCircleX.Text);
            int y = int.Parse(txtCircleY.Text);
            Point position = new Point(x, y);

            selectedShape = new Circle(position, radius);
            shapes.Add(selectedShape);

            drawingPanel.Refresh();

        }

        private void square_Click(object sender, EventArgs e)
        {
            // Створення нового квадрата
            int sideLength = int.Parse(txtSquareSideLength.Text);
            int x = int.Parse(txtSquareX.Text);
            int y = int.Parse(txtSquareY.Text);
            Point position = new Point(x, y);

            selectedShape = new Square(position, sideLength);
            shapes.Add(selectedShape);

            drawingPanel.Refresh();
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            // Створення нового прямокутника
            int width = int.Parse(txtRectangleWidth.Text);
            int height = int.Parse(txtRectangleHeight.Text);
            int x = int.Parse(txtRectangleX.Text);
            int y = int.Parse(txtRectangleY.Text);
            Point position = new Point(x, y);

            selectedShape = new Rectangle(position, width, height);
            shapes.Add(selectedShape);

            drawingPanel.Refresh();
        }

        private void move_Click(object sender, EventArgs e)
        {
            int deltaX = int.Parse(txtMoveX.Text);
            int deltaY = int.Parse(txtMoveY.Text);

            if (selectedShape != null)
            {
                selectedShape.Move(deltaX, deltaY);
                Refresh();
            }
        }

        private void resize_Click(object sender, EventArgs e)
        {
            int width = int.Parse(txtResizeWidth.Text);
            int height = int.Parse(txtResizeHeight.Text);

            if (selectedShape != null)
            {
                selectedShape.Resize(width, height);
                Refresh();
            }
        }

        private void rotate_Click(object sender, EventArgs e)
        {
            float angle = float.Parse(txtRotateAngle.Text);

            if (selectedShape != null)
            {
                selectedShape.Rotate(angle);
                Refresh();
            }
        }

    }
    public abstract class Shape
    {
        public Point Position { get; set; }

        public abstract void Draw(Graphics graphics);
        public abstract void Move(int deltaX, int deltaY);
        public abstract void Resize(int width, int height);
        public abstract void Rotate(float angle);
    }

    // Клас для кола
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(Point position, int radius)
        {
            Position = position;
            Radius = radius;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(Pens.Black, Position.X - Radius, Position.Y - Radius, Radius * 2, Radius * 2);
        }

        public override void Move(int deltaX, int deltaY)
        {
            Position = new Point(Position.X + deltaX, Position.Y + deltaY);
        }

        public override void Resize(int width, int height)
        {
            throw new NotSupportedException("Cannot resize a circle by setting width and height.");
        }

        public override void Rotate(float angle)
        {
            // Обчислення нових координат кола після обертання
            double radians = angle * Math.PI / 180.0;
            double cosTheta = Math.Cos(radians);
            double sinTheta = Math.Sin(radians);
            int newX = (int)(Position.X * cosTheta - Position.Y * sinTheta);
            int newY = (int)(Position.X * sinTheta + Position.Y * cosTheta);
            Position = new Point(newX, newY);
        }
    }

    // Клас для квадрата
    public class Square : Shape
    {
        public int SideLength { get; set; }

        public Square(Point position, int sideLength)
        {
            Position = position;
            SideLength = sideLength;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(Pens.Black, Position.X, Position.Y, SideLength, SideLength);
        }

        public override void Move(int deltaX, int deltaY)
        {
            Position = new Point(Position.X + deltaX, Position.Y + deltaY);
        }

        public override void Resize(int width, int height)
        {
            if (width != height)
            {
                throw new ArgumentException("Width and height must be equal for a square.");
            }

            SideLength = width;
        }

        public override void Rotate(float angle)
        {
            // Обертання квадрата відбувається за допомогою графічного перетворення
            Matrix matrix = new Matrix();
            matrix.RotateAt(angle, Position);
            Point[] points = { Position };
            matrix.TransformPoints(points);
            Position = points[0];
        }
    }

    // Клас для прямокутника
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(Point position, int width, int height)
        {
            Position = position;
            Width = width;
            Height = height;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(Pens.Black, Position.X, Position.Y, Width, Height);
        }

        public override void Move(int deltaX, int deltaY)
        {
            Position = new Point(Position.X + deltaX, Position.Y + deltaY);
        }

        public override void Resize(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override void Rotate(float angle)
        {
            Matrix matrix = new Matrix();
            matrix.RotateAt(angle, new Point(Position.X + Width / 2, Position.Y + Height / 2));
            Point[] points = { new Point(Position.X, Position.Y), new Point(Position.X + Width, Position.Y), new Point(Position.X, Position.Y + Height) };
            matrix.TransformPoints(points);

            // Оновлення координат та розмірів прямокутника
            int minX = points.Min(p => p.X);
            int minY = points.Min(p => p.Y);
            int maxX = points.Max(p => p.X);
            int maxY = points.Max(p => p.Y);
            Position = new Point(minX, minY);
            Width = maxX - minX;
            Height = maxY - minY;
        }
    }
}
