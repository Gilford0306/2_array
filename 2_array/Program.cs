//Задание 1
//Объявить одномерный(5 элементов) массив с име-
//нем A и двумерный массив (3 строки, 4 столбца) дроб -
//ных чисел с именем B. Заполнить одномерный массив 
//А числами, введенными с клавиатуры пользователем, а 
//двумерный массив В случайными числами с помощью 
//циклов. Вывести на экран значения массивов: массива
//А в одну строку, массива В — в виде матрицы. Найти в 
//данных массивах общий максимальный элемент, мини-
//мальный элемент, общую сумму всех элементов, общее 
//произведение всех элементов, сумму четных элементов 
//массива А, сумму нечетных столбцов массива В.

int[] A = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Input " + (i + 1) + " number");
    int num = int.Parse(Console.ReadLine());
    A[i] = num;
}
Console.WriteLine("\n");
Console.WriteLine("Array A");
for (int i = 0; i < A.Length; i++)
{
    Console.Write($"{A[i]}.");
}
Console.WriteLine("\n");

int sizeR = 3;
int sizeC = 4;
Random random = new Random();
int minRandom = 1;
int maxRandom = 100;
double[,] B = new double[sizeR, sizeC];
for (int i = 0; i < sizeR; i++)
{
    for (int j = 0; j < sizeC; j++)
    {
        double R = random.Next(minRandom, maxRandom);
        R /= 10;
        B[i, j] = R;
    }
}

Console.WriteLine("Array B");
for (int i = 0; i < sizeR; i++)
{
    for (int j = 0; j < sizeC; j++)
    {
        Console.Write($"{B[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine("\n");
double max = 0;
for (int i = 0; i < A.Length; i++)
{
    if (A[i] > max)
    {
        max = A[i];
    }

}
for (int i = 0; i < sizeR; i++)
{
    for (int j = 0; j < sizeC; j++)
    {
        if (B[i,j] > max)
            max = B[i,j];

    }
}
Console.WriteLine("Maximum -" + max);
Console.WriteLine("\n");
double min=11;
for (int i = 0; i < A.Length; i++)
{
    if (A[i] < min)
    {
        min = A[i];
    }

}
for (int i = 0; i < sizeR; i++)
{
    for (int j = 0; j < sizeC; j++)
    {
        if (B[i, j] < min)
            min = B[i, j];
    }
}
Console.WriteLine("Minimum - " + min);
Console.WriteLine("\n");
double sum = 0;
for (int i = 0; i < A.Length; i++)
{
       sum += Convert.ToDouble(A[i]);
}
for (int i = 0; i < sizeR; i++)
{
    for (int j = 0; j < sizeC; j++)
    {
        sum += B[i, j];
    }
}
Console.WriteLine("Sum - " + sum);
Console.WriteLine("\n");

double product = 1;
for (int i = 0; i < A.Length; i++)
{
        product *= Convert.ToDouble(A[i]);
}
for (int i = 0; i < sizeR; i++)
{
    for (int j = 0; j < sizeC; j++)
    {
        product *= B[i, j];
    }
}
Console.WriteLine("Product - " + product);
Console.WriteLine("\n");
int evenA = 0;
for (int i = 0; i < A.Length; i++)
{
    if ((i+1) % 2 == 0)
    {
        evenA += A[i];
    }
}
Console.WriteLine("Sum even arr A - " + evenA);
Console.WriteLine("\n");
double oodB=0;
for (int i = 0; i < sizeC; i++)
{
    if ((i+1) % 2 != 0)
    {
        double sumCol = 0;
        for (int j = 0; j < sizeR; j++)
        {
            sumCol += B[j, i];
        }
        oodB += sumCol;
    }
}
Console.WriteLine("Sum odd arr B - " + oodB);
