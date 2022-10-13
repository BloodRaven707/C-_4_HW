namespace Console_Program
{
    class C_4
    {
            public static string[] ReadInputArray(string message = "Введите список чисел, через запятую:"){
            string[] result; 

            while ( true ) {
                Console.WriteLine(message);
                string someString = Console.ReadLine() ?? "";
            
                try {
                    // Дополнительно при разделении строки убираем пробелы
                    result = ((someString.Replace(" ", ""))).Split(",");
                    
                    // Проверка: вызовет исключение если один из элементов не целое число
                    foreach (string item in result)
                        int.Parse(item);

                    break;
                }
                catch {
                    Console.WriteLine("[!] Вы ввели не верные данные! Пример ввода: 1, 2, 5, 7, 19\n");
                }
            }
            return result; 
        }


         private static void Main(string[] args) {
			// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
            // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
            // 6, 1, 33 -> [6, 1, 33]
            Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.\n");

            string[] someArray = new string[8];
            someArray = ReadInputArray();

            Console.WriteLine($"{string.Join(", ", someArray)} -> [{string.Join(", ", someArray)}]\n");
		}
    }
}