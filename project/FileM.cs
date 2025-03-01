//using System;
//using System.Text;
//namespace project
//{
//    /// <summary>
//    /// Работа с файлами
//    /// </summary>
//    internal class FileM
//    {
//        /// <summary>
//        /// Читаем данные из файла и возвращем массив строк или null.
//        /// </summary>
//        /// <param name="namePath"> Путь к файлу, с которым мы будем взаимодействовать. </param>
//        /// <returns> Возвращаем массив строк с данными из файла или null в случае возможного исключения. </returns>
//        public static string[]? ReadDataFromFile(string namePath)
//        {
//            string textFromFile; // Переменная для хранения текста из файла.
//            string[]? strArray; // Массив строк, который в итоге мы вернём.
//            try
//            {
//                textFromFile = File.ReadAllText(namePath, Encoding.UTF8); // Читаем текст из файла.
//                if (String.IsNullOrWhiteSpace(textFromFile)) // Проверяем на наличие данных в файле.
//                {
//                    throw new Exception("Sorry, but there is no data in the File");
//                } // Если ты не знаешь, что такое IsNullOrWhiteSpace или забыл, как он работает - прочитай документацию по ссылке снизу
//                  // https://learn.microsoft.com/ru-ru/dotnet/api/system.string.isnullorwhitespace?view=net-8.0
//                strArray = textFromFile.Split(';');  // Разделяем текст на массив строк по точке с запятой
//            }
//            // Обрабатываем исключения, которые может выплюнуть ReadAllText
//            catch (ArgumentNullException ex)
//            {
//                Console.WriteLine($"Ошибка аргумента: {ex.Message}");
//                return null;
//            }
//            catch (ArgumentException ex)
//            {
//                Console.WriteLine($"Ошибка аргумента: {ex.Message}");
//                return null;
//            }
//            catch (PathTooLongException ex)
//            {
//                Console.WriteLine($"Путь к файлу слишком длинный: {ex.Message}");
//                return null;
//            }
//            catch (DirectoryNotFoundException ex)
//            {
//                Console.WriteLine($"Указанный путь к файлу не найден: {ex.Message}");
//                return null;
//            }
//            catch (FileNotFoundException ex)
//            {
//                Console.WriteLine($"Входной файл на диске отсутствует: {ex.Message}");
//                return null;
//            }
//            catch (IOException ex)
//            {
//                Console.WriteLine($"Что-то пошло не так: {ex.Message}");
//                return null;
//            }
//            catch (UnauthorizedAccessException ex)
//            {
//                Console.WriteLine($"Отказано в доступе к файлу: {ex.Message}");
//                return null;
//            }
//            catch (NotSupportedException ex)
//            {
//                Console.WriteLine($"Операция не поддерживается: {ex.Message}");
//                return null;
//            }
//            // Я на всякий случай напишу этот catch, который написан снизу. Знаю, что ничего больше не возникает.
//            catch (Exception ex) // Обработка всех возможных остальных исключений 
//            {
//                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
//                return null;
//            }

//            // Тут я пытаюсь убрать пробелы в начале и конце каждой строки в массиве.
//            for (int i = 0; i < strArray.GetLength(0); ++i)
//            {
//                strArray[i] = strArray[i].Trim(); 
//                // Как работает метод Trim()?
//                // https://learn.microsoft.com/ru-ru/dotnet/api/system.string.trim?view=net-8.0
//            }
//            return strArray; // Возвращаю массив строк
//        }

//        /// <summary>
//        /// Записываем данные в указанный файл.
//        /// </summary>
//        /// <param name="namePath"> Путь к файлу для записи. </param>
//        /// <param name="dataWhichYouWantToSave"> Данные, которые нужно сохранить в файл. </param>
//        public static void WriteDataToFile(string namePath, string dataWhichYouWantToSave)
//        {
//            try
//            {
//                File.WriteAllText(namePath, dataWhichYouWantToSave, Encoding.UTF8); // Записываем данные в файл.
//            }
//            // Обрабатываем исключения, которые может выплюнуть WriteAllText
//            catch (ArgumentNullException ex)
//            {
//                Console.WriteLine($"Ошибка аргумента: {ex.Message}");
//            }
//            catch (ArgumentException ex)
//            {
//                Console.WriteLine($"Ошибка аргумента: {ex.Message}");
//            }
//            catch (PathTooLongException ex)
//            {
//                Console.WriteLine($"Путь к файлу слишком длинный: {ex.Message}");
//            }
//            catch (DirectoryNotFoundException ex)
//            {
//                Console.WriteLine($"Указанный путь к файлу не найден: {ex.Message}");
//            }
//            catch (IOException ex)
//            {
//                Console.WriteLine($"Что-то пошло не так: {ex.Message}");
//            }
//            catch (UnauthorizedAccessException ex)
//            {
//                Console.WriteLine($"Отказано в доступе к файлу: {ex.Message}");
//            }
//            catch (NotSupportedException ex)
//            {
//                Console.WriteLine($"Операция не поддерживается: {ex.Message}");
//            }
//            // Я на всякий случай напишу этот catch, который написан снизу. Знаю, что ничего больше не возникает.
//            catch (Exception ex) // Обработка всех возможных остальных исключений 
//            {
//                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
//            }
//        }
//    }
//}
