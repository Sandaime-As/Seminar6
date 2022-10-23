/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

using static System.Console;

Clear();

Write("Введите числа на ваше усмотрение: ");
string[] numbers = (ReadLine()!).Split(" ", StringSplitOptions.RemoveEmptyEntries);
int result = AmountOfNumbers(numbers);
WriteLine($"Количество введённых чисел больше 0 ввёл пользователь = {result}");



int AmountOfNumbers(string[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (Convert.ToInt32(array[i]) > 0)
            result++;
    }
    return result;
}