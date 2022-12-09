//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int DataNUmber(string str)
{
    System.Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void FindPositive(int[] arr, out int pos, out int neg, out int zero)
{
    pos = 0;
    neg = 0;
    zero = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
            pos++;
        if(arr[i] < 0)
            neg++;
        if(arr[i] == 0)
            zero++;
    }
}

Console.Clear();
int size = DataNUmber("Введите количесвто чисел");
int[] array = new int [size];
for (int i = 0; i < size; i++)
{
    array[i] = DataNUmber($"Введите {i + 1} число");
}
System.Console.WriteLine(string.Join( ", ", array));
FindPositive(array, out int pos, out int neg, out int zero );
System.Console.WriteLine("Среди введных: ");
System.Console.WriteLine("положительных - " + pos);
System.Console.WriteLine("отрицательных - " + neg);
System.Console.WriteLine("нулей - " + zero);