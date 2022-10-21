using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figure
{
    public abstract class GeometricFigure
    {
        public abstract int Area();
        public abstract int Perimeter();
        public abstract void Figure_Name();

    };

    public class Triangle : GeometricFigure
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int H { get; set; }
        public Triangle(int ap, int bp, int cp, int hp)
        {

            A = ap;
            B = ap;
            C = cp;
            H = hp;
        }

        public override void Figure_Name()
        {
            Console.WriteLine("\nTriangle: ");
            Console.WriteLine("S = (b * h) / 2;");
            Console.WriteLine("P = (a+b+c);");
        }

        public override int Area()
        {
            int S;
            S = (B * H) / 2;
            return S;
        }
        public override int Perimeter()
        {

            int P;
            P = (A + B + C);
            return P;
        }

    };
    public class Square : GeometricFigure
    {

        public int A { get; set; }

        public Square(int ap)
        {

            A = ap;
        }

        public override void Figure_Name()
        {
            Console.WriteLine("\nSquare: ");
            Console.WriteLine("S=(int)Math.Pow(a,2);");
            Console.WriteLine("P = a *4;");

        }
        public override int Area()
        {
            int S;
            S = (int)Math.Pow(A, 2);

            return S;
        }
        public override int Perimeter()
        {
            int P;
            P = A * 4;
            return P;
        }

    };
    public class Rhombus : GeometricFigure
    {
        public int A { get; set; }
        public int H { get; set; }
        public Rhombus(int ap, int hp)
        {

            A = ap;
            H = hp;
        }
        public override void Figure_Name()
        {
            Console.WriteLine("\nRhombus: ");
            Console.WriteLine("S = a*h;");
            Console.WriteLine("P = a *4;");

        }
        public override int Area()
        {
            int S;
            S = A * H;
            return S;
        }
        public override int Perimeter()
        {
            int P;
            P = A * 4;
            return P;
        }

    };
    public class Rectangle : GeometricFigure
    {
        public int A { get; set; }
        public int B { get; set; }
        public Rectangle(int ap, int bp)
        {
            A = ap;
            B = bp;
        }
        public override void Figure_Name()
        {
            Console.WriteLine("\nRectangle: ");
            Console.WriteLine("S = a*b;");
            Console.WriteLine("P = 2*(a+b);");

        }
        public override int Area()
        {
            int S;
            S = A * B;
            return S;
        }
        public override int Perimeter()
        {
            int P;
            P = 2 * (A + B);
            return P;
        }

    };
    public class Parallelogram : GeometricFigure
    {
        public int A { get; set; }
        public int B { get; set; }
        public int H { get; set; }

        public Parallelogram(int a, int b, int h)
        {
            A = a;
            B = b;
            H = h;

        }
        public override void Figure_Name()
        {
            Console.WriteLine("\nParallelogram: ");
            Console.WriteLine("S = a * h;");
            Console.WriteLine("P = 2*(a+b);");

        }
        public override int Area()
        {
            int S;
            S = A * H;
            return S;
        }
        public override int Perimeter()
        {
            int P;
            P = 2 * (A + B);
            return P;
        }

    };
    public class Trapezium : GeometricFigure
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public int H { get; set; }

        public Trapezium(int a, int b, int c, int d, int h)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            H = h;

        }
        public override void Figure_Name()
        {
            Console.WriteLine("\nTrapezium: ");
            Console.WriteLine("S = (a + b)/2*h;");
            Console.WriteLine("P = a+b+c+d;");

        }
        public override int Area()
        {
            int S;
            S = (A + B) / 2 * H;
            return S;
        }
        public override int Perimeter()
        {
            int P;
            P = A + B + C + D;
            return P;
        }


    };
    public class Circle : GeometricFigure
    {
        public int R { get; set; }


        public Circle(int r)
        {
            R = r;
        }
        public override void Figure_Name()
        {
            Console.WriteLine("\nCircle: ");
            Console.WriteLine("S = (int)(3.14*Math.Pow(R,2));");
            Console.WriteLine("P = (int)2*3,14*r;");
        }
        public override int Area()
        {
            int S;
            S = (int)(3.14 * Math.Pow(R, 2));
            return S;
        }
        public override int Perimeter()
        {
            int P;
            P = (int)(2 * 3.14 * R);
            return P;
        }

    };
    public class Ellipse : GeometricFigure
    {
        public int A { get; set; }
        public int B { get; set; }

        public Ellipse(int a, int b)
        {
            A = a;
            B = b;
        }
        public override void Figure_Name()
        {
            Console.WriteLine("\nEllipse: ");
            Console.WriteLine("S = (int)(3.14*a*b);");
            Console.WriteLine("P = (int)(4*(3.14*A*B+ Math.Pow((A-B), 2))/(A+B));");
        }
        public override int Area()
        {
            int S;
            S = (int)(3.14 * A * B);
            return S;
        }
        public override int Perimeter()
        {
            int P;
            P = (int)(4 * (3.14 * A * B + Math.Pow((A - B), 2)) / (A + B));
            return P;
        }

    };

    public class CompoundFigure
    {
        GeometricFigure[] S;
        public CompoundFigure(params GeometricFigure[] s)
        {
            S = s;
        }

        public int Area()
        {
            int Sum = 0;
            foreach (var t in S)
            {
                Sum += t.Area();
            }
            return Sum;
        }

    }
    class Program
    {
       


        static void Main(string[] args)
        {
            GeometricFigure[] S = { new Triangle(5, 5, 5, 5), new Square(4), new Rhombus(5,5), 
                new Rectangle(5,5), new Parallelogram(5,5,5), new Trapezium(2,5,5,5,5),
            new Circle(5), new Ellipse(5,5) };

            foreach (var figure in S)
            {
                figure.Figure_Name();
                Console.WriteLine("                   S = "+figure.Area()+";");
                Console.WriteLine("                   P = " + figure.Perimeter() + ";");
            }

            CompoundFigure G = new CompoundFigure(new Triangle(5, 5, 5, 5), new Square(4), new Rhombus(5, 5),
                new Rectangle(5, 5), new Parallelogram(5, 5, 5), new Trapezium(2, 5, 5, 5, 5),
            new Circle(5), new Ellipse(5, 5));
            Console.WriteLine("\n\nПлощадь  составной фигуры = " + G.Area());
          
        }
    }

   
}
