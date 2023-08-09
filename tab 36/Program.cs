//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

class Program
{
    static void Main(string[] args)
    {
        const int arraySize = 4;
        int[] array = new int[arraySize];

        // Заполнение массива случайными числами
        Random random = new Random();
        for (int i = 0; i < arraySize; i++)
        {
            array[i] = random.Next(-100, 101);
        }

        // Вычисление суммы элементов, стоящих на нечётных позициях
        int sum = 0;
        for (int i = 1; i < arraySize; i += 2)
        {
            sum += array[i];
        }

        Console.WriteLine("Сумма элементов на нечётных позициях: " + sum);
        Console.ReadLine();
    }
}




