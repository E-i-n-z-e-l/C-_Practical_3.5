// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random(); // var(вместо Random) - используют тогда, когда справа(после "=") точно известен тип данных;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1); // написали ("max + 1") чтобы учитывались максимальные значение при определении максимального и минимального числа в массиве;

    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

int NumberOfArrayElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] <= 100 & arr[i] >= 10) count = count + 1;
    }
    return count;
}

int [] array = CreateArrayRndInt(123, 0, 122);
PrintArray(array);
int elementsOfArray = NumberOfArrayElements(array);
Console.Write($" => {elementsOfArray}");