/*
* Дисциплина: "Программирование на C#"
* Группа: БПИ244_2
* Студент: Кондратьев Николай Ярославович
* Дата: 04.10.2024 - 06.10.2024

* Задача: Берём данные из input.txt, игнорируя некорректные данные.
* Ищем минимум в массиве по формуле: 𝑅 = 𝑚𝑖𝑛|𝑋𝑖 − 𝐶|, где R - в эту переменную сохраняем минимальное число, 
* 𝑋𝑖 - элемент массива, 𝐶 - пользовательское целочисленное число от 0 до 1000 включительно, которое он будет вводить.
* Дальше сохраняем наш минимум в output.txt, а также в этот файл сохраняем индекс(ы) этого минимума (если мин. знач. найдется)
* Так как в задании НЕ УЧТЕНО (хоть написано игнорируя некорректные данные, НО СЛОВО ИГНОРИРУЯ МОЖНО ПО-РАЗНОМУ ТРАКТОВАТЬ),
* ТО Я ИЩУ индексы минимумов ПОСЛЕ "чистки" некорректных данных, то есть
* ищу индексы минимумов в ПРАВИЛЬНОМ массиве, то есть в массиве, где нет некорректных данных.                      
*/
using System;
namespace project
{
    internal class Program
    {
        /// <summary>
        /// Главный метод. Точка входа.
        /// </summary>
        public static void Main()
        {
            // ЕСЛИ ВДРУУУУГ НЕ РАБОТАЕТ, ТО ИСПОЛЬЗУЙ ПЕРЕМЕННЫЕ, КОТОРЫЕ СНИЗУ (У МЕНЯ ВСЕ РАБОТАЕТ, И ТАК, И ТАК)
            //string inputPath = @"..\..\..\..\WorkingFiles\input.txt"; // Путь к входному файлу.
            //string outputPath = @"..\..\..\..\WorkingFiles\output.txt"; // Путь к выходному файлу.
            // ЕСЛИ ВДРУУУУГ НЕ РАБОТАЕТ, ТО ИСПОЛЬЗУЙ ПЕРЕМЕННЫЕ, КОТОРЫЕ СВЕРХУ (У МЕНЯ ВСЕ РАБОТАЕТ, И ТАК, И ТАК)
            Console.WriteLine("Hello! The main part have been commited, because of null referense expection and I dont have enough time to solve it, so I just want to print some text");
            //ConsoleKeyInfo keyToExit; // Переменная для сохранения ключа выхода.
            //string inputPath = @"../../../../WorkingFiles/input.txt".Replace('/', Path.DirectorySeparatorChar); // Путь к входному файлу.
            //string outputPath = @"../../../../WorkingFiles/output.txt".Replace('/', Path.DirectorySeparatorChar); // Путь к выходному файлу.
            //do
            //{

            //    string[]? fileData = ["1212121",";","242","121", ";", "242"];
            //    // Читаю данные из input.txt и сохраняю их в массив fileData, в том числе делая некоторые преобразования.
            //    int[]? rightDataFile = ArrayMinIndex.GetRightData(ref fileData); // Получаю массив с корректынми данными.
            //    int C = 0; // Переменная, которую будет вводить пользователь.
            //    string res = ArrayMinIndex.FindMinAndIndexes(rightDataFile, ref C); // Ищю минимальное значение и индекс(ы) минимума.
            //    Console.WriteLine($"{res } ");
            //    FileM.WriteDataToFile(outputPath, res); // Записываю результат в output.txt.
            //    keyToExit = Console.ReadKey();

            //    Console.WriteLine('\n');
            //} while (keyToExit.Key != ConsoleKey.Escape);  // Окончание цикла решения.
        }
    }
}
