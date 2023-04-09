/* Задача 36: Задайте одномерный массив, заполненный случайными 
числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

Console.Clear();

Console.WriteLine("Введите размер массива: ");
int length = ReadNumberFromConsole();
int[] numbers = new int[length];
FillArrayRandomNumbers(numbers);
Console.Write("Мы получили массив: ");
PrintArray(numbers);
int sum = 0;

for (int n = 1; n < numbers.Length; n += 2)
  sum = sum + numbers[n];

Console.WriteLine($"всего в нём {numbers.Length} чисел, из которых сумма чисел на позициях с нечётным индексом = {sum}");

int ReadNumberFromConsole()
{
  string input = Console.ReadLine();
  return int.Parse(input);
}

void FillArrayRandomNumbers(int[] numbers)
{
  for (int i = 0; i < numbers.Length; i++)
  {
    numbers[i] = new Random().Next(1, 10);
  }
}

void PrintArray(int[] numbers)
{
  Console.Write("[ ");
  for (int i = 0; i < numbers.Length; i++)
  {
    Console.Write($"{numbers[i]} ");
  }
  Console.Write("]");
  Console.WriteLine();
}

