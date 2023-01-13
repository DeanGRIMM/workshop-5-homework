// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double [] array)
{
        for (int i=0;i<array.Length; i++)
        array[i] = new Random().NextDouble()*10; 
}

void PrintArray(double [] array)
{
    for (int i=0;i<array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}
void Diff (double [] array)
{
    double max = array[0];
    double min = array[0];
    double Diff = 0;
    for (int i=1;i<array.Length; i++)
    {
        if (array[i]>max) max = array[i];
        if (array[i]<min) min = array[i];
    }  
    Diff = max - min;

    Console.WriteLine($"максимальный элемент массива {max}");
    Console.WriteLine($"минимальный элемент массива {min}");
    Console.WriteLine($"разница между максимальным и минимальным элементами массива {Diff}");
}


Console.WriteLine("Введите размер массива");
int N = Convert.ToInt32(Console.ReadLine());
double [] array = new double[N];
FillArray(array);
PrintArray(array);
Diff(array);