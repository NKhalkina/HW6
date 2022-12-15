/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/


//получение числа с консоли
Console.Write("Введите элементы(через пробел): ");

//получает количество положительных чисел
int Count(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}

int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Console.WriteLine($"Количествово положительных чисел : {Count(arr)}");


