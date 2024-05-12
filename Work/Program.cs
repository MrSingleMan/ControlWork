// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] CreateArray(string pols) //Функция создания массива из строки
    {
        string[] ArrayPols = pols.Split(' '); // Разбиваем введенную строку на элементы массива по пробелам и сохраняем в массив
        return ArrayPols;
    }

void PrintArray(string[] ArrayPols) //Функция печати массива
    {
        for (int i = 0; i < ArrayPols.Length; i++)
        {
            System.Console.Write(ArrayPols[i] + " ");
        }
            System.Console.WriteLine();
    }
 
System.Console.WriteLine("Введите строку, разделяя слова пробелами:");
string pols = Console.ReadLine();

PrintArray(CreateArray(pols)); // Печать оригинального массива


