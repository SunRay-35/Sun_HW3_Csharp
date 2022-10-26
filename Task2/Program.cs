//Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

(double, double, double) Prompt3DCoords (string strMessage) // Убрал пока проверку ошибок ввода, оставим на совести пользователя, буду искать правильный способ.
{
    System.Console.Write(strMessage);
    string strTemp = System.Console.ReadLine();
    var Coords = strTemp.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
    double dblX = Convert.ToDouble(Coords[0]);
    double dblY = Convert.ToDouble(Coords[1]);
    double dblZ = Convert.ToDouble(Coords[2]);
    return (dblX, dblY, dblZ);
}

double DistanceBetweenTwo (double X1, double Y1, double Z1, double X2, double Y2, double Z2)
{
    return Math.Sqrt(Math.Pow(X2-X1,2) + Math.Pow(Y2-Y1,2) + Math.Pow(Z2-Z1,2));
}

double X1, X2, Y1, Y2, Z1, Z2;
System.Console.WriteLine("Данная программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве/");
(X1, Y1, Z1) = Prompt3DCoords("Введите координаты первой точки через пробел: ");
(X2, Y2, Z2) = Prompt3DCoords("Введите координаты второй точки через пробел: ");
// System.Console.WriteLine($"{X1} {Y1} {Z1}");
// System.Console.WriteLine($"{X2} {Y2} {Z2}");
System.Console.WriteLine($"Расстояние между точками ({X1} {Y1} {Z1}) и ({X2} {Y2} {Z2}) равно:{Math.Round(DistanceBetweenTwo(X1, Y1, Z1, X2, Y2, Z2), 2)}");