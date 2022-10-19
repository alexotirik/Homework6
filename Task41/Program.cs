/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Введите размер массива: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
FillArray(M);
Console.WriteLine($"Введено чисел больше 0: {CountNumbersMoreZero(array)} ");

void FillArray(int M)
{   
    
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine("Введите {0} элемнт массива",i);
        array[i] = Convert.ToInt32(Console.ReadLine()); 
    }
    string arr = string.Join(", ", array);
    Console.WriteLine("Ваш массив: " + $"[{arr}]");
     
}

int CountNumbersMoreZero(int[] array)
{
    int count = 0;
    for(int j = 0; j < array.Length; j++)
    {
        if(array[j] > 0)
        count++;    
    }
    return count;
}


