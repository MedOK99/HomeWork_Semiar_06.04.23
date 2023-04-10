// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();

Console.WriteLine("Введите длину массива: ");
int length = ReadNumberFromConsole();
double[] array = new double[length];  // завожу массив с элементами double, т.к. в условии указаны вещественные числа. А по определению: "Вещественные числа — это числа, у которых есть дробная часть (она может быть нулевой)." 
NewArray(array);
Console.Write("Мы получили массив: ");
PrintArray(array);
double min = array[0];      //double min = Int32.MaxValue; - нашёл такую запись в интернете, понял суть но не знаком с функцией которую описывает данная запись
double max = array[0];      //double max = Int32.MinValue; - нашёл такую запись в интернете, понял суть но не знаком с функцией которую описывает данная запись

for (int i = 0; i < array.Length; i++)   // завожу цикл для выявления max и min значений в массиве
{
  if (array[i] > max)
  {
    max = array[i];
  }
  if (array[i] < min)
  {
    min = array[i];
  }
}
Console.WriteLine($"Максимальное значение = {max}");
Console.WriteLine($"Минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {Math.Round(max - min, 2)}");  // установил вывод результата на 2 цифры после запятой, в противном случае получаем много цифр)

int ReadNumberFromConsole()   // метод для считывания данных из консоли
{
  string input = Console.ReadLine();
  return int.Parse(input);
}

void NewArray(double[] array)   //  метод для заполнения массива случайными числами double
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = Convert.ToDouble(new Random().Next(-10000, 10000)) / 100;  // при делении на 100 мы получаем дробные значения. Функция "Convert.ToDouble" преобразует значения в тип double.
  }
}

void PrintArray(double[] array)   // метод для вывода на печать массива "красивый")
{
  Console.Write("[ ");
  int count = array.Length;
  int position = 0;
  while (position < count - 1)
  {
    Console.Write($"{array[position]} | ");
    position++;
  }
  Console.Write($"{array[position]} ]");
  Console.WriteLine();
}


//  Решение с целыми числами
// Console.Clear();
// Console.WriteLine("Введите длину массива: ");
// int length = ReadNumberFromConsole();
// int[] array = new int[length];
// NewArray(array);
// Console.Write("Мы получили массив: ");
// PrintArray(array);
// int min = array[0];
// int max = array[0];

// for (int i = 0; i < array.Length; i++)   // завожу цикл для выявления max и min значений в массиве
// {
//   if (array[i] > max)
//   {
//     max = array[i];
//   }
//   if (array[i] < min)
//   {
//     min = array[i];
//   }
// }
// Console.WriteLine($"Максимальное значение = {max}");
// Console.WriteLine($"Минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// int ReadNumberFromConsole()   // метод для считывания данных из консоли
// {
//   string input = Console.ReadLine();
//   return int.Parse(input);
// }

// void NewArray(int[] array)   //  метод для заполнения массива случайными числами
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = new Random().Next(-999, 1000);
//   }
// }

// void PrintArray(int[] array)   // метод для вывода на печать массива "красивый")
{
  Console.Write("[ ");
  int count = array.Length;
  int position = 0;
  while (position < count - 1)
  {
    Console.Write($"{array[position]} | ");
    position++;
  }
  Console.Write($"{array[position]} ]");
  Console.WriteLine();
}