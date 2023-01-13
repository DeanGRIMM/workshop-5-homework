// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int [] array)
{
    for (int i=0;i<array.Length; i++)
        array[i] = new Random().Next(-10,11);
}

void PrintArray(int [] array)
{
    for (int i=0;i<array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void FindSums(int [] array)
{
    int sumE=0; //сумма чётных элементов массива
    for (int i=0;i<array.Length; i++)
    {
        if (i%2!=0) sumE+=array[i];
        
    }
    Console.WriteLine($"сумма чётных элементов равна {sumE}");
}

Console.WriteLine("Введите размер массива");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int[N];
FillArray(array);
PrintArray(array);
FindSums(array);