// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


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

bool UserNumber(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (num == arr[i]) return true; 
    }
    return false;
}

Console.WriteLine("Введите число, которое хотите найти в массиве ");
int numberUser = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArrayRndInt(11, 0, 10);
PrintArray(array);
bool numuser = UserNumber(array, numberUser);
if (numuser)
{
    Console.WriteLine($" => Число {numberUser} есть в массиве");
}
else 
{
    Console.WriteLine($" => Числа {numberUser} нет в массиве");
}


