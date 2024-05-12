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
        Console.WriteLine();
        foreach (string word in ArrayPols)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }
 
string[] ArrayLess3(string[] ArrayPols)
    {
        string[] newArray = new string[ArrayPols.Length]; // Создаем новый массив такой же длины, как оригинальный
        int j = 0;                                        // Индекс для нового массива
        foreach (string word in ArrayPols)
        {
            if (word.Length <= 3)
            {
                newArray[j] = word;
                j++;
            }
        }
        return newArray;
    }

System.Console.WriteLine("Введите строку, разделяя слова пробелами:");
string pols = Console.ReadLine(); // Пользователь задаёт строку из слов
string[] ArrayPols = CreateArray(pols);
PrintArray(ArrayPols); // Печать оригинального массива
string[] NewArray = ArrayLess3(ArrayPols);
PrintArray(NewArray); // Печать нового массива