// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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
    Console.Write("] ");
}

int[] StartMultiplyEndArray(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 == 1) size = size + 1;
    int[] newArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        if (i != arr.Length - 1 - i)
            newArr[i] = arr[i] * arr[(arr.Length - 1) - i];
        else newArr[i] = arr[i];
    }

    return newArr;
}

int[] array = CreateArrayRndInt(7, 1, 7);
PrintArray(array);
Console.Write(" => ");
int[] newArray = StartMultiplyEndArray(array);
PrintArray(newArray);
