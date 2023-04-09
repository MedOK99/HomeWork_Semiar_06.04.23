/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */



Console.Clear();
Console.WriteLine("Введите длину массива");

int lenght = ReadNumberFromConsole();
int[] array = new int[lenght];
NewArray(array);
Console.Write("Массив: ");
PrintArray(array);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
  if (array[i] % 2 == 0)
    count++;
}
Console.WriteLine($"всего {array.Length} чисел, {count} из них чётные.");

int ReadNumberFromConsole()
{
  string input = Console.ReadLine();
  return int.Parse(input);
}

void PrintArray(int[] array)
{
  Console.Write("{");

  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
  Console.Write("}");
  Console.WriteLine();
}

void NewArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(100, 1000);
  }
}




