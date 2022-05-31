/* Задача 41. Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3  */


Console.WriteLine("Какое колличество чисел Вы хотите ввести?");
int quantityNumber = int.Parse(Console.ReadLine());
int [] array = new int [quantityNumber];
int calculateNumbers = 0;

/// Метод заполнения массива значениями пользователя
int FillArrayUserNumbers (int number)
{
    for (int i = 0; i < number; i++)
    {
        Console.WriteLine($"Введите {i + 1} число:");
        array[i] = int.Parse(Console.ReadLine());
    }
    return number;
}

/// Метод подсчёта положителных чисел массива
int CalculateArrayNumbers (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            calculateNumbers += 1;
    }
    return calculateNumbers;
}

/// Метод печати массива
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"| {array[i]} ");
    }
    Console.WriteLine("|");       //символ графически закрывающий массив
}

FillArrayUserNumbers(quantityNumber);
CalculateArrayNumbers(array);
PrintArray(array);
Console.WriteLine($"Во введённом массиве чисел больше 0 = {calculateNumbers}");
