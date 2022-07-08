// Задача 25: Напишите цикл, который принимает на вход два натуральных числа (A и B) 
// и возводит число A в степень B.
// 3, 5 -> 243
// 2, 4 -> 16
/*
Console.WriteLine("Введите число A:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите число B:");
int degreeB = Convert.ToInt32(Console.ReadLine());
Homework4(numberA, degreeB);

void Homework4(int currentNumberA, int currentDegreeB)
{
int unswer = currentNumberA;
for(int step = 1; step < currentDegreeB; step++)
{
    unswer *= currentNumberA;
}
Console.WriteLine($"Число {currentNumberA} возведёное в степень {currentDegreeB} будет равно {unswer}");
}
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
Console.WriteLine("Введите число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Homework4_27(numberN);

void Homework4_27(int currentNumberN)
{
    int SUM=0;
    int unswer = currentNumberN;
    while(currentNumberN>0)
       {
         SUM +=currentNumberN%10;
         currentNumberN /= 10;
       }
    Console.WriteLine($"Сумма цифр в числе {numberN} равна {SUM}");
}
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и 
// выводит отсортированный по модулю массив.
// -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
// 6, 1, -33 -> [1, 6, -33]

/*
int[] Array = new int[8];
Random rand = new Random();
for (int step = 0; step < Array.Length; step++)
{
    Array[step] = rand.Next(-10,10);
}

PrintArray(Array);
Homework4_29(Array);

void PrintArray(int[] currentArray)
{
    Console.WriteLine("Вывод массива на экран:");
    for(int step = 0; step < currentArray.Length; step++)
    {
        Console.Write(currentArray[step] + "\t");
    }
    Console.WriteLine();
}

void Homework4_29(int[] currentArray)
{
    for (int i = 0; i < currentArray.Length - 1; i++)
    {
        int min=i;
        for (int j = i + 1; j < currentArray.Length; j++)
        {
            if (Math.Abs(currentArray[j]) < Math.Abs(currentArray[min]))
            {
                min = j;
            }
        }

        int temp = currentArray[min];
        currentArray[min] = currentArray[i];
        currentArray[i] = temp;
    }

    Console.WriteLine("Отсортированный массив:");
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write(currentArray[i] + "\t");
    }
}
*/


