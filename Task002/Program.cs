// Задача N2 Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double LinesCoordinates()
{
    double[] array = new double[4];
    Console.Write("Это программа по определению точки пересечения двух прямых, ");
    Console.WriteLine("в которой 'y' определяется формулой k * x + b, ");
    Console.WriteLine("а 'x' определяется случайной цифрой от 0 до 9");

    Console.WriteLine("Введите точку k1 первой прямой: ");
    double k1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите точку b1 первой прямой: ");
    double b1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите точку k2 второй прямой: ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите точку b2 второй прямой: ");
    double b2 = Convert.ToDouble(Console.ReadLine());

    double x1 = new Random().Next(0, 10);
    double x2 = new Random().Next(0, 10);
    double y1 = k1 * x1 + b1;
    double y2 = k2 * x2 + b2;

    Console.WriteLine("Координаты точек первой прямой(x/y): " + x1 + ", " + y1);
    Console.WriteLine("Координаты точек второй прямой(x/y): " + x2 + ", " + y2);
    array[0] = x1;
    array[1] = y1;
    array[2] = y2;
    array[3] = x2;
    return array[4];
}



LinesCoordinates();