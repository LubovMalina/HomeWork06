/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();
Console.WriteLine("Введите количество чисел, которые вы введете: ");
int number = int.Parse(Console.ReadLine());
int count = 0;

for (int i = 0; i < number; i++)
{
    Console.WriteLine("Введите число: ");
    int number1 = int.Parse(Console.ReadLine());
    if (number1>0)
    {
        count+=1;
    }
}
Console.WriteLine($"Вы ввели {count} чисел больше 0");