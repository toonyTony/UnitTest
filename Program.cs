//Напишите метод, который принимает две пары чисел: первая – координаты (Х и У) точки А, вторая - координаты (Х и У) точки В. Метод возвращает длину отрезка АВ.
Console.Write("Введите координату x первой точки");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату y первой точки:");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату x второй точки:");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату y второй точки:");
double y2 = double.Parse(Console.ReadLine());

MyClass myClass = new MyClass();
double length = myClass.calculateLength(x1, y1, x2, y2);
Console.WriteLine($"Длина отрезка AB: {length}");
public class MyClass
{

    public double calculateLength(double x1, double y1, double x2, double y2)
    {
        double lenght = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return lenght;
    }
}

