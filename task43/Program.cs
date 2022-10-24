/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


using static System.Console;
Clear();

Write("Введите через пробел или через запятую b1, k1, b2, k2: ");
string[] numbers = ReadLine()!.Split(new char[]{' ',','},StringSplitOptions.RemoveEmptyEntries);
double[] coef = ConvertToIntstring(numbers);
if (coef[1]==coef[3]) WriteLine("Задайте другие k1 и k2");
double x = (coef[2]-coef[0])/(coef[1]-coef[3]);
double y = coef[1]*x+coef[0];
WriteLine($"Точкой пересечения двух прямых является точка с координатой х={x}, y={y}");




double[] ConvertToIntstring(string[] array)
{
    double[] result = new double[array.Length];
    for (int i=0; i<array.Length; i++)
    {
        result[i]=Convert.ToInt32(array[i]); 
    }
    return result;
}