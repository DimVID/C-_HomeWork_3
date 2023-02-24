// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Проверка без применения строк
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int InputInt(string message)                                //название метода
{
    System.Console.Write($"{message}> ");                 //вывод приглашения ко вводу
    int value;                                            // инициализация переменной
    if (int.TryParse(Console.ReadLine(), out value))      //проверка условия корректности ввода + ввод со строки
    {                                                      //если конвертация строки прошла правильно, то мы попадаем в ветку, 
        return value;                                      //которая находится в скобках после наименования функции. Если да
    }                                                       //то выдает первое значение (ввод со строки). Нет - второе (out )
    System.Console.WriteLine("введено не целочисленное значение");
    Environment.Exit(1);                                  //если TryParse не сработало, выходим из программы (Exit) с кодом 1
    return 0;                                             //нужна для компиляции.
}

int lengthNumber = 5;       //заводим фиксированное требовании ввода чисел - пятизначное

bool ValidateValue(int value)
{
    int number = Convert.ToInt32(Math.Ceiling(Math.Log10(value))); //проверка числа на признак целочисленного
    if (number != lengthNumber)
    {
        System.Console.WriteLine($"введенное число меньше или больше {lengthNumber} цифр"); //вывод ошибки неверного количества чисел
        return false;
    }
    return true;
}

int number = InputInt($"введите пятизначное число");
if (ValidateValue(number))                            // условие проверки на соотвествие ввода пятизначного числа
{
    if (number == invertNumber(number))
    {
        System.Console.WriteLine($"число {number} - палиндром");
    }
    else
    {
        System.Console.WriteLine($"число {number} - не палиндром");
    }
}

int invertNumber(int value)
{
   int invert = 0;
    while (value>0)
    {
        invert = invert * 10 + value % 10;
        value = value / 10; 
    }
    return invert;
}
