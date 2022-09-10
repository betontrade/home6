

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/* Решение внутри

int [] mass (int k)
{
    int [] masss = new int [k];
    for (int i = 0; i < k ; i++)
    {
        Console.Write(" Пожалуйста, введите число: ");
        int chi = Convert.ToInt32(Console.ReadLine());
        masss[i] = chi;

    }
return masss;
}

int kolich (int [] sammassiv)
{
    int count = 0;
    for (int i = 0; i < sammassiv.Length ; i++)
    {
        if (sammassiv[i] > 0)
        {
            count++;
        }
    }
return count ;
}

// ввел количество чисел

Console.Write(" Пожалуйста, введите количество чисел для ввода: ");
int kolvo = Convert.ToInt32(Console.ReadLine());

// заполнил массив

int [] megamassiv = mass(kolvo);

// посчитал количество чисел больше 0

Console.WriteLine($"->  {kolich(megamassiv)}" );

*/


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1 * x + b1 = k2 * x + b2

// x = (-b1 + b2) / (k1 - k2) Находим x
//  k1 * x + b1 == k2 * x + b2  Перепроверка

void Schet (double bb1, double kk1, double bb2, double kk2 )
{
    double x = (-bb1 + bb2) / (kk1 - kk2);
    double y = kk1 * x + bb1;
    if ((kk1*x + bb1) == (kk2 * x+ bb2))
    {
        Console.WriteLine($"-> ({x}; {y})");
    }
    else Console.WriteLine("Не получилось");
}

// Вводим данные

Console.Write("Пожалуйста введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Пожалуйста введите значение k1: ");
double k1 = Convert.ToDouble( Console.ReadLine());

Console.Write("Пожалуйста введите значение b2: ");
double b2 = Convert.ToDouble (Console.ReadLine());

Console.Write("Пожалуйста введите значение k2: ");
double k2 = Convert.ToDouble (Console.ReadLine());

// Считаем
// Выводим результат

Schet(b1, k1, b2, k2);


