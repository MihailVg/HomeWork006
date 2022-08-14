// Задача N1 Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите количество чисел, с которым собираетесь работать: ");
int count = Convert.ToInt32(Console.ReadLine());

void FillArray(int[]array)
{
    Console.WriteLine("Вводите числа для массива: ");
    for(int index = 0; index < count; index++)
    {
        array[index] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array1)
{
    Console.WriteLine("Ваш массив: ");
    for(int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i] + " ");
    }
}

void NumbersMoreZero(int[] array2)
{
    int result = 0;
    for (int j = 0; j < array2.Length; j++)
    {
        if(array2[j] > 0) result++;
    }
    Console.WriteLine("Количество чисел в массиве больше нуля: " + result);
}

int[] array3 = new int[count];
FillArray(array3);
PrintArray(array3);
Console.WriteLine();
NumbersMoreZero(array3);

