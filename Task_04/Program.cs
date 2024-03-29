using System;
using System.Drawing;
using System.Text;

// Домашнє завдання №1
// Завдання 4

namespace Classes
{
    class Program
    {
        class Point
        {
            private int x, y;
            private string name;

            public int X { get { return x; } }
            public int Y { get { return y; } }
            public string Name { get { return name; } }

            public Point(int x, int y, string name)
            {
                this.x = x;
                this.y = y;
                this.name = name;
            }

        }
        class Figure
        {
            private Point[] point; //масив точок (від 3 до 5)

            //Конструктори, спрацює той, де буде відповідна кількість аргументів
            public Figure(Point A, Point B, Point C)
            {
                point = new Point[] { A, B, C };
            }
            public Figure(Point A, Point B, Point C, Point D)
            {
                point = new Point[] { A, B, C, D };
            }
            public Figure(Point A, Point B, Point C, Point D, Point E)
            {
                point = new Point[] { A, B, C, D, E };
            }

            //Метод довжина між точками
            public double Length(Point A, Point B)
            {
                return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
            }

            //Метод периметр
            public void PerimeterCalc()
            {
                double perimeter = 0;
                for (int i = 0; i < point.Length; i++)
                {
                    Point currentPoints = point[i];
                    Point nextPoints = point[(i + 1) % point.Length];

                    perimeter += Length(currentPoints, nextPoints);
                }
                Console.WriteLine("Периметр фігури = " +  perimeter);
            }
        }
        static void Main()
        {
            // Створюємо точки
            Point A = new Point(1, 5, "A");
            Point B = new Point(6, 1, "B");
            Point C = new Point(4, 4, "C");
            Point D = new Point(5, 4, "D");

            Figure figure = new Figure(A, B, C, D);
            figure.PerimeterCalc();

            // Delay.
            Console.ReadKey();
        }
    }
}


