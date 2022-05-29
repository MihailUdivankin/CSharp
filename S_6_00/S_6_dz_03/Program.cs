// Задача 2. Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void CoordinatesIntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"Координаты точки пересечения: X = {x}, Y = {y}");
}
double b1 = 2; double k1 = 5;
double b2 = 4; double k2 = 9;
Console.WriteLine();
CoordinatesIntersectionPoint(b1,k1,b2,k2);
Console.WriteLine();