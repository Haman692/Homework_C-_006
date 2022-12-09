// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double AddNumber(string str)
{
    System.Console.WriteLine(str);
    double num = Convert.ToInt32(Console.ReadLine());
    return num;
}

Console.Clear();
System.Console.WriteLine("Двe прямыe, заданныe уравнениями y = k1 * x + b1, y = k2 * x + b2");
double numk1 = AddNumber("Введите k1");
double numb1 = AddNumber("Введите b1");
double numk2 = AddNumber("Введите k2");
double numb2 = AddNumber("Введите b2");

// k1 * x + b1 = k2 * x + b2 > (k1 -k2) * x = b2 - b1 > x = (b2 - b1) / (k1 -k2)
// y = k1 * x + b1 > y = k1 * (b2 - b1) / (k1 -k2) +b1

double x = (numb2 - numb1) / (numk1 - numk2);
double y = numk1 * (numb2 - numb1) / (numk1 -numk2) +numb1;

System.Console.WriteLine($"Точка перечесения двух прямых - [{x}, {y}]");