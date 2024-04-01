using System;
using System.Drawing;
using System.Text;

// Домашнє завдання №1
// Завдання 2

namespace Classes
{
    class Program
    {
        class Rectangle //Даний клас повинен бути у своєму файлі Rectangle.cs
        {
            private double side1, side2;

            public double AreaCalculator() //метод обчислює площу
            {
                return side1 * side2;
            }

            public double PerimeterCalculator() //метод обчислює периметр
            {
                return (side1 + side2) * 2;
            }

            public double Area //тільки приймаємо властивість площа
            {
                get { return AreaCalculator(); }
            }

            public double Perimeter //тільки приймаємо властивіть периметр
            {
                get { return PerimeterCalculator(); }
            }

            public Rectangle(double side1, double side2) //Конструктор приймає 2 параметри
            {
                this.side1 = side1;
                this.side2 = side2;
            }
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть довжину першої сторони прямокутника:");
            double.TryParse(Console.ReadLine(), out double side1);
            Console.WriteLine("Введіть довжину другої сторони прямокутника:");
            double.TryParse(Console.ReadLine(), out double side2);

            Rectangle rect = new Rectangle(side1, side2);
            Console.WriteLine("Периметр: " +  rect.Perimeter);
            Console.WriteLine("Площа: " + rect.Area);
            // Delay.
            Console.ReadKey();
        }
    }
}
