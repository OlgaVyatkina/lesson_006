// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int b1 = inputNumber("введите значение b1: ");
int b2 = inputNumber("введите значение b2: ");
int k1 = inputNumber("введите значение k1: ");
int k2 = inputNumber("введите значение k2: ");
Coord(b1, b2, k1, k2);

void Coord(int b1, int b2, int k1, int k2)
{

if (k1 != k2) {  
    double x = (b2 - b1)/(k1 - k2); 
    double y = k1 * x + b1; 
    Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
    }
else {
    Console.WriteLine($"Делить на ноль нельзя!");
     }
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

