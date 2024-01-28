// // Задача 1. Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// // Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// while (true) // true == true
// {
//     Console.Write("Введите текст: ");
//     string text = Console.ReadLine();
//     if (text == "q")
//         {
//         break;
//         }
//     // Нужно проверить, что строчка text cостоит ТОЛЬКО из цифр
//     int number; // 0, если в строчке есть символы или само число
//     if (int.TryParse(text, out number)) // == true (метод TryParse строчка (text) 
//                                         // приводится к целому числу (int) и результат 
//                                         // этой конвертации сохраняется в number (out number) 
//                                         // - возвращает во внешнюю переменную)
//         {
//             Console.WriteLine("Введенная строчка состоит из ЦИФР");
//             int sum = 0; // 56 => 6+5
//             while (number > 0)
//         {
//             sum = sum + number %10;
//             number /=10;
//         }
//     if (sum % 2 == 0)
//         {
//             break;
//         }
//     }
// }

// // Задача 2. Задайте массив заполненный случайными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size]; // Массив array на size элементов
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }
// // Вызов функции
// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] res = CreateArray(N, 100, 1000);
// // CreateArray(N, 10, 99) => массив, размер: N
// // каждый элемент: число от 10 до 99 вкл-но
// Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");

// int count = 0;
// for (int i = 0; i < res.Length; i++)
//     {
//         if (res[i] % 2 == 0)
//         {
//             count++; // count = count + 1
//         }
//     }
// Console.WriteLine($"Количество четных чисел в массиве: {count} ");


// // Задача 3/ Напишите программу, которая перевернёт одномерный массив 
// // (первый элемент станет последним, второй – предпоследним и т.д.).

// int[] array = { 11, 22, 33, 44, 55, 66, 77 };
// for (int i = array.Length - 1; i >= 0; i--)
// {
//     Console.Write(array[i]);
//     Console.Write(" ");
// }