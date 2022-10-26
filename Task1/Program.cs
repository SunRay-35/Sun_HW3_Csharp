// Задача 1.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Без использования строк
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int PromptInt(string strMessage) // Убрал пока проверку ошибок ввода, оставим на совести пользователя, буду искать правильный способ.
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

bool ValidateFiveDigit(int intN)
{
    if (intN / 100000 == 0 && intN / 10000 > 0) return true;
    else return false;
}

int ReverseNumber(int intN) // Я принял решение переворачивать полностью число и не пытаться сравнивать частями.
{
    int intTemp = 0;
    while (intN >0)
    {
        intTemp = intTemp * 10 + intN % 10;
        intN = intN / 10;
    }
    return intTemp;
}

bool IsPalindrome(int intN)
{
    if (intN == ReverseNumber(intN)) return true;
    else return false;
}

System.Console.WriteLine("Данная программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
int intN = PromptInt("Введите пятизначное число: "); // Пользователь вводит пятизначное число N
if (ValidateFiveDigit(intN))
{
    if (IsPalindrome(intN))
    {
        System.Console.WriteLine($"Число {intN} является палиндромом.");
    }
    else
    {
        System.Console.WriteLine($"Число {intN} не является палиндромом.");
    }
}
else
{
    System.Console.WriteLine("Введено не пятизначное число, попробуйте снова.");
}