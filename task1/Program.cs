// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int size = inputNumber("Введите количество чисел: ");
int[] Arr = GetArray(size);
PrintArray(Arr, CountPositive(Arr));


int[] GetArray(int size)
{
    int[] Arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Arr[i] = inputNumber("Введите число: ");
    }
    return Arr;
}


int CountPositive(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item > 0) 
            count ++;
        else continue; //пропустить итерацию
    }
    return count;
}


int inputNumber(string t)  
                {
                int number;
                while (true)
                    {
                    Console.Write(t);
                    string? text = Console.ReadLine();
                        if (int.TryParse(text, out number))
                        {
                            break;
                        }
                        Console.WriteLine("Это не число. Попробуйте еще раз.");
                    }
                return number;
                }


void PrintArray(int[] arr, int c)
{
    Console.WriteLine($"[{String.Join(", ", arr)}]");
    Console.WriteLine($"Количество чисел больше 0: {c}");
}