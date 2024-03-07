// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

void RecursiveArrayPrint (int [] arr, int index = 0)
{
    if (index == arr.Length)
    { 
    return;
    }
    RecursiveArrayPrint(arr, index + 1);
    Console.Write($"{arr[index]} ");
  
}

void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} ");
    }    
    Console.WriteLine();
}


int [] array = {1, 2, 5, 0, 10, 34};
PrintArray(array);
RecursiveArrayPrint(array);
