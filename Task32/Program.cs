// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
    Console.Write("] => ");
}

void PrintArrayReplacement(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] * -1 + ",");
        else Console.Write(arr[i] * -1);
    }
    Console.Write("]");
}

int [] array = CreateArrayRndInt(7, -3, 3);

PrintArray(array);
PrintArrayReplacement(array);