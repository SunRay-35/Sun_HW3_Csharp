// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int PromptInt(string strMessage) // Убрал пока проверку ошибок ввода, оставим на совести пользователя, буду искать правильный способ.
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

System.Console.WriteLine("Данная программа принимает на вход натуральное число и и выдаёт таблицу кубов чисел от 1 до N.");
int intN = PromptInt("Введите натуральное число N: "); // Пользователь вводит натуральное число N
if (intN > 0)
{
    string strResult = "";
    for (int i = 1; i <= intN; i++)
    {
        strResult = $"{strResult} {i*i*i},";
    }
    System.Console.WriteLine($"Кубы до 1 до {intN} соответственно равны:{strResult.TrimEnd(',')}");
}
else
{
    System.Console.WriteLine("Введено число меньше 1, попробуйте снова.");
}