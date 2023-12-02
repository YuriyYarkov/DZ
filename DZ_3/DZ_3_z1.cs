//Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, 
//сумма цифр которого чётная.
while (true)
{
    Console.Write("Введите целое число или 'q' для выхода из программы: ");
    string input = Console.ReadLine();

    if (input == "q")
    {
        Console.WriteLine("Вы ввели 'q', программа завершена");
        break;
    }

    if (int.TryParse(input, out int number))
    {
        if (IsEvenDigitSum(number))
        {
            Console.WriteLine($"Сумма цифр числа {number} четная. Программа завершена.");
            break;
        }
        else
        {
            Console.WriteLine($"Сумма цифр числа {number} нечетная.");
        }
    }
    else
    {
        Console.WriteLine("Ошибка: Введенное значение не является целым числом.");
    }
}

bool IsEvenDigitSum(int number)
{
    int digitSum = 0;

    while (number != 0)
    {
        digitSum += number % 10;
        number /= 10;
    }

    return digitSum % 2 == 0;
}

