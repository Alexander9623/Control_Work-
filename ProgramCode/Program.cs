// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
string[] array = new string[] { "Hello", "2", "world", "2023", "cat", "computer", "33" };
string[] arr1 = new string[array.Length];

Console.Write($"[{string.Join(",", array)}] =>");

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        arr1[i] = array[i];
}
arr1 = arr1.Where(arr1 => arr1 != null).ToArray();
Console.Write($" [{string.Join(",",arr1)}]");
