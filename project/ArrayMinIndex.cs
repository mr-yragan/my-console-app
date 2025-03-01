//using System;

//namespace project
//{   /// <summary>
//    /// Работа с массивами
//    /// </summary>
//    internal class ArrayMinIndex
//    {
//        /// <summary>
//        /// Получаю корректные данные (числа) из массива строк.
//        /// </summary>
//        /// <param name="array"> Массив строк, из которого будут извлекаться данные. </param>
//        /// <returns> Возвращает массив чисел, но если нет корректных данных, то сообщаем пользователю, что в файле нет корректных данных. </returns>
//        public static int[]? GetRightData(ref string[]? array)
//        {
//            int validNumbersCount = 0;
//            // Каунтэр для хранения количества корректных данных => ТЕМ САМЫМ Я ИЩЮ РАЗМЕР ДЛЯ МАССИВА С КОРРЕКТНЫМИ ДАННЫМИ.

//            foreach (string str in array)  // Проходим по каждому элементу исходного массива.
//            {
//                if (int.TryParse(str, out _))
//                {
//                    validNumbersCount++; // Увеличиваем каунтер, если элемент является числом.
//                }
//            }
//            try
//            {
//                if (validNumbersCount == 0)
//                {
//                    Console.WriteLine("Sorry, but there are no correct numbers in the file.");
//                }
//            }
//            // Обрабатываю исключения, которые может выплюнуть WriteLine
//            catch (IOException ex)
//            {
//                Console.WriteLine($"Something went wrong: {ex.Message}");
//            }

//            int[] arr = new int[validNumbersCount]; // Создаю массив для хранения корректных чисел, туда я буду запихивать корректные данные
//            int thisRight = 0;
//            // Заполняю массив корр. числами.
//            foreach (string str in array)
//            {
//                if (int.TryParse(str, out int number))
//                {
//                    arr[thisRight] = number;
//                    thisRight++; // сдвигаемся по индексу
//                }
//            }
//            return arr; // Возвращаю массив корр. чисел.
//        }

//        /// <summary>
//        /// Находим мин. значение в массиве, учитывая число C в формуле для поиска мин. знач., и возвращаем его индексы.
//        /// </summary>
//        /// <param name="arr"> Массив целых чисел, в котором будет поиск мин. знач и его идекс(ов). </param>
//        /// <param name="C"> Пользовательское число, принаделащее отрезку [0; 1000] </param>
//        /// <returns> Возвращает строку, содержащую мин. знач. и его индекс(ы). </returns>
//        public static string FindMinAndIndexes(int[]? arr, ref int C)
//        {
//            string result = ""; // Cюда буду сохранять мин. знач. и его индекс(ы)
//            string cInStr; 
//            do
//            {
//                // Проверяю, является ли ввод корректным и удовлетворяет ли он допустимому диапазону.
//                Console.WriteLine("Please enter the number C assigned to the segment [0; 1000]");
//                cInStr = Console.ReadLine();
//                if (int.TryParse(cInStr, out C) && C >= 0 && C <= 1000)
//                {
//                    Console.WriteLine("Thank you! You have entered a number that satisfies the condition. The program completed its work successfully.");
//                    Console.WriteLine("If you want to end the program, press the spacebar (ESCAPE), ELSE PRESS ENTER");
//                }
//                else
//                {
//                    Console.WriteLine("Be CAREFUL! Please enter the number C again. You entered data that does NOT meet the criteria.");
//                }
//            } while (!(int.TryParse(cInStr, out C) && C >= 0 && C <= 1000));

//            int number = C; // Сохраняю правильное введенное число C
//            int minV = int.MaxValue; // Переменная для поиска минимума. minV - это наше R по формуле
//            if (arr.GetLength(0) > 0 && arr != null) // Проверяю, что массив не пуст и не равен null.
//            {
//                // Поиск мин. знач. по формуле 𝑅 = 𝑚𝑖𝑛|𝑋𝑖 − 𝐶|
//                for (int i = 0; i < arr.GetLength(0); ++i) 
//                {
//                    if (Math.Abs(arr[i] - C) < minV)
//                    {
//                        minV = arr[i];
//                    }
//                }

//                int countOfMinValues = 0; // Каунтэр для поиска количества минимумов в массиве.
//                for (int i = 0; i < arr.GetLength(0); ++i)
//                {
//                    if (arr[i] == minV)
//                    {
//                        countOfMinValues++;
//                    }
//                }

//                int[] index = new int[countOfMinValues]; // Длина массива равна длине количеству мин. знач.
//                int thisRight = 0;
//                for (int i = 0; i < arr.GetLength(0); ++i)
//                {
//                    if (arr[i] == minV)
//                    {
//                        index[thisRight] = i;
//                        thisRight++;
//                    }
//                }

//                if (countOfMinValues > 0)
//                {
//                    foreach (int i in index)
//                    {
//                        result = result + $"{i} "; // Получаем ответ
//                    }
//                }

//                else
//                {
//                    Console.WriteLine("Minimum value not found.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Sorry, but the array was empty or null.\n");
//            }

//            string joinResult = $"{minV.ToString() + " " + result}";
//            return joinResult; // Возвращем строку
//        }
//    }
//}
